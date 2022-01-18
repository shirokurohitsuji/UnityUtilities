#if PACKAGE_NEWTONSOFT_JSON && PACKAGE_NEUECC_UNIRX
using System;
using Newtonsoft.Json;
using UniRx;
using UnityEngine;

namespace Utility
{
    public static class ObservableExtension
    {
        public static IObservable<TSource> DebugLog<TSource>(this IObservable<TSource> source)
        {
            return source.Select(value =>
            {
                Debug.Log(JsonConvert.SerializeObject(value));
                return value;
            });
        }

        public static IObservable<TSource> DebugLog<TSource>(this IObservable<TSource> source, string prefix)
        {
            return source.Select(value =>
            {
                Debug.Log($"{prefix}: {JsonConvert.SerializeObject(value)}");
                return value;
            });
        }
    }
}
#endif // PACKAGE_NEWTONSOFT_JSON && PACKAGE_NEUECC_UNIRX
