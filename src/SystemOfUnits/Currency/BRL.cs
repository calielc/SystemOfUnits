using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Brazilian real (code: BRL and symbol R$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("R$ {Value}")]
    public readonly partial struct BRL : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<BRL>,
        IComparable,
        IComparable<BRL> {
        public const string Symbol = "R$";

        public BRL(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(BRL other) => Value == other.Value;

        public int CompareTo(BRL other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case BRL other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(BRL)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "R$ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is BRL other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"R$ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new BRL(Value);

        public static bool operator ==(BRL self, BRL other) => self.Equals(other);
        public static bool operator !=(BRL self, BRL other) => !self.Equals(other);

        public static bool operator <(BRL self, BRL other) => self.CompareTo(other) < 0;
        public static bool operator >(BRL self, BRL other) => self.CompareTo(other) > 0;
        public static bool operator <=(BRL self, BRL other) => self.CompareTo(other) <= 0;
        public static bool operator >=(BRL self, BRL other) => self.CompareTo(other) >= 0;

        public static BRL operator +(BRL self, BRL other) => new BRL(self.Value + other.Value);
        public static BRL operator -(BRL self, BRL other) => new BRL(self.Value - other.Value);

        public static BRL operator *(BRL self, decimal other) => new BRL(self.Value * other);
        public static BRL operator *(decimal self, BRL other) => new BRL(self * other.Value);

        public static BRL operator /(BRL self, decimal other) => new BRL(self.Value / other);

        public static explicit operator decimal(BRL self) => self.Value;
        public static explicit operator BRL(decimal self) => new BRL(self);
    }
}