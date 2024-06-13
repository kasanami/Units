using System.Numerics;

namespace Ksnm.Units.Japanese
{
    public class 令和<TNumber> :
        Quantity<TNumber, 令和<TNumber>>,
        ITime<TNumber, 令和<TNumber>>
        where TNumber : INumber<TNumber>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "令和";
        /// <summary>
        /// 記号
        /// </summary>
        public static string Symbol => "年";
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public override string _Symbol => Symbol;
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public 令和() : base()
        {
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public 令和(TNumber value) : base(value)
        {
        }
        #endregion コンストラクタ

        #region 型変換
        public static implicit operator 令和<TNumber>(TNumber value)
        {
            return new 令和<TNumber>(value);
        }
        /// <summary>
        /// 明示的な変換を定義します。
        /// </summary>
        public static explicit operator 令和<TNumber>(平成<TNumber> heisei)
        {
            return new 令和<TNumber>(heisei.Value - TNumber.CreateChecked(30));
        }
        #endregion 型変換
    }
}
