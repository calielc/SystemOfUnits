using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Turkish lira (code: TRY and symbol ₺)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("₺ {Value}")]
    public readonly partial struct TRY : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<TRY>,
        IComparable,
        IComparable<TRY> {
        public const string Symbol = "₺";

        public TRY(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(TRY other) => Value == other.Value;

        public int CompareTo(TRY other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case TRY other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(TRY)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "₺ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is TRY other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"₺ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new TRY(Value);

        public static bool operator ==(TRY self, TRY other) => self.Equals(other);
        public static bool operator !=(TRY self, TRY other) => !self.Equals(other);

        public static bool operator <(TRY self, TRY other) => self.CompareTo(other) < 0;
        public static bool operator >(TRY self, TRY other) => self.CompareTo(other) > 0;
        public static bool operator <=(TRY self, TRY other) => self.CompareTo(other) <= 0;
        public static bool operator >=(TRY self, TRY other) => self.CompareTo(other) >= 0;

        public static TRY operator +(TRY self, TRY other) => new TRY(self.Value + other.Value);
        public static TRY operator -(TRY self, TRY other) => new TRY(self.Value - other.Value);

        public static TRY operator *(TRY self, decimal other) => new TRY(self.Value * other);
        public static TRY operator *(decimal self, TRY other) => new TRY(self * other.Value);

        public static TRY operator /(TRY self, decimal other) => new TRY(self.Value / other);

        public static explicit operator decimal(TRY self) => self.Value;
        public static explicit operator TRY(decimal self) => new TRY(self);
    }
}