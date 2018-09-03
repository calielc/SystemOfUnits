using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Singapore dollar (code: SGD and symbol $$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("$$ {Value}")]
    public readonly partial struct SGD : ICurrency, IEquatable<SGD>, IComparable<SGD> {
        private readonly decimal _value;

        public const string Symbol = "$$";

        public SGD(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public SGD Ceiling() => new SGD(Math.Ceiling(_value));

        public SGD Round() => new SGD(Math.Round(_value));
        public SGD Round(int digits) => new SGD(Math.Round(_value, digits));
        public SGD Round(MidpointRounding mode) => new SGD(Math.Round(_value, mode));

        public SGD Floor() => new SGD(Math.Floor(_value));

        public SGD Truncate() => new SGD(Math.Truncate(_value));

        public SGD Abs() => new SGD(Math.Abs(_value));

        public bool Equals(SGD other) => this._value == other._value;

        public int CompareTo(SGD other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SGD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SGD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "$$ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SGD other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"$$ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(SGD self, SGD other) => self.Equals(other);
        public static bool operator !=(SGD self, SGD other) => !self.Equals(other);

        public static bool operator <(SGD self, SGD other) => self.CompareTo(other) < 0;
        public static bool operator >(SGD self, SGD other) => self.CompareTo(other) > 0;
        public static bool operator <=(SGD self, SGD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SGD self, SGD other) => self.CompareTo(other) >= 0;

        public static SGD operator +(SGD self, SGD other) => new SGD(self._value + other._value);
        public static SGD operator -(SGD self, SGD other) => new SGD(self._value - other._value);

        public static SGD operator *(SGD self, decimal other) => new SGD(self._value * other);
        public static SGD operator *(decimal self, SGD other) => new SGD(self * other._value);

        public static SGD operator /(SGD self, decimal other) => new SGD(self._value / other);

        public static explicit operator decimal(SGD self) => self._value;
        public static explicit operator SGD(decimal self) => new SGD(self);
    }
}