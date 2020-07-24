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

        /// <summary>
        /// 列挙型拡張クラス
        /// </summary>
        public static class EnumExtensions
        {
            /// <summary>
            /// 文字列をTEnum型の列挙型に変換する
            /// </summary>
            /// <typeparam name="TEnum">列挙型</typeparam>
            /// <param name="value">列挙定数の文字列</param>
            /// <returns>列挙定数</returns>
            public static TEnum String2Enum<TEnum>(string value)
            {
                return (TEnum)Enum.Parse(typeof(TEnum), value);
            }

            /// <summary>
            /// 整数をTEnum型の列挙型に変換する
            /// </summary>
            /// <typeparam name="TEnum">列挙型</typeparam>
            /// <param name="value">列挙定数の整数</param>
            /// <returns>列挙定数</returns>
            public static TEnum Int2Enum<TEnum>(int value)
            {
                return (TEnum)Enum.ToObject(typeof(TEnum), value);
            }
        }

        /// <summary>
        /// 数値拡張クラス
        /// </summary>
        public static class NumericalValueExtensions
        {
            /// <summary>
            /// T型の整数をBCDに変換する※符号つき変数用
            /// </summary>
            /// <typeparam name="T">型</typeparam>
            /// <param name="num">整数</param>
            /// <param name="byteCount">バイト数</param>
            /// <returns></returns>
            private static byte[] Any2BCD<T>(T num, int byteCount) where T : struct, IConvertible
            {
                long value = Convert.ToInt64(num);
                byte[] bcd = new byte[byteCount];
                for (int i = 1; i <= byteCount; i++)
                {
                    long mod = value % 100;
                    long digit2 = mod % 10;
                    long digit1 = (mod - digit2) / 10;
                    bcd[byteCount - i] = Convert.ToByte((digit1 * 16) + digit2);
                    value = (value - mod) / 100;
                }
                return bcd;
            }

            /// <summary>
            /// T型の整数をBCDに変換する※符号なし変数用
            /// </summary>
            /// <typeparam name="T">型</typeparam>
            /// <param name="num">整数</param>
            /// <param name="byteCount">バイト数</param>
            /// <returns></returns>
            private static byte[] UAny2BCD<T>(T num, int byteCount) where T : struct, IConvertible
            {
                ulong value = Convert.ToUInt64(num);
                byte[] bcd = new byte[byteCount];
                for (int i = 1; i <= byteCount; i++)
                {
                    ulong mod = value % 100;
                    ulong digit2 = mod % 10;
                    ulong digit1 = (mod - digit2) / 10;
                    bcd[byteCount - i] = Convert.ToByte((digit1 * 16) + digit2);
                    value = (value - mod) / 100;
                }
                return bcd;
            }

            #region Int <-> BCD
            /// <summary>
            /// BCDをInt型の整数に変換する
            /// </summary>
            /// <param name="bcd">BCD</param>
            /// <returns></returns>
            public static int BCD2Int(byte[] bcd)
            {
                return Convert.ToInt32(BCD2Long(bcd));
            }

            /// <summary>
            /// Int型の整数をBCDに変換する
            /// </summary>
            /// <param name="num">整数</param>
            /// <param name="byteCount">バイト数</param>
            /// <returns></returns>
            public static byte[] Int2BCD(int num, int byteCount)
            {
                return Any2BCD<int>(num, byteCount);
            }
            #endregion Int <-> BCD

            #region UInt <-> BCD
            /// <summary>
            /// BCDをUInt型の整数に変換する
            /// </summary>
            /// <param name="bcd">BCD</param>
            /// <returns></returns>
            public static uint BCD2UInt(byte[] bcd)
            {
                return Convert.ToUInt32(BCD2ULong(bcd));
            }

            /// <summary>
            /// UInt型の整数をBCDに変換する
            /// </summary>
            /// <param name="num">整数</param>
            /// <param name="byteCount">バイト数</param>
            /// <returns></returns>
            public static byte[] UInt2BCD(uint num, int byteCount)
            {
                return UAny2BCD<uint>(num, byteCount);
            }
            #endregion UInt <-> BCD

            #region Long <-> BCD
            /// <summary>
            /// BCDをLong型の整数に変換する
            /// </summary>
            /// <param name="bcd">BCD</param>
            /// <returns></returns>
            public static long BCD2Long(byte[] bcd)
            {
                long result = 0;
                foreach (byte b in bcd)
                {
                    int digit1 = b >> 4;
                    int digit2 = b & 0x0f;
                    result = (result * 100) + (digit1 * 10) + digit2;
                }
                return result;
            }

            /// <summary>
            /// Long型の整数をBCDに変換する
            /// </summary>
            /// <param name="num">整数</param>
            /// <param name="byteCount">バイト数</param>
            /// <returns></returns>
            public static byte[] Long2BCD(long num, int byteCount)
            {
                return Any2BCD<long>(num, byteCount);
            }
            #endregion Long <-> BCD

            #region ULong <-> BCD
            /// <summary>
            /// BCDをULong型の整数に変換する
            /// </summary>
            /// <param name="bcd">BCD</param>
            /// <returns></returns>
            public static ulong BCD2ULong(byte[] bcd)
            {
                ulong result = 0;
                foreach (byte b in bcd)
                {
                    uint digit1 = (uint)b >> 4;
                    uint digit2 = (uint)b & 0x0f;
                    result = (result * 100) + (digit1 * 10) + digit2;
                }
                return result;
            }

            /// <summary>
            /// ULong型の整数をBCDに変換する
            /// </summary>
            /// <param name="num">整数</param>
            /// <param name="byteCount">バイト数</param>
            /// <returns></returns>
            public static byte[] ULong2BCD(ulong num, int byteCount)
            {
                return UAny2BCD<ulong>(num, byteCount);
            }
            #endregion ULong <-> BCD
        }
    }
}
