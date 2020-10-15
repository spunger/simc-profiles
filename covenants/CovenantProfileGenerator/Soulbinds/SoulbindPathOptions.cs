using System.Collections.Generic;

namespace CovenantProfileGenerator.Soulbinds
{
    public class SoulbindPathOptions
    {
        public int RankConduits { get; set; }
        public int Renown { get; set; }
        public string Class { get; set; }
        public string Spec { get; set; }
        public IEnumerable<Conduit> AllowedEnduranceConduits { get; set; }
        public IEnumerable<Conduit> AllowedFinesseConduits { get; set; }
        public IEnumerable<SoulbindAbility> IgnoredSoulbindAbilities { get; set; }
        public IEnumerable<Conduit> IgnoredPotencyConduits { get; set; }
        public IEnumerable<Conduit> MustHavePotencyConduits { get; set; }
    }
}
