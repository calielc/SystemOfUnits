using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hours")]
    public readonly partial struct Hour : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Hour>,
        IComparable,
        IComparable<Hour> {
        public const string Symbol = "hours";

        public Hour(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Hour other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Hour other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hour other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hour)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hours", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hour other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hours";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Hour(Value);

        public static bool operator ==(Hour self, Hour other) => self.Equals(other);
        public static bool operator !=(Hour self, Hour other) => !self.Equals(other);

        public static bool operator <(Hour self, Hour other) => self.CompareTo(other) < 0;
        public static bool operator >(Hour self, Hour other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hour self, Hour other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hour self, Hour other) => self.CompareTo(other) >= 0;

        public static Hour operator +(Hour self, Hour other) => new Hour(self.Value + other.Value);
        public static Hour operator -(Hour self, Hour other) => new Hour(self.Value - other.Value);

        public static Hour operator *(Hour self, double other) => new Hour(self.Value * other);
        public static Hour operator *(double self, Hour other) => new Hour(self * other.Value);

        public static Hour operator /(Hour self, double other) => new Hour(self.Value / other);

        public static explicit operator double(Hour self) => self.Value;
        public static explicit operator Hour(double self) => new Hour(self);
    }
}