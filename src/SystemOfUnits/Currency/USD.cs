using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a United States dollar (code: USD and symbol US$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("US$ {Value}")]
    public readonly partial struct USD : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<USD>,
        IComparable,
        IComparable<USD> {
        public const string Symbol = "US$";

        public USD(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(USD other) => Value == other.Value;

        public int CompareTo(USD other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case USD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(USD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "US$ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is USD other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"US$ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new USD(Value);

        public static bool operator ==(USD self, USD other) => self.Equals(other);
        public static bool operator !=(USD self, USD other) => !self.Equals(other);

        public static bool operator <(USD self, USD other) => self.CompareTo(other) < 0;
        public static bool operator >(USD self, USD other) => self.CompareTo(other) > 0;
        public static bool operator <=(USD self, USD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(USD self, USD other) => self.CompareTo(other) >= 0;

        public static USD operator +(USD self, USD other) => new USD(self.Value + other.Value);
        public static USD operator -(USD self, USD other) => new USD(self.Value - other.Value);

        public static USD operator *(USD self, decimal other) => new USD(self.Value * other);
        public static USD operator *(decimal self, USD other) => new USD(self * other.Value);

        public static USD operator /(USD self, decimal other) => new USD(self.Value / other);

        public static explicit operator decimal(USD self) => self.Value;
        public static explicit operator USD(decimal self) => new USD(self);
    }
}