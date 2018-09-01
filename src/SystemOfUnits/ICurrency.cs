using System;

namespace SystemOfUnits {
    public interface ICurrency : IFormattable, IComparable, ICloneable {
        decimal Value { get; }

        string Symbol { get; }
    }
}