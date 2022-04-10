using System;
using System.Collections.Generic;

namespace Utility
{
    public static class ListExtension
    {
        private static readonly Random Random = new();

        public static T LoopElementAt<T>(this IList<T> list, int index)
        {
            if (list.Count == 0) throw new ArgumentException();

            index %= list.Count;
            if (index < 0) index += list.Count;

            var target = list[index];

            return target;
        }

        public static T LoopElementAtIfAny<T>(this IList<T> list, int index)
        {
            return list.Count == 0
                ? default
                : LoopElementAt(list, index);
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = Random.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }
    }
}
