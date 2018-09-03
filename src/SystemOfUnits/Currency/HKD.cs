using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Hong Kong dollar (code: HKD and symbol HK$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("HK$ {Value}")]
    public readonly partial struct HKD : ICurrency, IEquatable<HKD>, IComparable<HKD> {
        private readonly decimal _value;

        public const string Symbol = "HK$";

        public HKD(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public HKD Ceiling() => new HKD(Math.Ceiling(_value));

        public HKD Round() => new HKD(Math.Round(_value));
        public HKD Round(int digits) => new HKD(Math.Round(_value, digits));
        public HKD Round(MidpointRounding mode) => new HKD(Math.Round(_value, mode));

        public HKD Floor() => new HKD(Math.Floor(_value));

        public HKD Truncate() => new HKD(Math.Truncate(_value));

        public HKD Abs() => new HKD(Math.Abs(_value));

        public bool Equals(HKD other) => this._value == other._value;

        public int CompareTo(HKD other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case HKD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(HKD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "HK$ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is HKD other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"HK$ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(HKD self, HKD other) => self.Equals(other);
        public static bool operator !=(HKD self, HKD other) => !self.Equals(other);

        public static bool operator <(HKD self, HKD other) => self.CompareTo(other) < 0;
        public static bool operator >(HKD self, HKD other) => self.CompareTo(other) > 0;
        public static bool operator <=(HKD self, HKD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(HKD self, HKD other) => self.CompareTo(other) >= 0;

        public static HKD operator +(HKD self, HKD other) => new HKD(self._value + other._value);
        public static HKD operator -(HKD self, HKD other) => new HKD(self._value - other._value);

        public static HKD operator *(HKD self, decimal other) => new HKD(self._value * other);
        public static HKD operator *(decimal self, HKD other) => new HKD(self * other._value);

        public static HKD operator /(HKD self, decimal other) => new HKD(self._value / other);

        public static explicit operator decimal(HKD self) => self._value;
        public static explicit operator HKD(decimal self) => new HKD(self);
    }
}