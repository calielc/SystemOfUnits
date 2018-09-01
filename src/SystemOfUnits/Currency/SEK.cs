using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Swedish krona (code: SEK and symbol kr)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("kr {Value}")]
    public readonly partial struct SEK : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<SEK>,
        IComparable,
        IComparable<SEK> {
        public const string Symbol = "kr";

        public SEK(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(SEK other) => Value == other.Value;

        public int CompareTo(SEK other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SEK other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SEK)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "kr {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SEK other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"kr {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new SEK(Value);

        public static bool operator ==(SEK self, SEK other) => self.Equals(other);
        public static bool operator !=(SEK self, SEK other) => !self.Equals(other);

        public static bool operator <(SEK self, SEK other) => self.CompareTo(other) < 0;
        public static bool operator >(SEK self, SEK other) => self.CompareTo(other) > 0;
        public static bool operator <=(SEK self, SEK other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SEK self, SEK other) => self.CompareTo(other) >= 0;

        public static SEK operator +(SEK self, SEK other) => new SEK(self.Value + other.Value);
        public static SEK operator -(SEK self, SEK other) => new SEK(self.Value - other.Value);

        public static SEK operator *(SEK self, decimal other) => new SEK(self.Value * other);
        public static SEK operator *(decimal self, SEK other) => new SEK(self * other.Value);

        public static SEK operator /(SEK self, decimal other) => new SEK(self.Value / other);

        public static explicit operator decimal(SEK self) => self.Value;
        public static explicit operator SEK(decimal self) => new SEK(self);
    }
}