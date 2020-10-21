using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovenantProfileGenerator
{
    public class Result
    {
        public double DpsMedian { get; set; }
        public string NameProfileset { get; set; }
        public string Spec { get; set; }
        public string Covenant { get; set; }
        public string Talents { get; set; }
        public int Targets { get; set; }
        public string Legendary { get; set; }
        public double Int { get; set; }
        public double Haste { get; set; }
        public double Crit { get; set; }
        public double Mastery { get; set; }
        public double Versatility { get; set; }
    }
}
