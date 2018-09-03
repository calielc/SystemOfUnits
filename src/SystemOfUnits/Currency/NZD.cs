using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a New Zealand dollar (code: NZD and symbol NZ$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("NZ$ {Value}")]
    public readonly partial struct NZD : ICurrency, IEquatable<NZD>, IComparable<NZD> {
        private readonly decimal _value;

        public const string Symbol = "NZ$";

        public NZD(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public NZD Ceiling() => new NZD(Math.Ceiling(_value));

        public NZD Round() => new NZD(Math.Round(_value));
        public NZD Round(int digits) => new NZD(Math.Round(_value, digits));
        public NZD Round(MidpointRounding mode) => new NZD(Math.Round(_value, mode));

        public NZD Floor() => new NZD(Math.Floor(_value));

        public NZD Truncate() => new NZD(Math.Truncate(_value));

        public NZD Abs() => new NZD(Math.Abs(_value));

        public bool Equals(NZD other) => this._value == other._value;

        public int CompareTo(NZD other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case NZD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(NZD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "NZ$ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is NZD other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"NZ$ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(NZD self, NZD other) => self.Equals(other);
        public static bool operator !=(NZD self, NZD other) => !self.Equals(other);

        public static bool operator <(NZD self, NZD other) => self.CompareTo(other) < 0;
        public static bool operator >(NZD self, NZD other) => self.CompareTo(other) > 0;
        public static bool operator <=(NZD self, NZD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(NZD self, NZD other) => self.CompareTo(other) >= 0;

        public static NZD operator +(NZD self, NZD other) => new NZD(self._value + other._value);
        public static NZD operator -(NZD self, NZD other) => new NZD(self._value - other._value);

        public static NZD operator *(NZD self, decimal other) => new NZD(self._value * other);
        public static NZD operator *(decimal self, NZD other) => new NZD(self * other._value);

        public static NZD operator /(NZD self, decimal other) => new NZD(self._value / other);

        public static explicit operator decimal(NZD self) => self._value;
        public static explicit operator NZD(decimal self) => new NZD(self);
    }
}