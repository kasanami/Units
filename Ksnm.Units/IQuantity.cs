using System.Numerics;

namespace Ksnm.Units
{
    /// <summary>
    /// 何らかの量
    /// </summary>
    /// <typeparam name="TNumber">数値型</typeparam>
    /// <typeparam name="TSelf">派生先自身の型</typeparam>
    public interface IQuantity<TNumber, TSelf>
        where TNumber : INumber<TNumber>
        where TSelf : Quantity<TNumber, TSelf>,new()
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
        /// 数値型からTSelfへ変換
        /// </summary>
        static abstract TSelf From(TNumber value);
    }
}
