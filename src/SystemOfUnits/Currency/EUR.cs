using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Euro (code: EUR and symbol €)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("€ {Value}")]
    public readonly partial struct EUR : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<EUR>,
        IComparable,
        IComparable<EUR> {
        public const string Symbol = "€";

        public EUR(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(EUR other) => Value == other.Value;

        public int CompareTo(EUR other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case EUR other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(EUR)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "€ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is EUR other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"€ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new EUR(Value);

        public static bool operator ==(EUR self, EUR other) => self.Equals(other);
        public static bool operator !=(EUR self, EUR other) => !self.Equals(other);

        public static bool operator <(EUR self, EUR other) => self.CompareTo(other) < 0;
        public static bool operator >(EUR self, EUR other) => self.CompareTo(other) > 0;
        public static bool operator <=(EUR self, EUR other) => self.CompareTo(other) <= 0;
        public static bool operator >=(EUR self, EUR other) => self.CompareTo(other) >= 0;

        public static EUR operator +(EUR self, EUR other) => new EUR(self.Value + other.Value);
        public static EUR operator -(EUR self, EUR other) => new EUR(self.Value - other.Value);

        public static EUR operator *(EUR self, decimal other) => new EUR(self.Value * other);
        public static EUR operator *(decimal self, EUR other) => new EUR(self * other.Value);

        public static EUR operator /(EUR self, decimal other) => new EUR(self.Value / other);

        public static explicit operator decimal(EUR self) => self.Value;
        public static explicit operator EUR(decimal self) => new EUR(self);
    }
}