using System;
using System.Collections.Generic;
using System.Linq;

namespace Utility
{
    public static class EnumerableExtension
    {
        private static readonly Random Rand = new();

        public static T RandomElementAt<T>(this IEnumerable<T> ie)
        {
            var enumerable = ie as T[] ?? ie.ToArray();
            return enumerable.ElementAt(Rand.Next(enumerable.Length));
        }

        public static IEnumerable<T> RandomElementsAt<T>(this IEnumerable<T> ie, int count)
        {
            var array = ie as T[] ?? ie.ToArray();
            var result = new List<T>();

            var counter = Math.Min(count, array.Length);
            while (counter > 0)
            {
                var x = array.ElementAt(Rand.Next(array.Length));
                if (result.Contains(x)) continue;
                result.Add(x);
                counter--;
            }

            return result;
        }
    }
}
