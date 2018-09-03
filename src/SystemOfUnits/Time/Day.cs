using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    /// <summary>
    /// Represents a Day (symbol days).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} days")]
    public readonly partial struct Day : IUnit, IEquatable<Day>, IComparable<Day> {
        private readonly double _value;

        public const string Symbol = "days";

        public Day(double value) {
            _value = value;
        }

        public double Value => _value;

        public Day Ceiling() => new Day(Math.Ceiling(_value));

        public Day Round() => new Day(Math.Round(_value));
        public Day Round(int digits) => new Day(Math.Round(_value, digits));
        public Day Round(MidpointRounding mode) => new Day(Math.Round(_value, mode));

        public Day Floor() => new Day(Math.Floor(_value));

        public Day Truncate() => new Day(Math.Truncate(_value));

        public Day Abs() => new Day(Math.Abs(_value));

        public bool Equals(Day other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Day other) => this._value.CompareTo(other._value);

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
            => string.Format(format ?? "{0} days", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Day other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} days";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Day self, Day other) => self.Equals(other);
        public static bool operator !=(Day self, Day other) => !self.Equals(other);

        public static bool operator <(Day self, Day other) => self.CompareTo(other) < 0;
        public static bool operator >(Day self, Day other) => self.CompareTo(other) > 0;
        public static bool operator <=(Day self, Day other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Day self, Day other) => self.CompareTo(other) >= 0;

        public static Day operator +(Day self, Day other) => new Day(self._value + other._value);
        public static Day operator -(Day self, Day other) => new Day(self._value - other._value);

        public static Day operator *(Day self, double other) => new Day(self._value * other);
        public static Day operator *(double self, Day other) => new Day(self * other._value);

        public static Day operator /(Day self, double other) => new Day(self._value / other);

        public static explicit operator double(Day self) => self._value;
        public static explicit operator Day(double self) => new Day(self);
    }
}