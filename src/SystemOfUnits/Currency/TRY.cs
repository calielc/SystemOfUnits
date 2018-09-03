using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Turkish lira (code: TRY and symbol ₺)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("₺ {Value}")]
    public readonly partial struct TRY : ICurrency, IEquatable<TRY>, IComparable<TRY> {
        private readonly decimal _value;

        public const string Symbol = "₺";

        public TRY(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public TRY Ceiling() => new TRY(Math.Ceiling(_value));

        public TRY Round() => new TRY(Math.Round(_value));
        public TRY Round(int digits) => new TRY(Math.Round(_value, digits));
        public TRY Round(MidpointRounding mode) => new TRY(Math.Round(_value, mode));

        public TRY Floor() => new TRY(Math.Floor(_value));

        public TRY Truncate() => new TRY(Math.Truncate(_value));

        public TRY Abs() => new TRY(Math.Abs(_value));

        public bool Equals(TRY other) => this._value == other._value;

        public int CompareTo(TRY other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case TRY other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(TRY)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "₺ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is TRY other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"₺ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(TRY self, TRY other) => self.Equals(other);
        public static bool operator !=(TRY self, TRY other) => !self.Equals(other);

        public static bool operator <(TRY self, TRY other) => self.CompareTo(other) < 0;
        public static bool operator >(TRY self, TRY other) => self.CompareTo(other) > 0;
        public static bool operator <=(TRY self, TRY other) => self.CompareTo(other) <= 0;
        public static bool operator >=(TRY self, TRY other) => self.CompareTo(other) >= 0;

        public static TRY operator +(TRY self, TRY other) => new TRY(self._value + other._value);
        public static TRY operator -(TRY self, TRY other) => new TRY(self._value - other._value);

        public static TRY operator *(TRY self, decimal other) => new TRY(self._value * other);
        public static TRY operator *(decimal self, TRY other) => new TRY(self * other._value);

        public static TRY operator /(TRY self, decimal other) => new TRY(self._value / other);

        public static explicit operator decimal(TRY self) => self._value;
        public static explicit operator TRY(decimal self) => new TRY(self);
    }
}