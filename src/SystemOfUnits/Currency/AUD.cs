using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Australian dollar (code: AUD and symbol A$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("A$ {Value}")]
    public readonly partial struct AUD : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<AUD>,
        IComparable,
        IComparable<AUD> {
        public const string Symbol = "A$";

        public AUD(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(AUD other) => Value == other.Value;

        public int CompareTo(AUD other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case AUD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(AUD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "A$ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is AUD other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"A$ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new AUD(Value);

        public static bool operator ==(AUD self, AUD other) => self.Equals(other);
        public static bool operator !=(AUD self, AUD other) => !self.Equals(other);

        public static bool operator <(AUD self, AUD other) => self.CompareTo(other) < 0;
        public static bool operator >(AUD self, AUD other) => self.CompareTo(other) > 0;
        public static bool operator <=(AUD self, AUD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(AUD self, AUD other) => self.CompareTo(other) >= 0;

        public static AUD operator +(AUD self, AUD other) => new AUD(self.Value + other.Value);
        public static AUD operator -(AUD self, AUD other) => new AUD(self.Value - other.Value);

        public static AUD operator *(AUD self, decimal other) => new AUD(self.Value * other);
        public static AUD operator *(decimal self, AUD other) => new AUD(self * other.Value);

        public static AUD operator /(AUD self, decimal other) => new AUD(self.Value / other);

        public static explicit operator decimal(AUD self) => self.Value;
        public static explicit operator AUD(decimal self) => new AUD(self);
    }
}