namespace CovenantProfileGenerator.Soulbinds
{
    public class Covenant
    {
        public string Code { get; internal set; }
        public string Name { get; internal set; }
        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}
