using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a United States dollar (code: USD and symbol US$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("US$ {Value}")]
    public readonly partial struct USD : ICurrency, IEquatable<USD>, IComparable<USD> {
        private readonly decimal _value;

        public const string Symbol = "US$";

        public USD(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public USD Ceiling() => new USD(Math.Ceiling(_value));

        public USD Round() => new USD(Math.Round(_value));
        public USD Round(int digits) => new USD(Math.Round(_value, digits));
        public USD Round(MidpointRounding mode) => new USD(Math.Round(_value, mode));

        public USD Floor() => new USD(Math.Floor(_value));

        public USD Truncate() => new USD(Math.Truncate(_value));

        public USD Abs() => new USD(Math.Abs(_value));

        public bool Equals(USD other) => this._value == other._value;

        public int CompareTo(USD other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case USD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(USD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "US$ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is USD other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"US$ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(USD self, USD other) => self.Equals(other);
        public static bool operator !=(USD self, USD other) => !self.Equals(other);

        public static bool operator <(USD self, USD other) => self.CompareTo(other) < 0;
        public static bool operator >(USD self, USD other) => self.CompareTo(other) > 0;
        public static bool operator <=(USD self, USD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(USD self, USD other) => self.CompareTo(other) >= 0;

        public static USD operator +(USD self, USD other) => new USD(self._value + other._value);
        public static USD operator -(USD self, USD other) => new USD(self._value - other._value);

        public static USD operator *(USD self, decimal other) => new USD(self._value * other);
        public static USD operator *(decimal self, USD other) => new USD(self * other._value);

        public static USD operator /(USD self, decimal other) => new USD(self._value / other);

        public static explicit operator decimal(USD self) => self._value;
        public static explicit operator USD(decimal self) => new USD(self);
    }
}