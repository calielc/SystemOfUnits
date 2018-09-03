using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Norwegian krone (code: NOK and symbol kr)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("kr {Value}")]
    public readonly partial struct NOK : ICurrency, IEquatable<NOK>, IComparable<NOK> {
        private readonly decimal _value;

        public const string Symbol = "kr";

        public NOK(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public NOK Ceiling() => new NOK(Math.Ceiling(_value));

        public NOK Round() => new NOK(Math.Round(_value));
        public NOK Round(int digits) => new NOK(Math.Round(_value, digits));
        public NOK Round(MidpointRounding mode) => new NOK(Math.Round(_value, mode));

        public NOK Floor() => new NOK(Math.Floor(_value));

        public NOK Truncate() => new NOK(Math.Truncate(_value));

        public NOK Abs() => new NOK(Math.Abs(_value));

        public bool Equals(NOK other) => this._value == other._value;

        public int CompareTo(NOK other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case NOK other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(NOK)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "kr {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is NOK other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"kr {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(NOK self, NOK other) => self.Equals(other);
        public static bool operator !=(NOK self, NOK other) => !self.Equals(other);

        public static bool operator <(NOK self, NOK other) => self.CompareTo(other) < 0;
        public static bool operator >(NOK self, NOK other) => self.CompareTo(other) > 0;
        public static bool operator <=(NOK self, NOK other) => self.CompareTo(other) <= 0;
        public static bool operator >=(NOK self, NOK other) => self.CompareTo(other) >= 0;

        public static NOK operator +(NOK self, NOK other) => new NOK(self._value + other._value);
        public static NOK operator -(NOK self, NOK other) => new NOK(self._value - other._value);

        public static NOK operator *(NOK self, decimal other) => new NOK(self._value * other);
        public static NOK operator *(decimal self, NOK other) => new NOK(self * other._value);

        public static NOK operator /(NOK self, decimal other) => new NOK(self._value / other);

        public static explicit operator decimal(NOK self) => self._value;
        public static explicit operator NOK(decimal self) => new NOK(self);
    }
}