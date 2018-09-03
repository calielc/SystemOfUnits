using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Indian rupee (code: INR and symbol ₹)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("₹ {Value}")]
    public readonly partial struct INR : ICurrency, IEquatable<INR>, IComparable<INR> {
        private readonly decimal _value;

        public const string Symbol = "₹";

        public INR(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public INR Ceiling() => new INR(Math.Ceiling(_value));

        public INR Round() => new INR(Math.Round(_value));
        public INR Round(int digits) => new INR(Math.Round(_value, digits));
        public INR Round(MidpointRounding mode) => new INR(Math.Round(_value, mode));

        public INR Floor() => new INR(Math.Floor(_value));

        public INR Truncate() => new INR(Math.Truncate(_value));

        public INR Abs() => new INR(Math.Abs(_value));

        public bool Equals(INR other) => this._value == other._value;

        public int CompareTo(INR other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case INR other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(INR)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "₹ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is INR other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"₹ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(INR self, INR other) => self.Equals(other);
        public static bool operator !=(INR self, INR other) => !self.Equals(other);

        public static bool operator <(INR self, INR other) => self.CompareTo(other) < 0;
        public static bool operator >(INR self, INR other) => self.CompareTo(other) > 0;
        public static bool operator <=(INR self, INR other) => self.CompareTo(other) <= 0;
        public static bool operator >=(INR self, INR other) => self.CompareTo(other) >= 0;

        public static INR operator +(INR self, INR other) => new INR(self._value + other._value);
        public static INR operator -(INR self, INR other) => new INR(self._value - other._value);

        public static INR operator *(INR self, decimal other) => new INR(self._value * other);
        public static INR operator *(decimal self, INR other) => new INR(self * other._value);

        public static INR operator /(INR self, decimal other) => new INR(self._value / other);

        public static explicit operator decimal(INR self) => self._value;
        public static explicit operator INR(decimal self) => new INR(self);
    }
}