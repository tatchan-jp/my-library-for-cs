using System;
using System.Collections.Generic;
using System.Linq;

namespace my_library_for_cs
{
    namespace Data
    {
        /// <summary>
        /// Dictionary拡張クラス
        /// </summary>
        public static class DictionaryExtensions
        {
            /// <summary>
            /// Dictionaryのkeyとvalueを文字列にして結合する
            /// </summary>
            /// <typeparam name="TKey"></typeparam>
            /// <typeparam name="TValue"></typeparam>
            /// <param name="source"></param>
            /// <param name="join"></param>
            /// <returns>文字列リスト</returns>
            public static List<string> ToJoin<TKey, TValue>(this IDictionary<TKey, TValue> source, string join)
            {
                return source.Select(kvp => kvp.Key.ToString() + join + kvp.Value.ToString()).ToList();
            }

            /// <summary>
            /// Dictionaryのkeyとvalueを文字列にして結合する
            /// </summary>
            /// <typeparam name="TKey"></typeparam>
            /// <typeparam name="TValue"></typeparam>
            /// <param name="source"></param>
            /// <param name="separator"></param>
            /// <param name="join"></param>
            /// <returns>文字列（リストをseparatorで区切って繋ぐ）</returns>
            public static string ToJoin<TKey, TValue>(this IDictionary<TKey, TValue> source, string separator, string join)
            {
                return string.Join(separator, ToJoin(source, join));
            }

            /// <summary>
            /// Dictionaryを並び替える（Keyでソート）
            /// </summary>
            /// <typeparam name="TKey"></typeparam>
            /// <typeparam name="TValue"></typeparam>
            /// <param name="dictionary"></param>
            /// <param name="doAscending"></param>
            /// <returns>正常:リスト, 異常:null</returns>
            public static List<KeyValuePair<TKey, TValue>> ToListByKey<TKey, TValue>(Dictionary<TKey, TValue> dictionary, bool doAscending = true)
            {
                try
                {
                    if (null == dictionary)
                    {
                        throw new Exception("dictionary is null.");
                    }
                    var list = new List<KeyValuePair<TKey, TValue>>(dictionary);
                    if (doAscending == true)
                    {
                        return list.OrderBy(x => x.Key).ToList();
                    }
                    else
                    {
                        return list.OrderByDescending(x => x.Key).ToList();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("[ERROR] {0}", e);
                    return null;
                }
            }

            /// <summary>
            /// Dictionaryを並び替える（Valueでソート）
            /// </summary>
            /// <typeparam name="TKey"></typeparam>
            /// <typeparam name="TValue"></typeparam>
            /// <param name="dictionary"></param>
            /// <param name="doAscending"></param>
            /// <returns>正常:リスト, 異常:null</returns>
            public static List<KeyValuePair<TKey, TValue>> ToListByValue<TKey, TValue>(Dictionary<TKey, TValue> dictionary, bool doAscending = true)
            {
                try
                {
                    if (null == dictionary)
                    {
                        throw new Exception("dictionary is null.");
                    }
                    var list = new List<KeyValuePair<TKey, TValue>>(dictionary);
                    if (doAscending == true)
                    {
                        return list.OrderBy(x => x.Value).ToList();
                    }
                    else
                    {
                        return list.OrderByDescending(x => x.Value).ToList();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("[ERROR] {0}", e);
                    return null;
                }
            }
        }
    }
}
