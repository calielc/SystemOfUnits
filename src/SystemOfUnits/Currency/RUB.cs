using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Russian ruble (code: RUB and symbol ₽)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("₽ {Value}")]
    public readonly partial struct RUB : ICurrency, IEquatable<RUB>, IComparable<RUB> {
        private readonly decimal _value;

        public const string Symbol = "₽";

        public RUB(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public RUB Ceiling() => new RUB(Math.Ceiling(_value));

        public RUB Round() => new RUB(Math.Round(_value));
        public RUB Round(int digits) => new RUB(Math.Round(_value, digits));
        public RUB Round(MidpointRounding mode) => new RUB(Math.Round(_value, mode));

        public RUB Floor() => new RUB(Math.Floor(_value));

        public RUB Truncate() => new RUB(Math.Truncate(_value));

        public RUB Abs() => new RUB(Math.Abs(_value));

        public bool Equals(RUB other) => this._value == other._value;

        public int CompareTo(RUB other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case RUB other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(RUB)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "₽ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is RUB other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"₽ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(RUB self, RUB other) => self.Equals(other);
        public static bool operator !=(RUB self, RUB other) => !self.Equals(other);

        public static bool operator <(RUB self, RUB other) => self.CompareTo(other) < 0;
        public static bool operator >(RUB self, RUB other) => self.CompareTo(other) > 0;
        public static bool operator <=(RUB self, RUB other) => self.CompareTo(other) <= 0;
        public static bool operator >=(RUB self, RUB other) => self.CompareTo(other) >= 0;

        public static RUB operator +(RUB self, RUB other) => new RUB(self._value + other._value);
        public static RUB operator -(RUB self, RUB other) => new RUB(self._value - other._value);

        public static RUB operator *(RUB self, decimal other) => new RUB(self._value * other);
        public static RUB operator *(decimal self, RUB other) => new RUB(self * other._value);

        public static RUB operator /(RUB self, decimal other) => new RUB(self._value / other);

        public static explicit operator decimal(RUB self) => self._value;
        public static explicit operator RUB(decimal self) => new RUB(self);
    }
}