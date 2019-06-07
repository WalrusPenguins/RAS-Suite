using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASSystem.Extensions
{
    public static class LINQExt
    {
        public static bool ContainsOther<T>(this IEnumerable<T> original, IEnumerable<T> permittedSet)
        {
            var distinctElements = original.Distinct();
            foreach (var distinctElement in distinctElements)
            {
                if (!permittedSet.Contains(distinctElement))
                    return true;
            }
            return false;
        }
    }
}
