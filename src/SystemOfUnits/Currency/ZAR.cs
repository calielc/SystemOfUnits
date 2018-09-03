using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a South African rand (code: ZAR and symbol R)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("R {Value}")]
    public readonly partial struct ZAR : ICurrency, IEquatable<ZAR>, IComparable<ZAR> {
        private readonly decimal _value;

        public const string Symbol = "R";

        public ZAR(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public ZAR Ceiling() => new ZAR(Math.Ceiling(_value));

        public ZAR Round() => new ZAR(Math.Round(_value));
        public ZAR Round(int digits) => new ZAR(Math.Round(_value, digits));
        public ZAR Round(MidpointRounding mode) => new ZAR(Math.Round(_value, mode));

        public ZAR Floor() => new ZAR(Math.Floor(_value));

        public ZAR Truncate() => new ZAR(Math.Truncate(_value));

        public ZAR Abs() => new ZAR(Math.Abs(_value));

        public bool Equals(ZAR other) => this._value == other._value;

        public int CompareTo(ZAR other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case ZAR other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(ZAR)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "R {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is ZAR other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"R {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(ZAR self, ZAR other) => self.Equals(other);
        public static bool operator !=(ZAR self, ZAR other) => !self.Equals(other);

        public static bool operator <(ZAR self, ZAR other) => self.CompareTo(other) < 0;
        public static bool operator >(ZAR self, ZAR other) => self.CompareTo(other) > 0;
        public static bool operator <=(ZAR self, ZAR other) => self.CompareTo(other) <= 0;
        public static bool operator >=(ZAR self, ZAR other) => self.CompareTo(other) >= 0;

        public static ZAR operator +(ZAR self, ZAR other) => new ZAR(self._value + other._value);
        public static ZAR operator -(ZAR self, ZAR other) => new ZAR(self._value - other._value);

        public static ZAR operator *(ZAR self, decimal other) => new ZAR(self._value * other);
        public static ZAR operator *(decimal self, ZAR other) => new ZAR(self * other._value);

        public static ZAR operator /(ZAR self, decimal other) => new ZAR(self._value / other);

        public static explicit operator decimal(ZAR self) => self._value;
        public static explicit operator ZAR(decimal self) => new ZAR(self);
    }
}