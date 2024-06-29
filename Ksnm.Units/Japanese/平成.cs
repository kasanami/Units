using System.Numerics;

namespace Ksnm.Units.Japanese
{
    public class 平成<TNumber> :
        Quantity<TNumber, 平成<TNumber>>,
        ITime<TNumber, 平成<TNumber>>
        where TNumber : INumber<TNumber>
    {
        #region プロパティ
        /// <summary>
        /// 名前
        /// </summary>
        public static string Name => "平成";
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
        public 平成() : base()
        {
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public 平成(TNumber value) : base(value)
        {
        }
        #endregion コンストラクタ

        #region 型変換
        /// <summary>
        /// 暗黙的な変換
        /// </summary>
        public static implicit operator 平成<TNumber>(TNumber value)
        {
            return new 平成<TNumber>(value);
        }
        /// <summary>
        /// 明示的な変換
        /// </summary>
        public static explicit operator 平成<TNumber>(令和<TNumber> reiwa)
        {
            return new 平成<TNumber>(reiwa.Value + TNumber.CreateChecked(30));
        }
        #endregion 型変換
    }
}
