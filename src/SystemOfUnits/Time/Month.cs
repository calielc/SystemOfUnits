using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} months")]
    public readonly partial struct Month : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Month>,
        IComparable,
        IComparable<Month> {
        public const string Symbol = "months";

        public Month(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Month other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Month other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Month other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Month)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} months", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Month other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} months";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Month(Value);

        public static bool operator ==(Month self, Month other) => self.Equals(other);
        public static bool operator !=(Month self, Month other) => !self.Equals(other);

        public static bool operator <(Month self, Month other) => self.CompareTo(other) < 0;
        public static bool operator >(Month self, Month other) => self.CompareTo(other) > 0;
        public static bool operator <=(Month self, Month other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Month self, Month other) => self.CompareTo(other) >= 0;

        public static Month operator +(Month self, Month other) => new Month(self.Value + other.Value);
        public static Month operator -(Month self, Month other) => new Month(self.Value - other.Value);

        public static Month operator *(Month self, double other) => new Month(self.Value * other);
        public static Month operator *(double self, Month other) => new Month(self * other.Value);

        public static Month operator /(Month self, double other) => new Month(self.Value / other);

        public static explicit operator double(Month self) => self.Value;
        public static explicit operator Month(double self) => new Month(self);
    }
}