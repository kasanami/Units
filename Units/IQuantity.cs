using System.Numerics;

namespace Ksnm.Units
{
    /// <summary>
    /// 何らかの量
    /// </summary>
    /// <typeparam name="TNumber">数値型</typeparam>
    public interface IQuantity<TNumber> where TNumber : INumber<TNumber>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        static string Name { get; }
        /// <summary>
        /// 記号
        /// </summary>
        static string Symbol { get; }
        /// <summary>
        /// 量の種類
        /// </summary>
        static QuantityType Type { get; }
        /// <summary>
        /// 値
        /// </summary>
        TNumber Value { get; set; }
        #endregion プロパティ
        /// <summary>
        /// 数値型からQuantityへ変換
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static virtual IQuantity<TNumber> From(TNumber value) { return new Quantity<TNumber>(value); }
    }
}
