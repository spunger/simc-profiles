using System.Collections.Generic;
using System.Linq;

namespace CovenantProfileGenerator.Soulbinds
{
    internal static class Extension
    {
        internal static IEnumerable<IEnumerable<T>> DifferentCombinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? Enumerable.Repeat(Enumerable.Empty<T>(), 1) :
                elements.SelectMany((e, i) =>
                    elements.Skip(i + 1).DifferentCombinations(k - 1).Select(c => Enumerable.Repeat(e, 1).Concat(c)));
        }
    }
}
