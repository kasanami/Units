using System.Net.Http.Headers;
using System.Numerics;

namespace Ksnm.Units
{
    /// <summary>
    /// 何らかの量を表す
    /// </summary>
    /// <typeparam name="TNumber">値型</typeparam>
    /// <typeparam name="TSelf">派生先自身の型</typeparam>
    public class Quantity<TNumber, TSelf> :
        IEquatable<TSelf>,
        IQuantity<TNumber, TSelf>
        where TNumber : INumber<TNumber>
        where TSelf : Quantity<TNumber, TSelf>,new()
    {
        #region 定数
        public static TNumber One { get; } = TNumber.One;
        public static TNumber Zero { get; } = TNumber.Zero;
        #endregion 定数

        #region プロパティ
        /// <summary>
        /// 値
        /// </summary>
        public TNumber Value { get; set; } = TNumber.Zero;
        /// <summary>
        /// 記号（override用）
        /// </summary>
        public virtual string _Symbol { get; } = "";
        #endregion プロパティ

        #region コンストラクタ
        /// <summary>
        /// 0 で初期化
        /// </summary>
        public Quantity()
        {
            Value=TNumber.Zero;
        }
        /// <summary>
        /// 指定した値で初期化
        /// </summary>
        public Quantity(TNumber value)
        {
            Value = value;
        }
        #endregion コンストラクタ

        #region object override
        /// <summary>
        /// 指定したオブジェクトが、現在のオブジェクトと等しいかどうかを判断します。
        /// </summary>
        /// <param name="obj">現在のオブジェクトと比較するオブジェクト。</param>
        /// <returns>指定したオブジェクトが現在のオブジェクトと等しい場合は true。それ以外の場合は false。</returns>
        public override bool Equals(object obj)
        {
            if (obj is TSelf)
            {
                return Equals((TSelf)obj);
            }
            return false;
        }
        /// <summary>
        /// 既定のハッシュ関数として機能します。
        /// </summary>
        /// <returns>現在のオブジェクトのハッシュ コード。</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        /// <summary>
        /// 現在のオブジェクトを表す文字列を返します。
        /// </summary>
        /// <returns>現在のオブジェクトを表す文字列。</returns>
        public override string ToString()
        {
            return Value.ToString() + _Symbol;
        }
        #endregion object override
        #region IEquatable override
        /// <summary>
        /// 現在のオブジェクトが、同じ型の別のオブジェクトと等しいかどうかを示します。
        /// </summary>
        /// <param name="other">このオブジェクトと比較するオブジェクト。</param>
        /// <returns>現在のオブジェクトが other パラメーターと等しい場合は true、それ以外の場合は false です。</returns>
        public bool Equals(TSelf other)
        {
            return Value.Equals(other.Value);
        }

        public static TSelf From(TNumber value)
        {
            var instance = new TSelf();
            instance.Value = value;
            return instance;
        }
        #endregion IEquatable override
        #region 型変換
        /// <summary>
        /// T型への明示的な変換を定義します。
        /// </summary>
        public static explicit operator TNumber(Quantity<TNumber, TSelf> quantity) => quantity.Value;
        /// <summary>
        /// 暗黙的な変換を定義します。
        /// </summary>
        public static implicit operator Quantity<TNumber, TSelf>(TNumber value) => Quantity<TNumber, TSelf>.From(value);
        /// <summary>
        /// 暗黙的な変換を定義します。
        /// NOTE:結局派生先で定義する必要がある・・・
        /// </summary>
        public static implicit operator TSelf(Quantity<TNumber, TSelf> quantity) => quantity;
        #endregion 型変換
    }
}
