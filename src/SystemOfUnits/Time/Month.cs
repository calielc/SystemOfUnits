using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    /// <summary>
    /// Represents a Month (symbol months).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} months")]
    public readonly partial struct Month : IUnit, IEquatable<Month>, IComparable<Month> {
        private readonly double _value;

        public const string Symbol = "months";

        public Month(double value) {
            _value = value;
        }

        public double Value => _value;

        public Month Ceiling() => new Month(Math.Ceiling(_value));

        public Month Round() => new Month(Math.Round(_value));
        public Month Round(int digits) => new Month(Math.Round(_value, digits));
        public Month Round(MidpointRounding mode) => new Month(Math.Round(_value, mode));

        public Month Floor() => new Month(Math.Floor(_value));

        public Month Truncate() => new Month(Math.Truncate(_value));

        public Month Abs() => new Month(Math.Abs(_value));

        public bool Equals(Month other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Month other) => this._value.CompareTo(other._value);

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
            => string.Format(format ?? "{0} months", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Month other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} months";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Month self, Month other) => self.Equals(other);
        public static bool operator !=(Month self, Month other) => !self.Equals(other);

        public static bool operator <(Month self, Month other) => self.CompareTo(other) < 0;
        public static bool operator >(Month self, Month other) => self.CompareTo(other) > 0;
        public static bool operator <=(Month self, Month other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Month self, Month other) => self.CompareTo(other) >= 0;

        public static Month operator +(Month self, Month other) => new Month(self._value + other._value);
        public static Month operator -(Month self, Month other) => new Month(self._value - other._value);

        public static Month operator *(Month self, double other) => new Month(self._value * other);
        public static Month operator *(double self, Month other) => new Month(self * other._value);

        public static Month operator /(Month self, double other) => new Month(self._value / other);

        public static explicit operator double(Month self) => self._value;
        public static explicit operator Month(double self) => new Month(self);
    }
}