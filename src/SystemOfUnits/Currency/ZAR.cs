using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a South African rand (code: ZAR and symbol R)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("R {Value}")]
    public readonly partial struct ZAR : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<ZAR>,
        IComparable,
        IComparable<ZAR> {
        public const string Symbol = "R";

        public ZAR(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(ZAR other) => Value == other.Value;

        public int CompareTo(ZAR other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case ZAR other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(ZAR)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "R {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is ZAR other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"R {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new ZAR(Value);

        public static bool operator ==(ZAR self, ZAR other) => self.Equals(other);
        public static bool operator !=(ZAR self, ZAR other) => !self.Equals(other);

        public static bool operator <(ZAR self, ZAR other) => self.CompareTo(other) < 0;
        public static bool operator >(ZAR self, ZAR other) => self.CompareTo(other) > 0;
        public static bool operator <=(ZAR self, ZAR other) => self.CompareTo(other) <= 0;
        public static bool operator >=(ZAR self, ZAR other) => self.CompareTo(other) >= 0;

        public static ZAR operator +(ZAR self, ZAR other) => new ZAR(self.Value + other.Value);
        public static ZAR operator -(ZAR self, ZAR other) => new ZAR(self.Value - other.Value);

        public static ZAR operator *(ZAR self, decimal other) => new ZAR(self.Value * other);
        public static ZAR operator *(decimal self, ZAR other) => new ZAR(self * other.Value);

        public static ZAR operator /(ZAR self, decimal other) => new ZAR(self.Value / other);

        public static explicit operator decimal(ZAR self) => self.Value;
        public static explicit operator ZAR(decimal self) => new ZAR(self);
    }
}