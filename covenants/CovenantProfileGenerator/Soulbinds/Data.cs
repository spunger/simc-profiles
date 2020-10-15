using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CovenantProfileGenerator.Soulbinds
{
    public class Data
    {
        private static ReadOnlyCollection<Conduit> conduits;
        private static ReadOnlyCollection<SoulbindAbility> soulbindAbilities;
        private static ReadOnlyCollection<Covenant> covenants;
        private static ReadOnlyCollection<Soulbind> soulbinds;

        public static SoulbindAbility GetSoulbindAbilityById(string id)
            => GetSoulbindAbilities().Where(a => a.Id == id).FirstOrDefault();
        public static Covenant GetCovenantByCode(string code)
            => GetCovenants().Where(c => c.Code == code).FirstOrDefault();
        public static ReadOnlyCollection<SoulbindAbility> GetSoulbindAbilities()
        {
            soulbindAbilities = soulbindAbilities ??
                GetCsvRecords<SoulbindAbility>(@"Soulbinds\SoulbindAbilities.csv");

            return soulbindAbilities;
        }
        public static ReadOnlyCollection<Soulbind> GetSoulbinds()
        {
            //soulbinds = 
            if (soulbinds == null)
            {
                soulbinds = GetCsvRecords<Soulbind>(@"Soulbinds\Soulbinds.csv");
                foreach (var soulbind in soulbinds)
                    soulbind.Init();
            }

            return soulbinds;
        }
        public static ReadOnlyCollection<Conduit> GetConduits()
        {
            conduits = conduits ??
                GetCsvRecords<Conduit>(@"Soulbinds\Conduits.csv");

            return conduits;
        }
        public static Conduit GetConduitsById(string id)
            => GetConduits().Where(c => c.Id == id).FirstOrDefault();
        public static ReadOnlyCollection<Conduit> GetPotencyConduitsBySpec(string covenant, string wowClass, string spec, int rank)
        {
            var conduits = GetConduits()
                .Where(x =>
                    x.Type == SoulbindAbilityType.PotencyConduit
                    && ((x.Spec == spec && x.Class == wowClass) || (x.Spec == covenant && x.Class == "Covenant")))
                .ToList();

            conduits.ForEach(c => c.Rank = rank);

            return conduits.AsReadOnly();
        }
        public static ReadOnlyCollection<Conduit> GetFinesseConduitsByClass(string wowClass, int rank)
        {
            var conduits = GetConduits()
                .Where(x =>
                    x.Type == SoulbindAbilityType.FinesseConduit
                    && (x.Class == wowClass))
                .ToList();

            conduits.ForEach(c => c.Rank = rank);

            return conduits.AsReadOnly();
        }
        public static IEnumerable<Covenant> GetCovenants()
        {
            covenants = covenants ??
                GetCsvRecords<Covenant>(@"Soulbinds\Covenants.csv");

            return covenants;
        }
        internal static SoulbindAbilityType GetAbilityTypeFromText(string abilityTypeText)
        {
            switch (abilityTypeText)
            {
                case "sb":
                    return SoulbindAbilityType.Soulbind;
                case "pc":
                    return SoulbindAbilityType.PotencyConduit;
                case "fc":
                    return SoulbindAbilityType.FinesseConduit;
                case "ec":
                    return SoulbindAbilityType.EnduranceConduit;
                default:
                    throw new InvalidOperationException("Invalid AbilityText");
            }
        }
        private static ReadOnlyCollection<T> GetCsvRecords<T>(string csvFilename)
        {
            using (var reader = new StreamReader(csvFilename))
            using (var csv = GetCsvReader(reader))    
                return csv.GetRecords<T>().ToList().AsReadOnly();
            
        }
        private static CsvReader GetCsvReader(StreamReader reader)
        {
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Configuration.MissingFieldFound = null;
            csv.Configuration.HeaderValidated = null;
            csv.Configuration.IncludePrivateMembers = true;
            csv.Configuration.RegisterClassMap<SoulbindAbilityMap>();
            csv.Configuration.RegisterClassMap<ConduitsMap>();
            return csv;
        }

    }
    sealed class SoulbindAbilityMap: ClassMap<SoulbindAbility>
    {
        public SoulbindAbilityMap()
        {
            Map(m => m.Id);
            Map(m => m.Code);
            Map(m => m.Name);
            Map(m => m.Type).ConvertUsing(row => Data.GetAbilityTypeFromText(row.GetField("Type")));
            Map(m => m.Tier);
            Map(m => m.Renown);
            Map(m => m.SoulbindCode);
            Map(m => m.ParentId);
        }
    }
    sealed class ConduitsMap : ClassMap<Conduit>
    {
        public ConduitsMap()
        {
            Map(m => m.Id);
            Map(m => m.Code);
            Map(m => m.Name);
            Map(m => m.Type).ConvertUsing(row => Data.GetAbilityTypeFromText(row.GetField("Type")));
            Map(m => m.SpellId);
            Map(m => m.Rank);
            Map(m => m.Class);
            Map(m => m.Spec);
        }
    }
}
