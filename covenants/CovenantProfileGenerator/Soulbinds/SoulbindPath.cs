using System;
using System.Collections.Generic;
using System.Linq;

namespace CovenantProfileGenerator.Soulbinds
{
    public class SoulbindPath: List<SoulbindAbility>, IEquatable<SoulbindPath>
    {
        public SoulbindPath() { }
        public SoulbindPath(IEnumerable<SoulbindAbility> abilities)
        {
            AddRange(abilities);
        }
        public virtual string SimcString => $"soulbind={String.Join("/", this.OrderBy(x => x.Type).Select(a => a.SimcString))}";
        public virtual string SimcNameString => $"{this.FirstOrDefault()?.SoulbindCode} - {String.Join("/", this.OrderBy(x=>x.Type).Select(a => a.ToString()))}";
        public virtual string SimcProfilesetString => $"profileset.\"{SimcNameString}\"+={SimcString}";

        public override bool Equals(object obj)
        {
            return Equals(obj as SoulbindPath);
        }

        public bool Equals(SoulbindPath other)
        {
            return other != null &&
                   SimcString == other.SimcString;
        }

        public override int GetHashCode()
        {
            return -39561944 + EqualityComparer<string>.Default.GetHashCode(SimcString);
        }

        public override string ToString()
            => SimcString;
    }
}
