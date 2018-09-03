using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Swedish krona (code: SEK and symbol kr)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("kr {Value}")]
    public readonly partial struct SEK : ICurrency, IEquatable<SEK>, IComparable<SEK> {
        private readonly decimal _value;

        public const string Symbol = "kr";

        public SEK(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public SEK Ceiling() => new SEK(Math.Ceiling(_value));

        public SEK Round() => new SEK(Math.Round(_value));
        public SEK Round(int digits) => new SEK(Math.Round(_value, digits));
        public SEK Round(MidpointRounding mode) => new SEK(Math.Round(_value, mode));

        public SEK Floor() => new SEK(Math.Floor(_value));

        public SEK Truncate() => new SEK(Math.Truncate(_value));

        public SEK Abs() => new SEK(Math.Abs(_value));

        public bool Equals(SEK other) => this._value == other._value;

        public int CompareTo(SEK other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SEK other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SEK)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "kr {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SEK other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"kr {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(SEK self, SEK other) => self.Equals(other);
        public static bool operator !=(SEK self, SEK other) => !self.Equals(other);

        public static bool operator <(SEK self, SEK other) => self.CompareTo(other) < 0;
        public static bool operator >(SEK self, SEK other) => self.CompareTo(other) > 0;
        public static bool operator <=(SEK self, SEK other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SEK self, SEK other) => self.CompareTo(other) >= 0;

        public static SEK operator +(SEK self, SEK other) => new SEK(self._value + other._value);
        public static SEK operator -(SEK self, SEK other) => new SEK(self._value - other._value);

        public static SEK operator *(SEK self, decimal other) => new SEK(self._value * other);
        public static SEK operator *(decimal self, SEK other) => new SEK(self * other._value);

        public static SEK operator /(SEK self, decimal other) => new SEK(self._value / other);

        public static explicit operator decimal(SEK self) => self._value;
        public static explicit operator SEK(decimal self) => new SEK(self);
    }
}