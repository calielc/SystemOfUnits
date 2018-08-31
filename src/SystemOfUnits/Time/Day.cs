using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} days")]
    public readonly partial struct Day : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Day>,
        IComparable,
        IComparable<Day> {
        public const string Symbol = "days";

        public Day(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Day other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Day other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Day other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Day)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} days", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Day other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} days";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Day(Value);

        public static bool operator ==(Day self, Day other) => self.Equals(other);
        public static bool operator !=(Day self, Day other) => !self.Equals(other);

        public static bool operator <(Day self, Day other) => self.CompareTo(other) < 0;
        public static bool operator >(Day self, Day other) => self.CompareTo(other) > 0;
        public static bool operator <=(Day self, Day other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Day self, Day other) => self.CompareTo(other) >= 0;

        public static Day operator +(Day self, Day other) => new Day(self.Value + other.Value);
        public static Day operator -(Day self, Day other) => new Day(self.Value - other.Value);

        public static Day operator *(Day self, double other) => new Day(self.Value * other);
        public static Day operator *(double self, Day other) => new Day(self * other.Value);

        public static Day operator /(Day self, double other) => new Day(self.Value / other);

        public static explicit operator double(Day self) => self.Value;
        public static explicit operator Day(double self) => new Day(self);
    }
}