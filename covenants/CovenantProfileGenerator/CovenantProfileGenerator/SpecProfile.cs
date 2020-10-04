using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovenantProfileGenerator
{
    public class SpecProfile
    {
        public string Name { get; set; }
        public string General { get; set; }
        public string Equip { get; set; }
        public string Apl { get; set; }
        public string SoulbindsKyr { get; set; }
        public string SoulbindsNec { get; set; }
        public string SoulbindsNightfae { get; set; }
        public string SoulbindsVenthyr { get; set; }

        public override string ToString()
           => Name ?? "unkown Spec";
    }
}
