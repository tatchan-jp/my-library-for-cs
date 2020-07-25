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

        #region 座標
        #region 点 (2D)
        /// <summary>
        /// 点座標クラス（Int）
        /// </summary>
        public class IntPoint2D
        {
            /// <summary>
            /// X
            /// </summary>
            public int X { get; set; }
            /// <summary>
            /// Y
            /// </summary>
            public int Y { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public IntPoint2D()
            {
                X = 0;
                Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="x">X</param>
            /// <param name="y">Y</param>
            public IntPoint2D(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        /// <summary>
        /// 点座標クラス（UInt）
        /// </summary>
        public class UIntPoint2D
        {
            /// <summary>
            /// X
            /// </summary>
            public uint X { get; set; }
            /// <summary>
            /// Y
            /// </summary>
            public uint Y { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public UIntPoint2D()
            {
                X = 0;
                Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="x">X</param>
            /// <param name="y">Y</param>
            public UIntPoint2D(uint x, uint y)
            {
                X = x;
                Y = y;
            }
        }

        /// <summary>
        /// 点座標クラス（Float）
        /// </summary>
        public class FloatPoint2D
        {
            /// <summary>
            /// X
            /// </summary>
            public float X { get; set; }
            /// <summary>
            /// Y
            /// </summary>
            public float Y { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public FloatPoint2D()
            {
                X = 0;
                Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="x">X</param>
            /// <param name="y">Y</param>
            public FloatPoint2D(float x, float y)
            {
                X = x;
                Y = y;
            }
        }

        /// <summary>
        /// 点座標クラス（Double）
        /// </summary>
        public class DoublePoint2D
        {
            /// <summary>
            /// X
            /// </summary>
            public double X { get; set; }
            /// <summary>
            /// Y
            /// </summary>
            public double Y { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public DoublePoint2D()
            {
                X = 0;
                Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="x">X</param>
            /// <param name="y">Y</param>
            public DoublePoint2D(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        #endregion 点 (2D)

        #region 点 (3D)
        /// <summary>
        /// 点座標クラス（Int）
        /// </summary>
        public class IntPoint3D
        {
            /// <summary>
            /// X
            /// </summary>
            public int X { get; set; }
            /// <summary>
            /// Y
            /// </summary>
            public int Y { get; set; }
            /// <summary>
            /// Z
            /// </summary>
            public int Z { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public IntPoint3D()
            {
                X = 0;
                Y = 0;
                Z = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="x">X</param>
            /// <param name="y">Y</param>
            /// <param name="z">Z</param>
            public IntPoint3D(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

        /// <summary>
        /// 点座標クラス（UInt）
        /// </summary>
        public class UIntPoint3D
        {
            /// <summary>
            /// X
            /// </summary>
            public uint X { get; set; }
            /// <summary>
            /// Y
            /// </summary>
            public uint Y { get; set; }
            /// <summary>
            /// Z
            /// </summary>
            public uint Z { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public UIntPoint3D()
            {
                X = 0;
                Y = 0;
                Z = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="x">X</param>
            /// <param name="y">Y</param>
            /// <param name="z">Z</param>
            public UIntPoint3D(uint x, uint y, uint z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }

        /// <summary>
        /// 点座標クラス（Float）
        /// </summary>
        public class FloatPoint3D
        {
            /// <summary>
            /// X
            /// </summary>
            public float X { get; set; }
            /// <summary>
            /// Y
            /// </summary>
            public float Y { get; set; }
            /// <summary>
            /// Z
            /// </summary>
            public float Z { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public FloatPoint3D()
            {
                X = 0;
                Y = 0;
                Z = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="x">X</param>
            /// <param name="y">Y</param>
            /// <param name="z">Z</param>
            public FloatPoint3D(float x, float y, float z)
            {
                X = x;
                Y = y;
                Z = Z;
            }
        }

        /// <summary>
        /// 点座標クラス（Double）
        /// </summary>
        public class DoublePoint3D
        {
            /// <summary>
            /// X
            /// </summary>
            public double X { get; set; }
            /// <summary>
            /// Y
            /// </summary>
            public double Y { get; set; }
            /// <summary>
            /// Z
            /// </summary>
            public double Z { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public DoublePoint3D()
            {
                X = 0;
                Y = 0;
                Z = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="x">X</param>
            /// <param name="y">Y</param>
            /// <param name="z">Z</param>
            public DoublePoint3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        }
        #endregion 点 (3D)

        #region 線
        /// <summary>
        /// 線座標クラス（Int）
        /// </summary>
        public class IntLine
        {
            /// <summary>
            /// A
            /// </summary>
            public IntPoint2D A { get; set; }
            /// <summary>
            /// B
            /// </summary>
            public IntPoint2D B { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public IntLine()
            {
                Initialize();
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="a">A</param>
            /// <param name="b">B</param>
            public IntLine(IntPoint2D a, IntPoint2D b)
            {
                Initialize();
                A.X = a.X;
                A.Y = a.Y;
                B.X = b.X;
                B.Y = b.Y;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="aX">AのX</param>
            /// <param name="aY">AのY</param>
            /// <param name="bX">BのX</param>
            /// <param name="bY">BのY</param>
            public IntLine(int aX, int aY, int bX, int bY)
            {
                Initialize();
                A.X = aX;
                A.Y = aY;
                B.X = bX;
                B.Y = bY;
            }
            /// <summary>
            /// 初期化
            /// </summary>
            private void Initialize()
            {
                A = new IntPoint2D();
                B = new IntPoint2D();
            }
        }

        /// <summary>
        /// 線座標クラス（UInt）
        /// </summary>
        public class UIntLine
        {
            /// <summary>
            /// A
            /// </summary>
            public UIntPoint2D A { get; set; }
            /// <summary>
            /// B
            /// </summary>
            public UIntPoint2D B { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public UIntLine()
            {
                Initialize();
                A.X = 0;
                A.Y = 0;
                B.X = 0;
                B.Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="a">A</param>
            /// <param name="b">B</param>
            public UIntLine(UIntPoint2D a, UIntPoint2D b)
            {
                Initialize();
                A.X = a.X;
                A.Y = a.Y;
                B.X = b.X;
                B.Y = b.Y;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="aX">AのX</param>
            /// <param name="aY">AのY</param>
            /// <param name="bX">BのX</param>
            /// <param name="bY">BのY</param>
            public UIntLine(uint aX, uint aY, uint bX, uint bY)
            {
                Initialize();
                A.X = aX;
                A.Y = aY;
                B.X = bX;
                B.Y = bY;
            }
            /// <summary>
            /// 初期化
            /// </summary>
            private void Initialize()
            {
                A = new UIntPoint2D();
                B = new UIntPoint2D();
            }
        }

        /// <summary>
        /// 線座標クラス（Float）
        /// </summary>
        public class FloatLine
        {
            /// <summary>
            /// A
            /// </summary>
            public FloatPoint2D A { get; set; }
            /// <summary>
            /// B
            /// </summary>
            public FloatPoint2D B { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public FloatLine()
            {
                Initialize();
                A.X = 0;
                A.Y = 0;
                B.X = 0;
                B.Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="a">A</param>
            /// <param name="b">B</param>
            public FloatLine(FloatPoint2D a, FloatPoint2D b)
            {
                Initialize();
                A.X = a.X;
                A.Y = a.Y;
                B.X = b.X;
                B.Y = b.Y;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="aX">AのX</param>
            /// <param name="aY">AのY</param>
            /// <param name="bX">BのX</param>
            /// <param name="bY">BのY</param>
            public FloatLine(float aX, float aY, float bX, float bY)
            {
                Initialize();
                A.X = aX;
                A.Y = aY;
                B.X = bX;
                B.Y = bY;
            }
            /// <summary>
            /// 初期化
            /// </summary>
            private void Initialize()
            {
                A = new FloatPoint2D();
                B = new FloatPoint2D();
            }
        }

        /// <summary>
        /// 線座標クラス（Double）
        /// </summary>
        public class DoubleLine
        {
            /// <summary>
            /// A
            /// </summary>
            public DoublePoint2D A { get; set; }
            /// <summary>
            /// B
            /// </summary>
            public DoublePoint2D B { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public DoubleLine()
            {
                Initialize();
                A.X = 0;
                A.Y = 0;
                B.X = 0;
                B.Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="a">A</param>
            /// <param name="b">B</param>
            public DoubleLine(DoublePoint2D a, DoublePoint2D b)
            {
                Initialize();
                A.X = a.X;
                A.Y = a.Y;
                B.X = b.X;
                B.Y = b.Y;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="aX">AのX</param>
            /// <param name="aY">AのY</param>
            /// <param name="bX">BのX</param>
            /// <param name="bY">BのY</param>
            public DoubleLine(double aX, double aY, double bX, double bY)
            {
                Initialize();
                A.X = aX;
                A.Y = aY;
                B.X = bX;
                B.Y = bY;
            }
            /// <summary>
            /// 初期化
            /// </summary>
            private void Initialize()
            {
                A = new DoublePoint2D();
                B = new DoublePoint2D();
            }
        }
        #endregion 線

        #region 矩形
        /// <summary>
        /// 矩形座標クラス（Int）
        /// </summary>
        public class IntRectangle
        {
            /// <summary>
            /// A
            /// </summary>
            public IntPoint2D A { get; set; }
            /// <summary>
            /// B
            /// </summary>
            public IntPoint2D B { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public IntRectangle()
            {
                Initialize();
                A.X = 0;
                A.Y = 0;
                B.X = 0;
                B.Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="a">A</param>
            /// <param name="b">B</param>
            public IntRectangle(IntPoint2D a, IntPoint2D b)
            {
                Initialize();
                A.X = a.X;
                A.Y = a.Y;
                B.X = b.X;
                B.Y = b.Y;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="aX">AのX</param>
            /// <param name="aY">AのY</param>
            /// <param name="bX">BのX</param>
            /// <param name="bY">BのY</param>
            public IntRectangle(int aX, int aY, int bX, int bY)
            {
                Initialize();
                A.X = aX;
                A.Y = aY;
                B.X = bX;
                B.Y = bY;
            }
            /// <summary>
            /// 初期化
            /// </summary>
            private void Initialize()
            {
                A = new IntPoint2D();
                B = new IntPoint2D();
            }
        }

        /// <summary>
        /// 矩形座標クラス（UInt）
        /// </summary>
        public class UIntRectangle
        {
            /// <summary>
            /// A
            /// </summary>
            public UIntPoint2D A { get; set; }
            /// <summary>
            /// B
            /// </summary>
            public UIntPoint2D B { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public UIntRectangle()
            {
                Initialize();
                A.X = 0;
                A.Y = 0;
                B.X = 0;
                B.Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="a">A</param>
            /// <param name="b">B</param>
            public UIntRectangle(UIntPoint2D a, UIntPoint2D b)
            {
                Initialize();
                A.X = a.X;
                A.Y = a.Y;
                B.X = b.X;
                B.Y = b.Y;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="aX">AのX</param>
            /// <param name="aY">AのY</param>
            /// <param name="bX">BのX</param>
            /// <param name="bY">BのY</param>
            public UIntRectangle(uint aX, uint aY, uint bX, uint bY)
            {
                Initialize();
                A.X = aX;
                A.Y = aY;
                B.X = bX;
                B.Y = bY;
            }
            /// <summary>
            /// 初期化
            /// </summary>
            private void Initialize()
            {
                A = new UIntPoint2D();
                B = new UIntPoint2D();
            }
        }

        /// <summary>
        /// 矩形座標クラス（Float）
        /// </summary>
        public class FloatRectangle
        {
            /// <summary>
            /// A
            /// </summary>
            public FloatPoint2D A { get; set; }
            /// <summary>
            /// B
            /// </summary>
            public FloatPoint2D B { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public FloatRectangle()
            {
                Initialize();
                A.X = 0;
                A.Y = 0;
                B.X = 0;
                B.Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="a">A</param>
            /// <param name="b">B</param>
            public FloatRectangle(FloatPoint2D a, FloatPoint2D b)
            {
                Initialize();
                A.X = a.X;
                A.Y = a.Y;
                B.X = b.X;
                B.Y = b.Y;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="aX">AのX</param>
            /// <param name="aY">AのY</param>
            /// <param name="bX">BのX</param>
            /// <param name="bY">BのY</param>
            public FloatRectangle(float aX, float aY, float bX, float bY)
            {
                Initialize();
                A.X = aX;
                A.Y = aY;
                B.X = bX;
                B.Y = bY;
            }
            /// <summary>
            /// 初期化
            /// </summary>
            private void Initialize()
            {
                A = new FloatPoint2D();
                B = new FloatPoint2D();
            }
        }

        /// <summary>
        /// 矩形座標クラス（Double）
        /// </summary>
        public class DoubleRectangle
        {
            /// <summary>
            /// A
            /// </summary>
            public DoublePoint2D A { get; set; }
            /// <summary>
            /// B
            /// </summary>
            public DoublePoint2D B { get; set; }
            /// <summary>
            /// コンストラクター
            /// </summary>
            public DoubleRectangle()
            {
                Initialize();
                A.X = 0;
                A.Y = 0;
                B.X = 0;
                B.Y = 0;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="a">A</param>
            /// <param name="b">B</param>
            public DoubleRectangle(DoublePoint2D a, DoublePoint2D b)
            {
                Initialize();
                A.X = a.X;
                A.Y = a.Y;
                B.X = b.X;
                B.Y = b.Y;
            }
            /// <summary>
            /// コンストラクター
            /// </summary>
            /// <param name="aX">AのX</param>
            /// <param name="aY">AのY</param>
            /// <param name="bX">BのX</param>
            /// <param name="bY">BのY</param>
            public DoubleRectangle(double aX, double aY, double bX, double bY)
            {
                Initialize();
                A.X = aX;
                A.Y = aY;
                B.X = bX;
                B.Y = bY;
            }
            /// <summary>
            /// 初期化
            /// </summary>
            private void Initialize()
            {
                A = new DoublePoint2D();
                B = new DoublePoint2D();
            }
        }
        #endregion 矩形
        #endregion 座標
    }
}
