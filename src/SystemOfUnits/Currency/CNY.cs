using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Renminbi (code: CNY and symbol 元)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("元 {Value}")]
    public readonly partial struct CNY : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<CNY>,
        IComparable,
        IComparable<CNY> {
        public const string Symbol = "元";

        public CNY(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(CNY other) => Value == other.Value;

        public int CompareTo(CNY other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CNY other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CNY)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "元 {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CNY other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"元 {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new CNY(Value);

        public static bool operator ==(CNY self, CNY other) => self.Equals(other);
        public static bool operator !=(CNY self, CNY other) => !self.Equals(other);

        public static bool operator <(CNY self, CNY other) => self.CompareTo(other) < 0;
        public static bool operator >(CNY self, CNY other) => self.CompareTo(other) > 0;
        public static bool operator <=(CNY self, CNY other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CNY self, CNY other) => self.CompareTo(other) >= 0;

        public static CNY operator +(CNY self, CNY other) => new CNY(self.Value + other.Value);
        public static CNY operator -(CNY self, CNY other) => new CNY(self.Value - other.Value);

        public static CNY operator *(CNY self, decimal other) => new CNY(self.Value * other);
        public static CNY operator *(decimal self, CNY other) => new CNY(self * other.Value);

        public static CNY operator /(CNY self, decimal other) => new CNY(self.Value / other);

        public static explicit operator decimal(CNY self) => self.Value;
        public static explicit operator CNY(decimal self) => new CNY(self);
    }
}