using System;

namespace SystemOfUnits {
    public interface IUnit : IFormattable, IComparable {
        double Value { get; }

        string Symbol { get; }
    }
}