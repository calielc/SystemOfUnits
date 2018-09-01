using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Swiss franc (code: CHF and symbol Fr)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("Fr {Value}")]
    public readonly partial struct CHF : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<CHF>,
        IComparable,
        IComparable<CHF> {
        public const string Symbol = "Fr";

        public CHF(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(CHF other) => Value == other.Value;

        public int CompareTo(CHF other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CHF other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CHF)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "Fr {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CHF other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"Fr {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new CHF(Value);

        public static bool operator ==(CHF self, CHF other) => self.Equals(other);
        public static bool operator !=(CHF self, CHF other) => !self.Equals(other);

        public static bool operator <(CHF self, CHF other) => self.CompareTo(other) < 0;
        public static bool operator >(CHF self, CHF other) => self.CompareTo(other) > 0;
        public static bool operator <=(CHF self, CHF other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CHF self, CHF other) => self.CompareTo(other) >= 0;

        public static CHF operator +(CHF self, CHF other) => new CHF(self.Value + other.Value);
        public static CHF operator -(CHF self, CHF other) => new CHF(self.Value - other.Value);

        public static CHF operator *(CHF self, decimal other) => new CHF(self.Value * other);
        public static CHF operator *(decimal self, CHF other) => new CHF(self * other.Value);

        public static CHF operator /(CHF self, decimal other) => new CHF(self.Value / other);

        public static explicit operator decimal(CHF self) => self.Value;
        public static explicit operator CHF(decimal self) => new CHF(self);
    }
}