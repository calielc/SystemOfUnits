using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Japonese yen (code: JPY and symbol ¥)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("¥ {Value}")]
    public readonly partial struct JPY : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<JPY>,
        IComparable,
        IComparable<JPY> {
        public const string Symbol = "¥";

        public JPY(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(JPY other) => Value == other.Value;

        public int CompareTo(JPY other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case JPY other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(JPY)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "¥ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is JPY other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"¥ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new JPY(Value);

        public static bool operator ==(JPY self, JPY other) => self.Equals(other);
        public static bool operator !=(JPY self, JPY other) => !self.Equals(other);

        public static bool operator <(JPY self, JPY other) => self.CompareTo(other) < 0;
        public static bool operator >(JPY self, JPY other) => self.CompareTo(other) > 0;
        public static bool operator <=(JPY self, JPY other) => self.CompareTo(other) <= 0;
        public static bool operator >=(JPY self, JPY other) => self.CompareTo(other) >= 0;

        public static JPY operator +(JPY self, JPY other) => new JPY(self.Value + other.Value);
        public static JPY operator -(JPY self, JPY other) => new JPY(self.Value - other.Value);

        public static JPY operator *(JPY self, decimal other) => new JPY(self.Value * other);
        public static JPY operator *(decimal self, JPY other) => new JPY(self * other.Value);

        public static JPY operator /(JPY self, decimal other) => new JPY(self.Value / other);

        public static explicit operator decimal(JPY self) => self.Value;
        public static explicit operator JPY(decimal self) => new JPY(self);
    }
}