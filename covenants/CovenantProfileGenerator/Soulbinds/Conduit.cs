using System;

namespace CovenantProfileGenerator.Soulbinds
{
    public class Conduit
    {
        public string Id { get; internal set; }
        public string Name { get; internal set; }
        public string Code { get; internal set; }
        public SoulbindAbilityType Type { get; internal set; }
        public string SpellId { get; internal set; }
        public int Rank { get; internal set; }
        public string Class { get; internal set; }
        public string Spec { get; internal set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Conduit sb))
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

        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}
