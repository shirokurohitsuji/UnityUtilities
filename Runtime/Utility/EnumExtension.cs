using System;
using System.Collections.Generic;
using System.Linq;

namespace Utility
{
    public static class EnumExtension
    {
        private static readonly Random R = new();

        public static TEnum Random<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .OrderBy(_ => R.Next())
                .FirstOrDefault();
        }

        public static int GetLength<TEnum>()
        {
            return Enum.GetValues(typeof(TEnum)).Length;
        }

        public static IEnumerable<TEnum> Values<TEnum>()
            where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            var enumType = typeof(TEnum);

            if (!enumType.IsEnum) throw new ArgumentException();

            return Enum.GetValues(enumType).Cast<TEnum>();
        }

        public static TEnum Parse<TEnum>(this string s, bool ignoreCase = false) where TEnum : struct
        {
            return (TEnum) Enum.Parse(typeof(TEnum), s, ignoreCase);
        }

        public static bool TryParse<TEnum>(this string s, out TEnum wd) where TEnum : struct
        {
            return Enum.TryParse(s, out wd) && Enum.IsDefined(typeof(TEnum), wd);
        }
    }
}
