using System;
using System.Collections.Generic;
using System.Text;

namespace my_library_for_cs
{
    namespace Data
    {
        #region カウンター
        /// <summary>
        /// カウンタークラス（int）
        /// </summary>
        public class IntCounter
        {
            /// <summary>
            /// 最小値
            /// </summary>
            public int Min { get; private set; }
            /// <summary>
            /// 最大値
            /// </summary>
            public int Max { get; private set; }
            /// <summary>
            /// 現在値
            /// </summary>
            public int Value { get; private set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public IntCounter(int min, int max)
            {
                if (max < min)
                {
                    int temp = min;
                    min = max;
                    max = temp;
                }
                Min = min;
                Max = max;
                Value = Min;
            }
            /// <summary>
            /// カウントアップ
            /// </summary>
            /// <returns>現在値</returns>
            public int Up()
            {
                if (Min == Max)
                {
                    return Value;
                }
                if (Max < Value + 1)
                {
                    Value = Min;
                }
                else
                {
                    Value++;
                }
                return Value;
            }
            /// <summary>
            /// カウントアップ
            /// </summary>
            /// <returns>現在値</returns>
            public int Up(uint num)
            {
                for (uint i = 0; i < num; i++)
                {
                    Up();
                }
                return Value;
            }
            /// <summary>
            /// カウントダウン
            /// </summary>
            /// <returns>現在値</returns>
            public int Down()
            {
                if (Min == Max)
                {
                    return Value;
                }
                if (Value - 1 < Min)
                {
                    Value = Max;
                }
                else
                {
                    Value--;
                }
                return Value;
            }
            /// <summary>
            /// カウントダウン
            /// </summary>
            /// <returns>現在値</returns>
            public int Down(uint num)
            {
                for (uint i = 0; i < num; i++)
                {
                    Down();
                }
                return Value;
            }
        }

        /// <summary>
        /// カウンタークラス（uint）
        /// </summary>
        public class UIntCounter
        {
            /// <summary>
            /// 最小値
            /// </summary>
            public uint Min { get; private set; }
            /// <summary>
            /// 最大値
            /// </summary>
            public uint Max { get; private set; }
            /// <summary>
            /// 現在値
            /// </summary>
            public uint Value { get; private set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public UIntCounter(uint min, uint max)
            {
                if (max < min)
                {
                    uint temp = min;
                    min = max;
                    max = temp;
                }
                Min = min;
                Max = max;
                Value = Min;
            }
            /// <summary>
            /// カウントアップ
            /// </summary>
            /// <returns>現在値</returns>
            public uint Up()
            {
                if (Min == Max)
                {
                    return Value;
                }
                if (Max < Value + 1)
                {
                    Value = Min;
                }
                else
                {
                    Value++;
                }
                return Value;
            }
            /// <summary>
            /// カウントアップ
            /// </summary>
            /// <returns>現在値</returns>
            public uint Up(uint num)
            {
                for (uint i = 0; i < num; i++)
                {
                    Up();
                }
                return Value;
            }
            /// <summary>
            /// カウントダウン
            /// </summary>
            /// <returns>現在値</returns>
            public uint Down()
            {
                if (Min == Max)
                {
                    return Value;
                }
                if (Value - 1 < Min)
                {
                    Value = Max;
                }
                else
                {
                    Value--;
                }
                return Value;
            }
            /// <summary>
            /// カウントダウン
            /// </summary>
            /// <returns>現在値</returns>
            public uint Down(uint num)
            {
                for (uint i = 0; i < num; i++)
                {
                    Down();
                }
                return Value;
            }
        }
        #endregion カウンター
    }
}
