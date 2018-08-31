using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} years")]
    public readonly partial struct Year : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Year>,
        IComparable,
        IComparable<Year> {
        public const string Symbol = "years";

        public Year(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Year other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Year other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Year other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Year)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} years", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Year other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} years";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Year(Value);

        public static bool operator ==(Year self, Year other) => self.Equals(other);
        public static bool operator !=(Year self, Year other) => !self.Equals(other);

        public static bool operator <(Year self, Year other) => self.CompareTo(other) < 0;
        public static bool operator >(Year self, Year other) => self.CompareTo(other) > 0;
        public static bool operator <=(Year self, Year other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Year self, Year other) => self.CompareTo(other) >= 0;

        public static Year operator +(Year self, Year other) => new Year(self.Value + other.Value);
        public static Year operator -(Year self, Year other) => new Year(self.Value - other.Value);

        public static Year operator *(Year self, double other) => new Year(self.Value * other);
        public static Year operator *(double self, Year other) => new Year(self * other.Value);

        public static Year operator /(Year self, double other) => new Year(self.Value / other);

        public static explicit operator double(Year self) => self.Value;
        public static explicit operator Year(double self) => new Year(self);
    }
}