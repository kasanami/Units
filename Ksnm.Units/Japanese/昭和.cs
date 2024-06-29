using System.Numerics;

namespace Ksnm.Units.Japanese
{
    public class 昭和<TNumber> :
        Quantity<TNumber, 昭和<TNumber>>,
        ITime<TNumber, 昭和<TNumber>>
        where TNumber : INumber<TNumber>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "昭和";
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
        public 昭和() : base()
        {
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public 昭和(TNumber value) : base(value)
        {
        }
        #endregion コンストラクタ

        #region 型変換
        /// <summary>
        /// 暗黙的な変換
        /// </summary>
        public static implicit operator 昭和<TNumber>(TNumber value)
        {
            return new 昭和<TNumber>(value);
        }
        /// <summary>
        /// 明示的な変換
        /// </summary>
        public static explicit operator 昭和<TNumber>(平成<TNumber> heisei)
        {
            return new 昭和<TNumber>(heisei.Value + TNumber.CreateChecked(63));
        }
        /// <summary>
        /// 明示的な変換
        /// </summary>
        public static explicit operator 昭和<TNumber>(令和<TNumber> reiwa)
        {
            return new 昭和<TNumber>(reiwa.Value + TNumber.CreateChecked(93));
        }
        #endregion 型変換
    }
}
