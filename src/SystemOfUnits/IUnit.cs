using System;

namespace SystemOfUnits {
    public interface IUnit : IFormattable, IComparable, ICloneable {
        double Value { get; }

        string Symbol { get; }
    }
}