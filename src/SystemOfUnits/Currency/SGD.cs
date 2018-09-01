using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Singapore dollar (code: SGD and symbol $$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("$$ {Value}")]
    public readonly partial struct SGD : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<SGD>,
        IComparable,
        IComparable<SGD> {
        public const string Symbol = "$$";

        public SGD(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(SGD other) => Value == other.Value;

        public int CompareTo(SGD other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SGD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SGD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "$$ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SGD other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"$$ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new SGD(Value);

        public static bool operator ==(SGD self, SGD other) => self.Equals(other);
        public static bool operator !=(SGD self, SGD other) => !self.Equals(other);

        public static bool operator <(SGD self, SGD other) => self.CompareTo(other) < 0;
        public static bool operator >(SGD self, SGD other) => self.CompareTo(other) > 0;
        public static bool operator <=(SGD self, SGD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SGD self, SGD other) => self.CompareTo(other) >= 0;

        public static SGD operator +(SGD self, SGD other) => new SGD(self.Value + other.Value);
        public static SGD operator -(SGD self, SGD other) => new SGD(self.Value - other.Value);

        public static SGD operator *(SGD self, decimal other) => new SGD(self.Value * other);
        public static SGD operator *(decimal self, SGD other) => new SGD(self * other.Value);

        public static SGD operator /(SGD self, decimal other) => new SGD(self.Value / other);

        public static explicit operator decimal(SGD self) => self.Value;
        public static explicit operator SGD(decimal self) => new SGD(self);
    }
}