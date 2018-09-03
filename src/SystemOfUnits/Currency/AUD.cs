using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Australian dollar (code: AUD and symbol A$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("A$ {Value}")]
    public readonly partial struct AUD : ICurrency, IEquatable<AUD>, IComparable<AUD> {
        private readonly decimal _value;

        public const string Symbol = "A$";

        public AUD(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public AUD Ceiling() => new AUD(Math.Ceiling(_value));

        public AUD Round() => new AUD(Math.Round(_value));
        public AUD Round(int digits) => new AUD(Math.Round(_value, digits));
        public AUD Round(MidpointRounding mode) => new AUD(Math.Round(_value, mode));

        public AUD Floor() => new AUD(Math.Floor(_value));

        public AUD Truncate() => new AUD(Math.Truncate(_value));

        public AUD Abs() => new AUD(Math.Abs(_value));

        public bool Equals(AUD other) => this._value == other._value;

        public int CompareTo(AUD other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case AUD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(AUD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "A$ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is AUD other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"A$ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(AUD self, AUD other) => self.Equals(other);
        public static bool operator !=(AUD self, AUD other) => !self.Equals(other);

        public static bool operator <(AUD self, AUD other) => self.CompareTo(other) < 0;
        public static bool operator >(AUD self, AUD other) => self.CompareTo(other) > 0;
        public static bool operator <=(AUD self, AUD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(AUD self, AUD other) => self.CompareTo(other) >= 0;

        public static AUD operator +(AUD self, AUD other) => new AUD(self._value + other._value);
        public static AUD operator -(AUD self, AUD other) => new AUD(self._value - other._value);

        public static AUD operator *(AUD self, decimal other) => new AUD(self._value * other);
        public static AUD operator *(decimal self, AUD other) => new AUD(self * other._value);

        public static AUD operator /(AUD self, decimal other) => new AUD(self._value / other);

        public static explicit operator decimal(AUD self) => self._value;
        public static explicit operator AUD(decimal self) => new AUD(self);
    }
}