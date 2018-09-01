using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Mexican peso (code: MXN and symbol $)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("$ {Value}")]
    public readonly partial struct MXN : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<MXN>,
        IComparable,
        IComparable<MXN> {
        public const string Symbol = "$";

        public MXN(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(MXN other) => Value == other.Value;

        public int CompareTo(MXN other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case MXN other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(MXN)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "$ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is MXN other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"$ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new MXN(Value);

        public static bool operator ==(MXN self, MXN other) => self.Equals(other);
        public static bool operator !=(MXN self, MXN other) => !self.Equals(other);

        public static bool operator <(MXN self, MXN other) => self.CompareTo(other) < 0;
        public static bool operator >(MXN self, MXN other) => self.CompareTo(other) > 0;
        public static bool operator <=(MXN self, MXN other) => self.CompareTo(other) <= 0;
        public static bool operator >=(MXN self, MXN other) => self.CompareTo(other) >= 0;

        public static MXN operator +(MXN self, MXN other) => new MXN(self.Value + other.Value);
        public static MXN operator -(MXN self, MXN other) => new MXN(self.Value - other.Value);

        public static MXN operator *(MXN self, decimal other) => new MXN(self.Value * other);
        public static MXN operator *(decimal self, MXN other) => new MXN(self * other.Value);

        public static MXN operator /(MXN self, decimal other) => new MXN(self.Value / other);

        public static explicit operator decimal(MXN self) => self.Value;
        public static explicit operator MXN(decimal self) => new MXN(self);
    }
}