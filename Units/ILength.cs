﻿using System.Numerics;

namespace Ksnm.Units
{
    /// <summary>
    /// 長さ
    /// </summary>
    /// <typeparam name="TNumber">数値型</typeparam>
    /// <typeparam name="TSelf">派生先自身の型</typeparam>
    public interface ILength<TNumber, TSelf> :
        IQuantity<TNumber, TSelf>
        where TNumber : INumber<TNumber>
        where TSelf : Quantity<TNumber, TSelf>, new()
    {
    }
}
