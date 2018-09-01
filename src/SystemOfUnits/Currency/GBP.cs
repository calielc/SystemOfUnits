using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Pound sterling (code: GBP and symbol £)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("£ {Value}")]
    public readonly partial struct GBP : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<GBP>,
        IComparable,
        IComparable<GBP> {
        public const string Symbol = "£";

        public GBP(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(GBP other) => Value == other.Value;

        public int CompareTo(GBP other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case GBP other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(GBP)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "£ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is GBP other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"£ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new GBP(Value);

        public static bool operator ==(GBP self, GBP other) => self.Equals(other);
        public static bool operator !=(GBP self, GBP other) => !self.Equals(other);

        public static bool operator <(GBP self, GBP other) => self.CompareTo(other) < 0;
        public static bool operator >(GBP self, GBP other) => self.CompareTo(other) > 0;
        public static bool operator <=(GBP self, GBP other) => self.CompareTo(other) <= 0;
        public static bool operator >=(GBP self, GBP other) => self.CompareTo(other) >= 0;

        public static GBP operator +(GBP self, GBP other) => new GBP(self.Value + other.Value);
        public static GBP operator -(GBP self, GBP other) => new GBP(self.Value - other.Value);

        public static GBP operator *(GBP self, decimal other) => new GBP(self.Value * other);
        public static GBP operator *(decimal self, GBP other) => new GBP(self * other.Value);

        public static GBP operator /(GBP self, decimal other) => new GBP(self.Value / other);

        public static explicit operator decimal(GBP self) => self.Value;
        public static explicit operator GBP(decimal self) => new GBP(self);
    }
}