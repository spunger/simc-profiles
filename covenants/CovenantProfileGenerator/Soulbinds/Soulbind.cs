using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace CovenantProfileGenerator.Soulbinds
{
    public class Soulbind
    {
        public string Code { get; internal set; }
        public string CovenantCode { get; internal set; }
        public string Name { get; internal set; }
        public Covenant Covenant => Data.GetCovenantByCode(CovenantCode);
        public ReadOnlyCollection<SoulbindAbility> Abilities { get; private set; }
        public SoulbindTree Tree { get; private set; }

        public ReadOnlyCollection<SoulbindPath> GetSoulbindPaths(SoulbindPathOptions options)
        {
            options.MustHavePotencyConduits = options.MustHavePotencyConduits ?? Enumerable.Empty<Conduit>();
            options.AllowedEnduranceConduits = options.AllowedEnduranceConduits ?? Enumerable.Empty<Conduit>();
            options.AllowedFinesseConduits = options.AllowedFinesseConduits ?? Enumerable.Empty<Conduit>();
            options.IgnoredPotencyConduits = options.IgnoredPotencyConduits ?? Enumerable.Empty<Conduit>();
            options.IgnoredSoulbindAbilities = options.IgnoredSoulbindAbilities ?? Enumerable.Empty<SoulbindAbility>();

            var pathsGeneric = GetSoulbindPathsGeneric(options.Renown).Where(a=>!options.IgnoredSoulbindAbilities.Intersect(a).Any());

            var conduits = Data.GetPotencyConduitsBySpec(Covenant.Name, options.Class, options.Spec, options.RankConduits)
                .AsEnumerable()
                .Except(options.IgnoredPotencyConduits)
                .Union(Data.GetFinesseConduitsByClass(options.Class, options.RankConduits).Intersect(options.AllowedFinesseConduits))
                .Union(options.AllowedEnduranceConduits);

            var mustHaveConduits = conduits.Intersect(options.MustHavePotencyConduits);

            var paths = new List<SoulbindPath>();

            foreach (var pathGeneric in pathsGeneric)
            {
                var combinations = GetSoulbindConduitCombinations(pathGeneric.Where(a => a.Type != SoulbindAbilityType.Soulbind),conduits)
                    .Where(c => !mustHaveConduits.Except(c).Any());

                foreach (var combination in combinations)
                {
                    var indizes = new Dictionary<SoulbindAbilityType, int>
                    {
                        [SoulbindAbilityType.PotencyConduit] = 0,
                        [SoulbindAbilityType.FinesseConduit] = 0,
                        [SoulbindAbilityType.EnduranceConduit] = 0
                    };

                    var path = new SoulbindPath();
                    foreach (var ability in pathGeneric)
                    {
                        if (ability.Type == SoulbindAbilityType.Soulbind)
                            path.Add(ability);
                        else if (ConvertToSoulbindConduit(ability, combination, indizes) is SoulbindConduit soulbindConduit)
                        {
                            path.Add(soulbindConduit);
                            indizes[ability.Type]++;
                        }

                    }
                    if (!paths.Contains(path))
                        paths.Add(path);
                }
            }
            return paths.AsReadOnly();
        }
        internal void Init()
        {
            Abilities = InitAbilities();
            Tree = InitTree();
        }
        private SoulbindTree InitTree()
        {
            if (String.IsNullOrWhiteSpace(Code))
                throw new InvalidOperationException("Soulbind Name missing.");

            if (!Abilities.Any())
                return null;

            var tree = new SoulbindTree();

            for (int i = Abilities.Max(a => a.Tier); i > 1; i--)
            {
                var abilitiesInTier = Abilities.Where(a => a.Tier == i);
                var abilitiesInPrevTier = Abilities.Where(a => a.Tier == i - 1);

                if (abilitiesInTier.Count() > 1 && abilitiesInPrevTier.Count() > 1)
                    foreach (var ability in abilitiesInTier)
                        tree.Add(new SoulbindEdge(
                            ability.ParentId ?? throw new InvalidOperationException("ParentId needed but missing"),
                            ability.Id));

                else if ((abilitiesInTier.Count() == 1) || abilitiesInTier.Count() > 1 && abilitiesInPrevTier.Count() == 1)
                    foreach (var ability in abilitiesInTier)
                        foreach (var abilityPrev in abilitiesInPrevTier)
                            tree.Add(new SoulbindEdge(
                                abilityPrev.Id,
                                ability.Id));
                
                else if (abilitiesInTier.Count() == 1 && abilitiesInPrevTier.Count() == 1)
                    tree.Add(new SoulbindEdge(
                        abilitiesInPrevTier.First().Id,
                        abilitiesInTier.First().Id
                        )); 
            }
            tree.Reverse();
            return tree;
        }
        private ReadOnlyCollection<SoulbindAbility> InitAbilities() =>
            Data.GetSoulbindAbilities()
            .Where(a => a.SoulbindCode == Code)
            .OrderBy(a => a.Tier)
            .ToList()
            .AsReadOnly();

        private SoulbindConduit ConvertToSoulbindConduit(SoulbindAbility ability,
                                                         IEnumerable<Conduit> combination,
                                                         Dictionary<SoulbindAbilityType, int> indizes)
        {
            if (combination.Where(c => c.Type == ability.Type)
                           .ElementAtOrDefault(indizes[ability.Type]) is Conduit conduit)
                return new SoulbindConduit()
                {
                    Id = conduit.Id,
                    Code = conduit.Code,
                    Name = conduit.Name,
                    Rank = conduit.Rank,
                    Spec = conduit.Spec,
                    Class = conduit.Class,
                    Type = conduit.Type,
                    SpellId = conduit.SpellId,
                    AllowedDefault = conduit.AllowedDefault,
                    IgnoredDefault = conduit.IgnoredDefault,
                    MusthaveDefault = conduit.MusthaveDefault,
                    ParentId = ability.ParentId,
                    Renown = ability.Renown,
                    Tier = ability.Tier,
                    SoulbindCode = ability.SoulbindCode,
                    
                };
            else
                return null;
        }
        private IEnumerable<IEnumerable<Conduit>> GetSoulbindConduitCombinations(IEnumerable<SoulbindAbility> conduitAbilities,
                                                                                 IEnumerable<Conduit> conduits)
        {
            var combinationsPotency = GetCombinationsByType(SoulbindAbilityType.PotencyConduit, conduitAbilities, conduits);
            var combinationsEndurance = GetCombinationsByType(SoulbindAbilityType.EnduranceConduit, conduitAbilities, conduits);
            var combinationsFinesse = GetCombinationsByType(SoulbindAbilityType.FinesseConduit, conduitAbilities, conduits);

            return from cp in combinationsPotency
                   from ce in combinationsEndurance
                   from cf in combinationsFinesse
                   select cp.Union(ce.Union(cf));
            
        }
        private IEnumerable<IEnumerable<Conduit>> GetCombinationsByType(SoulbindAbilityType type,
                                                                        IEnumerable<SoulbindAbility> conduitAbilities,
                                                                        IEnumerable<Conduit> conduits)
        {
            var conduitAbilitiesType = conduitAbilities.Where(a => a.Type == type);
            var conduitsType = conduits.Where(c => c.Type == type);
            return conduitsType.DifferentCombinations(Math.Min(conduitsType.Count(), conduitAbilitiesType.Count()));
        }
        private IEnumerable<SoulbindPath> GetSoulbindPathsGeneric(int renown)
        {
            var ids = new List<string>();

            var grapRenown = Tree.Where(x => x.End.Renown <= renown);
            var abilitiesRenown = Abilities.Where(x => x.Renown <= renown);

            foreach (var ability in abilitiesRenown)
                ids.Add(ability.Id);

            ids = ids.ToList();

            var pathfinder = new Pathfinder(ids.Count);

            foreach (var edge in grapRenown)
                pathfinder.AddEdge(ids.IndexOf(edge.BeginId), ids.IndexOf(edge.EndId));

            foreach (var abilityBegin in abilitiesRenown.Where(a=>a.Tier == abilitiesRenown.Min(t=>t.Tier))) // multiple abilities to begin
                foreach (var abilityEnd in abilitiesRenown.Where(a => a.Tier == abilitiesRenown.Max(t => t.Tier))) // multiple abilities to end
                    foreach (var path in pathfinder.FindAllPaths(ids.IndexOf(abilityBegin.Id), ids.IndexOf(abilityEnd.Id))) // find paths
                        yield return new SoulbindPath(path.ConvertAll(id => Data.GetSoulbindAbilityById(ids[id])));
        }
        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}
