using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    /// <summary>
    /// Represents a Year (symbol years).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} years")]
    public readonly partial struct Year : IUnit, IEquatable<Year>, IComparable<Year> {
        private readonly double _value;

        public const string Symbol = "years";

        public Year(double value) {
            _value = value;
        }

        public double Value => _value;

        public Year Ceiling() => new Year(Math.Ceiling(_value));

        public Year Round() => new Year(Math.Round(_value));
        public Year Round(int digits) => new Year(Math.Round(_value, digits));
        public Year Round(MidpointRounding mode) => new Year(Math.Round(_value, mode));

        public Year Floor() => new Year(Math.Floor(_value));

        public Year Truncate() => new Year(Math.Truncate(_value));

        public Year Abs() => new Year(Math.Abs(_value));

        public bool Equals(Year other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Year other) => this._value.CompareTo(other._value);

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
            => string.Format(format ?? "{0} years", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Year other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} years";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Year self, Year other) => self.Equals(other);
        public static bool operator !=(Year self, Year other) => !self.Equals(other);

        public static bool operator <(Year self, Year other) => self.CompareTo(other) < 0;
        public static bool operator >(Year self, Year other) => self.CompareTo(other) > 0;
        public static bool operator <=(Year self, Year other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Year self, Year other) => self.CompareTo(other) >= 0;

        public static Year operator +(Year self, Year other) => new Year(self._value + other._value);
        public static Year operator -(Year self, Year other) => new Year(self._value - other._value);

        public static Year operator *(Year self, double other) => new Year(self._value * other);
        public static Year operator *(double self, Year other) => new Year(self * other._value);

        public static Year operator /(Year self, double other) => new Year(self._value / other);

        public static explicit operator double(Year self) => self._value;
        public static explicit operator Year(double self) => new Year(self);
    }
}