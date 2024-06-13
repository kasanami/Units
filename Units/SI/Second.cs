using System.Numerics;

namespace Ksnm.Units.SI
{
    /// <summary>
    /// 秒
    /// <para>記号:s</para>
    /// <para>系  :国際単位系(SI)</para>
    /// <para>種類:基本単位</para>
    /// <para>次元:時間</para>
    /// </summary>
    public class Second<TNumber> :
        Quantity<TNumber, Second<TNumber>>,
        ITime<TNumber, Second<TNumber>>
        where TNumber : INumber<TNumber>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "second";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "s";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol => Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Second() : base()
        {
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Second(TNumber value) : base(value)
        {
        }
        #endregion コンストラクタ

        #endregion プロパティ
        #region 演算子
        /// <summary>
        /// 乗算
        /// </summary>
        public static Second<TNumber> operator *(TNumber value, Second<TNumber> quantity)
        {
            return new Second<TNumber>(quantity.Value * value);
        }
        #endregion 演算子
        #region 型変換
        ///// <summary>
        ///// 他の型から、この型への暗黙的な変換を定義します。
        ///// </summary>
        //public static implicit operator Second<T>(Minute<T> time)
        //{
        //    return new Second<T>(time);
        //}
        ///// <summary>
        ///// 他の型から、この型への暗黙的な変換を定義します。
        ///// </summary>
        //public static implicit operator Second<T>(Hour<T> time)
        //{
        //    return new Second<T>(time);
        //}
        /// <summary>
        /// 数値型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator TNumber(Second<TNumber> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// 数値型への暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Second<TNumber>(TNumber value)
        {
            return new Second<TNumber>(value);
        }
        #endregion 型変換
        /// <summary>
        /// 数値型からQuantityへ変換
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public new static Second<TNumber> From(TNumber value)
        {
            return new Second<TNumber>(value);
        }
    }
}
