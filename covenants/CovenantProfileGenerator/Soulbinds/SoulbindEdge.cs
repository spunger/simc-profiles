namespace CovenantProfileGenerator.Soulbinds
{
    public class SoulbindEdge
    {
        public string BeginId { get; }
        public string EndId { get; }
        public SoulbindAbility Begin
            => Data.GetSoulbindAbilityById(BeginId);
        public SoulbindAbility End
            => Data.GetSoulbindAbilityById(EndId);

        public SoulbindEdge(string beginId, string endId)
        {
            BeginId = beginId;
            EndId = endId;
        }

        public override string ToString()
        {
            return $"{Begin.Code}->{End.Code}";
        }
    }
}
