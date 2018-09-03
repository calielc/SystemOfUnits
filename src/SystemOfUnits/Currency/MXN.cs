using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Mexican peso (code: MXN and symbol $)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("$ {Value}")]
    public readonly partial struct MXN : ICurrency, IEquatable<MXN>, IComparable<MXN> {
        private readonly decimal _value;

        public const string Symbol = "$";

        public MXN(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public MXN Ceiling() => new MXN(Math.Ceiling(_value));

        public MXN Round() => new MXN(Math.Round(_value));
        public MXN Round(int digits) => new MXN(Math.Round(_value, digits));
        public MXN Round(MidpointRounding mode) => new MXN(Math.Round(_value, mode));

        public MXN Floor() => new MXN(Math.Floor(_value));

        public MXN Truncate() => new MXN(Math.Truncate(_value));

        public MXN Abs() => new MXN(Math.Abs(_value));

        public bool Equals(MXN other) => this._value == other._value;

        public int CompareTo(MXN other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case MXN other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(MXN)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "$ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is MXN other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"$ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(MXN self, MXN other) => self.Equals(other);
        public static bool operator !=(MXN self, MXN other) => !self.Equals(other);

        public static bool operator <(MXN self, MXN other) => self.CompareTo(other) < 0;
        public static bool operator >(MXN self, MXN other) => self.CompareTo(other) > 0;
        public static bool operator <=(MXN self, MXN other) => self.CompareTo(other) <= 0;
        public static bool operator >=(MXN self, MXN other) => self.CompareTo(other) >= 0;

        public static MXN operator +(MXN self, MXN other) => new MXN(self._value + other._value);
        public static MXN operator -(MXN self, MXN other) => new MXN(self._value - other._value);

        public static MXN operator *(MXN self, decimal other) => new MXN(self._value * other);
        public static MXN operator *(decimal self, MXN other) => new MXN(self * other._value);

        public static MXN operator /(MXN self, decimal other) => new MXN(self._value / other);

        public static explicit operator decimal(MXN self) => self._value;
        public static explicit operator MXN(decimal self) => new MXN(self);
    }
}