using System.Diagnostics.Metrics;
using System.Numerics;

namespace Ksnm.Units.SI
{
    /// <summary>
    /// メートル
    /// <para>記号:m</para>
    /// <para>系  :国際単位系(SI)</para>
    /// <para>種類:基本単位</para>
    /// <para>次元:長さ</para>
    /// </summary>
    public class Metre<TNumber> :
        Quantity<TNumber, Metre<TNumber>>,
        ILength<TNumber, Metre<TNumber>>
        where TNumber : INumber<TNumber>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "metre";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "m";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol => Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Metre() : base()
        {
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Metre(TNumber value) : base(value)
        {
        }
        #endregion コンストラクタ

        #region 演算子
        /// <summary>
        /// 乗算
        /// </summary>
        public static Metre<TNumber> operator *(Metre<TNumber> quantity, TNumber value)
        {
            return new Metre<TNumber>(quantity.Value * value);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        public static Metre<TNumber> operator *(TNumber value, Metre<TNumber> quantity)
        {
            return new Metre<TNumber>(value * quantity.Value);
        }
        #endregion 演算子

        #region 型変換
        /// <summary>
        /// 数値型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator TNumber(Metre<TNumber> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// 数値型からの暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Metre<TNumber>(TNumber value)
        {
            return new Metre<TNumber>(value);
        }
        #endregion 型変換

    }
}
