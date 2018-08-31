using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Byte (symbol B).
    /// Where:
    /// - 1 Byte = 8 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} B")]
    public readonly partial struct Byte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Byte>,
        IComparable,
        IComparable<Byte> {
        public const string Symbol = "B";

        public Byte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Byte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Byte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Byte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Byte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} B", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Byte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} B";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Byte(Value);

        public static bool operator ==(Byte self, Byte other) => self.Equals(other);
        public static bool operator !=(Byte self, Byte other) => !self.Equals(other);

        public static bool operator <(Byte self, Byte other) => self.CompareTo(other) < 0;
        public static bool operator >(Byte self, Byte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Byte self, Byte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Byte self, Byte other) => self.CompareTo(other) >= 0;

        public static Byte operator +(Byte self, Byte other) => new Byte(self.Value + other.Value);
        public static Byte operator -(Byte self, Byte other) => new Byte(self.Value - other.Value);

        public static Byte operator *(Byte self, double other) => new Byte(self.Value * other);
        public static Byte operator *(double self, Byte other) => new Byte(self * other.Value);

        public static Byte operator /(Byte self, double other) => new Byte(self.Value / other);

        public static explicit operator double(Byte self) => self.Value;
        public static explicit operator Byte(double self) => new Byte(self);
    }
}