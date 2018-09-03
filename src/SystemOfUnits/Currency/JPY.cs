using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Japonese yen (code: JPY and symbol ¥)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("¥ {Value}")]
    public readonly partial struct JPY : ICurrency, IEquatable<JPY>, IComparable<JPY> {
        private readonly decimal _value;

        public const string Symbol = "¥";

        public JPY(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public JPY Ceiling() => new JPY(Math.Ceiling(_value));

        public JPY Round() => new JPY(Math.Round(_value));
        public JPY Round(int digits) => new JPY(Math.Round(_value, digits));
        public JPY Round(MidpointRounding mode) => new JPY(Math.Round(_value, mode));

        public JPY Floor() => new JPY(Math.Floor(_value));

        public JPY Truncate() => new JPY(Math.Truncate(_value));

        public JPY Abs() => new JPY(Math.Abs(_value));

        public bool Equals(JPY other) => this._value == other._value;

        public int CompareTo(JPY other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case JPY other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(JPY)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "¥ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is JPY other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"¥ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(JPY self, JPY other) => self.Equals(other);
        public static bool operator !=(JPY self, JPY other) => !self.Equals(other);

        public static bool operator <(JPY self, JPY other) => self.CompareTo(other) < 0;
        public static bool operator >(JPY self, JPY other) => self.CompareTo(other) > 0;
        public static bool operator <=(JPY self, JPY other) => self.CompareTo(other) <= 0;
        public static bool operator >=(JPY self, JPY other) => self.CompareTo(other) >= 0;

        public static JPY operator +(JPY self, JPY other) => new JPY(self._value + other._value);
        public static JPY operator -(JPY self, JPY other) => new JPY(self._value - other._value);

        public static JPY operator *(JPY self, decimal other) => new JPY(self._value * other);
        public static JPY operator *(decimal self, JPY other) => new JPY(self * other._value);

        public static JPY operator /(JPY self, decimal other) => new JPY(self._value / other);

        public static explicit operator decimal(JPY self) => self._value;
        public static explicit operator JPY(decimal self) => new JPY(self);
    }
}