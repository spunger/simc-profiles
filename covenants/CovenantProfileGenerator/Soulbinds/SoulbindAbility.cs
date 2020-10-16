using System;

namespace CovenantProfileGenerator.Soulbinds
{
    public class SoulbindAbility
    {
        
        public string Id { get; internal set; }
        public string Code { get; internal set; }
        public string Name { get; internal set; }
        public SoulbindAbilityType Type { get; internal set; }
        public int Tier { get; internal set; }
        public int Renown { get; internal set; }
        public string SoulbindCode { get; internal set; }
        public string ParentId { get; internal set; }
        public bool IgnoredDefault { get; set; }
        public override string ToString()
            => Code ?? base.ToString();
        public virtual string SimcString => Id;

        public override bool Equals(object obj)
        {
            if (!(obj is SoulbindAbility sb))
                return false;

            if (!String.IsNullOrWhiteSpace(this.Id) && !String.IsNullOrWhiteSpace(sb.Id))
                return sb.Id.Equals(this.Id);

            return Object.ReferenceEquals(this, sb);
        }
        public override int GetHashCode()
        {
            if (this is null)
                return 0;

            int hashId = String.IsNullOrWhiteSpace(this.Id) ? 0 : this.Id.GetHashCode();

            return hashId;
        }
    }
}
