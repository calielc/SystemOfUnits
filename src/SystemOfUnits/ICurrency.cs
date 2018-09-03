using System;

namespace SystemOfUnits {
    public interface ICurrency : IFormattable, IComparable {
        decimal Value { get; }

        string Symbol { get; }
    }
}