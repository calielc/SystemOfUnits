using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    /// <summary>
    /// Represents a Hour (symbol hours).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hours")]
    public readonly partial struct Hour : IUnit, IEquatable<Hour>, IComparable<Hour> {
        private readonly double _value;

        public const string Symbol = "hours";

        public Hour(double value) {
            _value = value;
        }

        public double Value => _value;

        public Hour Ceiling() => new Hour(Math.Ceiling(_value));

        public Hour Round() => new Hour(Math.Round(_value));
        public Hour Round(int digits) => new Hour(Math.Round(_value, digits));
        public Hour Round(MidpointRounding mode) => new Hour(Math.Round(_value, mode));

        public Hour Floor() => new Hour(Math.Floor(_value));

        public Hour Truncate() => new Hour(Math.Truncate(_value));

        public Hour Abs() => new Hour(Math.Abs(_value));

        public bool Equals(Hour other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Hour other) => this._value.CompareTo(other._value);

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
            => string.Format(format ?? "{0} hours", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hour other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hours";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Hour self, Hour other) => self.Equals(other);
        public static bool operator !=(Hour self, Hour other) => !self.Equals(other);

        public static bool operator <(Hour self, Hour other) => self.CompareTo(other) < 0;
        public static bool operator >(Hour self, Hour other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hour self, Hour other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hour self, Hour other) => self.CompareTo(other) >= 0;

        public static Hour operator +(Hour self, Hour other) => new Hour(self._value + other._value);
        public static Hour operator -(Hour self, Hour other) => new Hour(self._value - other._value);

        public static Hour operator *(Hour self, double other) => new Hour(self._value * other);
        public static Hour operator *(double self, Hour other) => new Hour(self * other._value);

        public static Hour operator /(Hour self, double other) => new Hour(self._value / other);

        public static explicit operator double(Hour self) => self._value;
        public static explicit operator Hour(double self) => new Hour(self);
    }
}