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

        public static T RandomWeightedElementAt<T>(this IEnumerable<T> ie, Func<T, float> weightSelector)
        {
            var enumerable = ie as T[] ?? ie.ToArray();
            var index = enumerable
                .Select(weightSelector.Invoke)
                .WeightedIndex(UnityEngine.Random.Range(0f, 1f));
            return index >= 0 ? enumerable.ElementAt(index) : default;
        }

        private static int WeightedIndex(this IEnumerable<float> source, float value)
        {
            var weights = source.ToArray();

            var total = weights.Sum(x => x);
            if (total <= 0f) return -1;

            var i = 0;
            var w = 0f;
            foreach (var weight in weights)
            {
                w += weight / total;
                if (value <= w) return i;
                i++;
            }

            return -1;
        }

        public static int MinOrMinusOne(this IEnumerable<int> sequence)
        {
            var array = sequence.ToArray();
            if (array.Any()) return array.Min();
            return -1;
        }
    }
}
