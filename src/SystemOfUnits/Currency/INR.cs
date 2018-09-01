using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Indian rupee (code: INR and symbol ₹)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("₹ {Value}")]
    public readonly partial struct INR : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<INR>,
        IComparable,
        IComparable<INR> {
        public const string Symbol = "₹";

        public INR(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(INR other) => Value == other.Value;

        public int CompareTo(INR other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case INR other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(INR)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "₹ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is INR other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"₹ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new INR(Value);

        public static bool operator ==(INR self, INR other) => self.Equals(other);
        public static bool operator !=(INR self, INR other) => !self.Equals(other);

        public static bool operator <(INR self, INR other) => self.CompareTo(other) < 0;
        public static bool operator >(INR self, INR other) => self.CompareTo(other) > 0;
        public static bool operator <=(INR self, INR other) => self.CompareTo(other) <= 0;
        public static bool operator >=(INR self, INR other) => self.CompareTo(other) >= 0;

        public static INR operator +(INR self, INR other) => new INR(self.Value + other.Value);
        public static INR operator -(INR self, INR other) => new INR(self.Value - other.Value);

        public static INR operator *(INR self, decimal other) => new INR(self.Value * other);
        public static INR operator *(decimal self, INR other) => new INR(self * other.Value);

        public static INR operator /(INR self, decimal other) => new INR(self.Value / other);

        public static explicit operator decimal(INR self) => self.Value;
        public static explicit operator INR(decimal self) => new INR(self);
    }
}