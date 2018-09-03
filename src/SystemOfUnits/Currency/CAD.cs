using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Canadian dollar (code: CAD and symbol C$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("C$ {Value}")]
    public readonly partial struct CAD : ICurrency, IEquatable<CAD>, IComparable<CAD> {
        private readonly decimal _value;

        public const string Symbol = "C$";

        public CAD(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public CAD Ceiling() => new CAD(Math.Ceiling(_value));

        public CAD Round() => new CAD(Math.Round(_value));
        public CAD Round(int digits) => new CAD(Math.Round(_value, digits));
        public CAD Round(MidpointRounding mode) => new CAD(Math.Round(_value, mode));

        public CAD Floor() => new CAD(Math.Floor(_value));

        public CAD Truncate() => new CAD(Math.Truncate(_value));

        public CAD Abs() => new CAD(Math.Abs(_value));

        public bool Equals(CAD other) => this._value == other._value;

        public int CompareTo(CAD other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CAD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CAD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "C$ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CAD other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"C$ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(CAD self, CAD other) => self.Equals(other);
        public static bool operator !=(CAD self, CAD other) => !self.Equals(other);

        public static bool operator <(CAD self, CAD other) => self.CompareTo(other) < 0;
        public static bool operator >(CAD self, CAD other) => self.CompareTo(other) > 0;
        public static bool operator <=(CAD self, CAD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CAD self, CAD other) => self.CompareTo(other) >= 0;

        public static CAD operator +(CAD self, CAD other) => new CAD(self._value + other._value);
        public static CAD operator -(CAD self, CAD other) => new CAD(self._value - other._value);

        public static CAD operator *(CAD self, decimal other) => new CAD(self._value * other);
        public static CAD operator *(decimal self, CAD other) => new CAD(self * other._value);

        public static CAD operator /(CAD self, decimal other) => new CAD(self._value / other);

        public static explicit operator decimal(CAD self) => self._value;
        public static explicit operator CAD(decimal self) => new CAD(self);
    }
}