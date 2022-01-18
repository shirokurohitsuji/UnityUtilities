#if PACKAGE_NEWTONSOFT_JSON
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using UnityEngine;

namespace Utility
{
    [SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
    public static class LinqExtension
    {
        public static IEnumerable<TSource> Do<TSource>(this IEnumerable<TSource> source, Action<TSource> onNext)
        {
            foreach (var item in source) onNext.Invoke(item);
            return source;
        }

        public static IEnumerable<TSource> DebugLog<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source) Debug.Log(JsonConvert.SerializeObject(item));
            return source;
        }

        public static IEnumerable<TSource> DebugLog<TSource>(this IEnumerable<TSource> source, string prefix)
        {
            foreach (var item in source) Debug.Log($"{prefix}: {JsonConvert.SerializeObject(item)}");
            return source;
        }
    }
}
#endif // PACKAGE_NEWTONSOFT_JSON
