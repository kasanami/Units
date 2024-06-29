using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ksnm.Units.NonSI
{
    /// <summary>
    /// ユリウス年
    /// <para>記号:a, aJ, Jy</para>
    /// <para>系  :非SI単位</para>
    /// <para>種類:基本単位</para>
    /// <para>次元:時間</para>
    /// <para>SI  :正確に31557600s</para>
    /// <para>定義:365.25 日</para>
    /// <para>由来:ユリウス暦の平均暦年</para>
    /// </summary>
    public class JulianYear<TNumber> :
        Quantity<TNumber, JulianYear<TNumber>>,
        ITime<TNumber, JulianYear<TNumber>>
        where TNumber : INumber<TNumber>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "Julian year";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "Jy";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol => Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public JulianYear() : base()
        {
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public JulianYear(TNumber value) : base(value)
        {
        }
        #endregion コンストラクタ

        #region 演算子
        /// <summary>
        /// 乗算
        /// </summary>
        public static JulianYear<TNumber> operator *(JulianYear<TNumber> quantity, TNumber value)
        {
            return new JulianYear<TNumber>(quantity.Value * value);
        }
        /// <summary>
        /// 乗算
        /// </summary>
        public static JulianYear<TNumber> operator *(TNumber value, JulianYear<TNumber> quantity)
        {
            return new JulianYear<TNumber>(value * quantity.Value);
        }
        #endregion 演算子

        #region 型変換
        /// <summary>
        /// 数値型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator TNumber(JulianYear<TNumber> quantity)
        {
            return quantity.Value;
        }
        /// <summary>
        /// 数値型からの暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator JulianYear<TNumber>(TNumber value)
        {
            return new JulianYear<TNumber>(value);
        }
        #endregion 型変換
        /// <summary>
        /// 数値型からQuantityへ変換
        /// </summary>
        public new static JulianYear<TNumber> From(TNumber value)
        {
            return new JulianYear<TNumber>(value);
        }
    }
}
