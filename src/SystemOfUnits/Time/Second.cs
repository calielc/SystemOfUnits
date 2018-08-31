using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} seconds")]
    public readonly partial struct Second : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Second>,
        IComparable,
        IComparable<Second> {
        public const string Symbol = "seconds";

        public Second(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Second other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Second other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Second other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Second)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} seconds", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Second other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} seconds";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Second(Value);

        public static bool operator ==(Second self, Second other) => self.Equals(other);
        public static bool operator !=(Second self, Second other) => !self.Equals(other);

        public static bool operator <(Second self, Second other) => self.CompareTo(other) < 0;
        public static bool operator >(Second self, Second other) => self.CompareTo(other) > 0;
        public static bool operator <=(Second self, Second other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Second self, Second other) => self.CompareTo(other) >= 0;

        public static Second operator +(Second self, Second other) => new Second(self.Value + other.Value);
        public static Second operator -(Second self, Second other) => new Second(self.Value - other.Value);

        public static Second operator *(Second self, double other) => new Second(self.Value * other);
        public static Second operator *(double self, Second other) => new Second(self * other.Value);

        public static Second operator /(Second self, double other) => new Second(self.Value / other);

        public static explicit operator double(Second self) => self.Value;
        public static explicit operator Second(double self) => new Second(self);
    }
}