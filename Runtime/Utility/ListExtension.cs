using System;
using System.Collections.Generic;

namespace Utility
{
    public static class ListExtension
    {
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
    }
}
