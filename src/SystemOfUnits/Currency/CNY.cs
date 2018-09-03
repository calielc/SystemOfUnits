using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Renminbi (code: CNY and symbol 元)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("元 {Value}")]
    public readonly partial struct CNY : ICurrency, IEquatable<CNY>, IComparable<CNY> {
        private readonly decimal _value;

        public const string Symbol = "元";

        public CNY(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public CNY Ceiling() => new CNY(Math.Ceiling(_value));

        public CNY Round() => new CNY(Math.Round(_value));
        public CNY Round(int digits) => new CNY(Math.Round(_value, digits));
        public CNY Round(MidpointRounding mode) => new CNY(Math.Round(_value, mode));

        public CNY Floor() => new CNY(Math.Floor(_value));

        public CNY Truncate() => new CNY(Math.Truncate(_value));

        public CNY Abs() => new CNY(Math.Abs(_value));

        public bool Equals(CNY other) => this._value == other._value;

        public int CompareTo(CNY other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CNY other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CNY)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "元 {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CNY other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"元 {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(CNY self, CNY other) => self.Equals(other);
        public static bool operator !=(CNY self, CNY other) => !self.Equals(other);

        public static bool operator <(CNY self, CNY other) => self.CompareTo(other) < 0;
        public static bool operator >(CNY self, CNY other) => self.CompareTo(other) > 0;
        public static bool operator <=(CNY self, CNY other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CNY self, CNY other) => self.CompareTo(other) >= 0;

        public static CNY operator +(CNY self, CNY other) => new CNY(self._value + other._value);
        public static CNY operator -(CNY self, CNY other) => new CNY(self._value - other._value);

        public static CNY operator *(CNY self, decimal other) => new CNY(self._value * other);
        public static CNY operator *(decimal self, CNY other) => new CNY(self * other._value);

        public static CNY operator /(CNY self, decimal other) => new CNY(self._value / other);

        public static explicit operator decimal(CNY self) => self._value;
        public static explicit operator CNY(decimal self) => new CNY(self);
    }
}