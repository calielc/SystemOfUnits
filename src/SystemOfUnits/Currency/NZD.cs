using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a New Zealand dollar (code: NZD and symbol NZ$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("NZ$ {Value}")]
    public readonly partial struct NZD : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<NZD>,
        IComparable,
        IComparable<NZD> {
        public const string Symbol = "NZ$";

        public NZD(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(NZD other) => Value == other.Value;

        public int CompareTo(NZD other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case NZD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(NZD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "NZ$ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is NZD other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"NZ$ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new NZD(Value);

        public static bool operator ==(NZD self, NZD other) => self.Equals(other);
        public static bool operator !=(NZD self, NZD other) => !self.Equals(other);

        public static bool operator <(NZD self, NZD other) => self.CompareTo(other) < 0;
        public static bool operator >(NZD self, NZD other) => self.CompareTo(other) > 0;
        public static bool operator <=(NZD self, NZD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(NZD self, NZD other) => self.CompareTo(other) >= 0;

        public static NZD operator +(NZD self, NZD other) => new NZD(self.Value + other.Value);
        public static NZD operator -(NZD self, NZD other) => new NZD(self.Value - other.Value);

        public static NZD operator *(NZD self, decimal other) => new NZD(self.Value * other);
        public static NZD operator *(decimal self, NZD other) => new NZD(self * other.Value);

        public static NZD operator /(NZD self, decimal other) => new NZD(self.Value / other);

        public static explicit operator decimal(NZD self) => self.Value;
        public static explicit operator NZD(decimal self) => new NZD(self);
    }
}