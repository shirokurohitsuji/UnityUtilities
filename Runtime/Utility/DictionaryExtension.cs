using System.Collections.Generic;

namespace Utility
{
    public static class DictionaryExtension
    {
        public static TV GetValueIfExists<TK, TV>(this IDictionary<TK, TV> map, TK key, TV defaultValue)
        {
            return map.ContainsKey(key)
                ? map[key]
                : defaultValue;
        }
        public static TV GetValueIfExists<TK, TV>(this IDictionary<TK, TV> map, TK key)
        {
            return map.ContainsKey(key)
                ? map[key]
                : default;
        }
    }
}
