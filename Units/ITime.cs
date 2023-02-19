﻿using System.Numerics;

namespace Ksnm.Units
{
    /// <summary>
    /// 時間
    /// </summary>
    /// <typeparam name="T">数値型</typeparam>
    public interface ITime<T> : IQuantity<T> where T : INumber<T>
    {
    }
}
