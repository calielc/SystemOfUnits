using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Euro (code: EUR and symbol €)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("€ {Value}")]
    public readonly partial struct EUR : ICurrency, IEquatable<EUR>, IComparable<EUR> {
        private readonly decimal _value;

        public const string Symbol = "€";

        public EUR(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public EUR Ceiling() => new EUR(Math.Ceiling(_value));

        public EUR Round() => new EUR(Math.Round(_value));
        public EUR Round(int digits) => new EUR(Math.Round(_value, digits));
        public EUR Round(MidpointRounding mode) => new EUR(Math.Round(_value, mode));

        public EUR Floor() => new EUR(Math.Floor(_value));

        public EUR Truncate() => new EUR(Math.Truncate(_value));

        public EUR Abs() => new EUR(Math.Abs(_value));

        public bool Equals(EUR other) => this._value == other._value;

        public int CompareTo(EUR other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case EUR other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(EUR)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "€ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is EUR other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"€ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(EUR self, EUR other) => self.Equals(other);
        public static bool operator !=(EUR self, EUR other) => !self.Equals(other);

        public static bool operator <(EUR self, EUR other) => self.CompareTo(other) < 0;
        public static bool operator >(EUR self, EUR other) => self.CompareTo(other) > 0;
        public static bool operator <=(EUR self, EUR other) => self.CompareTo(other) <= 0;
        public static bool operator >=(EUR self, EUR other) => self.CompareTo(other) >= 0;

        public static EUR operator +(EUR self, EUR other) => new EUR(self._value + other._value);
        public static EUR operator -(EUR self, EUR other) => new EUR(self._value - other._value);

        public static EUR operator *(EUR self, decimal other) => new EUR(self._value * other);
        public static EUR operator *(decimal self, EUR other) => new EUR(self * other._value);

        public static EUR operator /(EUR self, decimal other) => new EUR(self._value / other);

        public static explicit operator decimal(EUR self) => self._value;
        public static explicit operator EUR(decimal self) => new EUR(self);
    }
}