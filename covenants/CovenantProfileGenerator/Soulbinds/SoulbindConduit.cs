namespace CovenantProfileGenerator.Soulbinds
{
    public class SoulbindConduit: SoulbindAbility
    {
        public string SpellId { get; internal set; }
        public int Rank { get; internal set; }
        public string Class { get; internal set; }
        public string Spec { get; internal set; }

        public override string ToString()
            => $"{Code}:{Rank}";
        
        public override string SimcString => $"{Id}:{Rank}";
    }

}
