using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Swiss franc (code: CHF and symbol Fr)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("Fr {Value}")]
    public readonly partial struct CHF : ICurrency, IEquatable<CHF>, IComparable<CHF> {
        private readonly decimal _value;

        public const string Symbol = "Fr";

        public CHF(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public CHF Ceiling() => new CHF(Math.Ceiling(_value));

        public CHF Round() => new CHF(Math.Round(_value));
        public CHF Round(int digits) => new CHF(Math.Round(_value, digits));
        public CHF Round(MidpointRounding mode) => new CHF(Math.Round(_value, mode));

        public CHF Floor() => new CHF(Math.Floor(_value));

        public CHF Truncate() => new CHF(Math.Truncate(_value));

        public CHF Abs() => new CHF(Math.Abs(_value));

        public bool Equals(CHF other) => this._value == other._value;

        public int CompareTo(CHF other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CHF other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CHF)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "Fr {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CHF other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"Fr {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(CHF self, CHF other) => self.Equals(other);
        public static bool operator !=(CHF self, CHF other) => !self.Equals(other);

        public static bool operator <(CHF self, CHF other) => self.CompareTo(other) < 0;
        public static bool operator >(CHF self, CHF other) => self.CompareTo(other) > 0;
        public static bool operator <=(CHF self, CHF other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CHF self, CHF other) => self.CompareTo(other) >= 0;

        public static CHF operator +(CHF self, CHF other) => new CHF(self._value + other._value);
        public static CHF operator -(CHF self, CHF other) => new CHF(self._value - other._value);

        public static CHF operator *(CHF self, decimal other) => new CHF(self._value * other);
        public static CHF operator *(decimal self, CHF other) => new CHF(self * other._value);

        public static CHF operator /(CHF self, decimal other) => new CHF(self._value / other);

        public static explicit operator decimal(CHF self) => self._value;
        public static explicit operator CHF(decimal self) => new CHF(self);
    }
}