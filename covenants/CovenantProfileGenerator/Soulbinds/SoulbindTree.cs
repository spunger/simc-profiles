using System.Collections.Generic;

namespace CovenantProfileGenerator.Soulbinds
{
    public class SoulbindTree: List<SoulbindEdge>
    {
        public SoulbindTree() : base() { }
        public SoulbindTree(IEnumerable<SoulbindEdge> tree) : base(tree) { }
    }
}
