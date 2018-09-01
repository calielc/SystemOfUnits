using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Russian ruble (code: RUB and symbol ₽)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("₽ {Value}")]
    public readonly partial struct RUB : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<RUB>,
        IComparable,
        IComparable<RUB> {
        public const string Symbol = "₽";

        public RUB(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(RUB other) => Value == other.Value;

        public int CompareTo(RUB other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case RUB other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(RUB)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "₽ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is RUB other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"₽ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new RUB(Value);

        public static bool operator ==(RUB self, RUB other) => self.Equals(other);
        public static bool operator !=(RUB self, RUB other) => !self.Equals(other);

        public static bool operator <(RUB self, RUB other) => self.CompareTo(other) < 0;
        public static bool operator >(RUB self, RUB other) => self.CompareTo(other) > 0;
        public static bool operator <=(RUB self, RUB other) => self.CompareTo(other) <= 0;
        public static bool operator >=(RUB self, RUB other) => self.CompareTo(other) >= 0;

        public static RUB operator +(RUB self, RUB other) => new RUB(self.Value + other.Value);
        public static RUB operator -(RUB self, RUB other) => new RUB(self.Value - other.Value);

        public static RUB operator *(RUB self, decimal other) => new RUB(self.Value * other);
        public static RUB operator *(decimal self, RUB other) => new RUB(self * other.Value);

        public static RUB operator /(RUB self, decimal other) => new RUB(self.Value / other);

        public static explicit operator decimal(RUB self) => self.Value;
        public static explicit operator RUB(decimal self) => new RUB(self);
    }
}