using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a South Korean won (code: KRW and symbol ₩)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("₩ {Value}")]
    public readonly partial struct KRW : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<KRW>,
        IComparable,
        IComparable<KRW> {
        public const string Symbol = "₩";

        public KRW(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(KRW other) => Value == other.Value;

        public int CompareTo(KRW other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case KRW other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(KRW)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "₩ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is KRW other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"₩ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new KRW(Value);

        public static bool operator ==(KRW self, KRW other) => self.Equals(other);
        public static bool operator !=(KRW self, KRW other) => !self.Equals(other);

        public static bool operator <(KRW self, KRW other) => self.CompareTo(other) < 0;
        public static bool operator >(KRW self, KRW other) => self.CompareTo(other) > 0;
        public static bool operator <=(KRW self, KRW other) => self.CompareTo(other) <= 0;
        public static bool operator >=(KRW self, KRW other) => self.CompareTo(other) >= 0;

        public static KRW operator +(KRW self, KRW other) => new KRW(self.Value + other.Value);
        public static KRW operator -(KRW self, KRW other) => new KRW(self.Value - other.Value);

        public static KRW operator *(KRW self, decimal other) => new KRW(self.Value * other);
        public static KRW operator *(decimal self, KRW other) => new KRW(self * other.Value);

        public static KRW operator /(KRW self, decimal other) => new KRW(self.Value / other);

        public static explicit operator decimal(KRW self) => self.Value;
        public static explicit operator KRW(decimal self) => new KRW(self);
    }
}