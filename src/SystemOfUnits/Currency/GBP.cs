using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Pound sterling (code: GBP and symbol £)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("£ {Value}")]
    public readonly partial struct GBP : ICurrency, IEquatable<GBP>, IComparable<GBP> {
        private readonly decimal _value;

        public const string Symbol = "£";

        public GBP(decimal value) {
            _value = value;
        }

        public decimal Value => _value;

        public GBP Ceiling() => new GBP(Math.Ceiling(_value));

        public GBP Round() => new GBP(Math.Round(_value));
        public GBP Round(int digits) => new GBP(Math.Round(_value, digits));
        public GBP Round(MidpointRounding mode) => new GBP(Math.Round(_value, mode));

        public GBP Floor() => new GBP(Math.Floor(_value));

        public GBP Truncate() => new GBP(Math.Truncate(_value));

        public GBP Abs() => new GBP(Math.Abs(_value));

        public bool Equals(GBP other) => this._value == other._value;

        public int CompareTo(GBP other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case GBP other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(GBP)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "£ {0}", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is GBP other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"£ {_value:#,##0.00}";

        string ICurrency.Symbol => Symbol;

        public static bool operator ==(GBP self, GBP other) => self.Equals(other);
        public static bool operator !=(GBP self, GBP other) => !self.Equals(other);

        public static bool operator <(GBP self, GBP other) => self.CompareTo(other) < 0;
        public static bool operator >(GBP self, GBP other) => self.CompareTo(other) > 0;
        public static bool operator <=(GBP self, GBP other) => self.CompareTo(other) <= 0;
        public static bool operator >=(GBP self, GBP other) => self.CompareTo(other) >= 0;

        public static GBP operator +(GBP self, GBP other) => new GBP(self._value + other._value);
        public static GBP operator -(GBP self, GBP other) => new GBP(self._value - other._value);

        public static GBP operator *(GBP self, decimal other) => new GBP(self._value * other);
        public static GBP operator *(decimal self, GBP other) => new GBP(self * other._value);

        public static GBP operator /(GBP self, decimal other) => new GBP(self._value / other);

        public static explicit operator decimal(GBP self) => self._value;
        public static explicit operator GBP(decimal self) => new GBP(self);
    }
}