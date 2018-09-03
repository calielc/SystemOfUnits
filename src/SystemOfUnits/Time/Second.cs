using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    /// <summary>
    /// Represents a Second (symbol seconds).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} seconds")]
    public readonly partial struct Second : IUnit, IEquatable<Second>, IComparable<Second> {
        private readonly double _value;

        public const string Symbol = "seconds";

        public Second(double value) {
            _value = value;
        }

        public double Value => _value;

        public Second Ceiling() => new Second(Math.Ceiling(_value));

        public Second Round() => new Second(Math.Round(_value));
        public Second Round(int digits) => new Second(Math.Round(_value, digits));
        public Second Round(MidpointRounding mode) => new Second(Math.Round(_value, mode));

        public Second Floor() => new Second(Math.Floor(_value));

        public Second Truncate() => new Second(Math.Truncate(_value));

        public Second Abs() => new Second(Math.Abs(_value));

        public bool Equals(Second other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Second other) => this._value.CompareTo(other._value);

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
            => string.Format(format ?? "{0} seconds", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Second other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} seconds";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Second self, Second other) => self.Equals(other);
        public static bool operator !=(Second self, Second other) => !self.Equals(other);

        public static bool operator <(Second self, Second other) => self.CompareTo(other) < 0;
        public static bool operator >(Second self, Second other) => self.CompareTo(other) > 0;
        public static bool operator <=(Second self, Second other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Second self, Second other) => self.CompareTo(other) >= 0;

        public static Second operator +(Second self, Second other) => new Second(self._value + other._value);
        public static Second operator -(Second self, Second other) => new Second(self._value - other._value);

        public static Second operator *(Second self, double other) => new Second(self._value * other);
        public static Second operator *(double self, Second other) => new Second(self * other._value);

        public static Second operator /(Second self, double other) => new Second(self._value / other);

        public static explicit operator double(Second self) => self._value;
        public static explicit operator Second(double self) => new Second(self);
    }
}