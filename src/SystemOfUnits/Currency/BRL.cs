using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Brazilian real (code: BRL and symbol R$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("R$ {Value}")]
    public readonly partial struct BRL : ICurrency, IEquatable<BRL>, IComparable<BRL> {
        private readonly decimal _value;

        public const string Symbol = "R$";

        public BRL(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public BRL Ceiling() => new BRL(Math.Ceiling(_value));

        public BRL Round() => new BRL(Math.Round(_value));
        public BRL Round(int digits) => new BRL(Math.Round(_value, digits));
        public BRL Round(MidpointRounding mode) => new BRL(Math.Round(_value, mode));

        public BRL Floor() => new BRL(Math.Floor(_value));

        public BRL Truncate() => new BRL(Math.Truncate(_value));

        public BRL Abs() => new BRL(Math.Abs(_value));

        public bool Equals(BRL other) => this._value == other._value;

        public int CompareTo(BRL other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case BRL other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(BRL)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "R$ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is BRL other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"R$ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(BRL self, BRL other) => self.Equals(other);
        public static bool operator !=(BRL self, BRL other) => !self.Equals(other);

        public static bool operator <(BRL self, BRL other) => self.CompareTo(other) < 0;
        public static bool operator >(BRL self, BRL other) => self.CompareTo(other) > 0;
        public static bool operator <=(BRL self, BRL other) => self.CompareTo(other) <= 0;
        public static bool operator >=(BRL self, BRL other) => self.CompareTo(other) >= 0;

        public static BRL operator +(BRL self, BRL other) => new BRL(self._value + other._value);
        public static BRL operator -(BRL self, BRL other) => new BRL(self._value - other._value);

        public static BRL operator *(BRL self, decimal other) => new BRL(self._value * other);
        public static BRL operator *(decimal self, BRL other) => new BRL(self * other._value);

        public static BRL operator /(BRL self, decimal other) => new BRL(self._value / other);

        public static explicit operator decimal(BRL self) => self._value;
        public static explicit operator BRL(decimal self) => new BRL(self);
    }
}