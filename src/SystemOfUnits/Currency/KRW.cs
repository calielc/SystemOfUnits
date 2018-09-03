using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a South Korean won (code: KRW and symbol ₩)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("₩ {Value}")]
    public readonly partial struct KRW : ICurrency, IEquatable<KRW>, IComparable<KRW> {
        private readonly decimal _value;

        public const string Symbol = "₩";

        public KRW(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public KRW Ceiling() => new KRW(Math.Ceiling(_value));

        public KRW Round() => new KRW(Math.Round(_value));
        public KRW Round(int digits) => new KRW(Math.Round(_value, digits));
        public KRW Round(MidpointRounding mode) => new KRW(Math.Round(_value, mode));

        public KRW Floor() => new KRW(Math.Floor(_value));

        public KRW Truncate() => new KRW(Math.Truncate(_value));

        public KRW Abs() => new KRW(Math.Abs(_value));

        public bool Equals(KRW other) => this._value == other._value;

        public int CompareTo(KRW other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case KRW other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(KRW)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "₩ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is KRW other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"₩ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(KRW self, KRW other) => self.Equals(other);
        public static bool operator !=(KRW self, KRW other) => !self.Equals(other);

        public static bool operator <(KRW self, KRW other) => self.CompareTo(other) < 0;
        public static bool operator >(KRW self, KRW other) => self.CompareTo(other) > 0;
        public static bool operator <=(KRW self, KRW other) => self.CompareTo(other) <= 0;
        public static bool operator >=(KRW self, KRW other) => self.CompareTo(other) >= 0;

        public static KRW operator +(KRW self, KRW other) => new KRW(self._value + other._value);
        public static KRW operator -(KRW self, KRW other) => new KRW(self._value - other._value);

        public static KRW operator *(KRW self, decimal other) => new KRW(self._value * other);
        public static KRW operator *(decimal self, KRW other) => new KRW(self * other._value);

        public static KRW operator /(KRW self, decimal other) => new KRW(self._value / other);

        public static explicit operator decimal(KRW self) => self._value;
        public static explicit operator KRW(decimal self) => new KRW(self);
    }
}