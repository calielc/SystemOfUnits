using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Norwegian krone (code: NOK and symbol kr)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("kr {Value}")]
    public readonly partial struct NOK : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<NOK>,
        IComparable,
        IComparable<NOK> {
        public const string Symbol = "kr";

        public NOK(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(NOK other) => Value == other.Value;

        public int CompareTo(NOK other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case NOK other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(NOK)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "kr {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is NOK other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"kr {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new NOK(Value);

        public static bool operator ==(NOK self, NOK other) => self.Equals(other);
        public static bool operator !=(NOK self, NOK other) => !self.Equals(other);

        public static bool operator <(NOK self, NOK other) => self.CompareTo(other) < 0;
        public static bool operator >(NOK self, NOK other) => self.CompareTo(other) > 0;
        public static bool operator <=(NOK self, NOK other) => self.CompareTo(other) <= 0;
        public static bool operator >=(NOK self, NOK other) => self.CompareTo(other) >= 0;

        public static NOK operator +(NOK self, NOK other) => new NOK(self.Value + other.Value);
        public static NOK operator -(NOK self, NOK other) => new NOK(self.Value - other.Value);

        public static NOK operator *(NOK self, decimal other) => new NOK(self.Value * other);
        public static NOK operator *(decimal self, NOK other) => new NOK(self * other.Value);

        public static NOK operator /(NOK self, decimal other) => new NOK(self.Value / other);

        public static explicit operator decimal(NOK self) => self.Value;
        public static explicit operator NOK(decimal self) => new NOK(self);
    }
}