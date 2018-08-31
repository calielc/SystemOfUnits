using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Bit (symbol b).
    /// Where:
    /// - 8 bits = 1 byte
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} b")]
    public readonly partial struct Bit : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Bit>,
        IComparable,
        IComparable<Bit> {
        public const string Symbol = "b";

        public Bit(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Bit other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Bit other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Bit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Bit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} b", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Bit other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} b";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Bit(Value);

        public static bool operator ==(Bit self, Bit other) => self.Equals(other);
        public static bool operator !=(Bit self, Bit other) => !self.Equals(other);

        public static bool operator <(Bit self, Bit other) => self.CompareTo(other) < 0;
        public static bool operator >(Bit self, Bit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Bit self, Bit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Bit self, Bit other) => self.CompareTo(other) >= 0;

        public static Bit operator +(Bit self, Bit other) => new Bit(self.Value + other.Value);
        public static Bit operator -(Bit self, Bit other) => new Bit(self.Value - other.Value);

        public static Bit operator *(Bit self, double other) => new Bit(self.Value * other);
        public static Bit operator *(double self, Bit other) => new Bit(self * other.Value);

        public static Bit operator /(Bit self, double other) => new Bit(self.Value / other);

        public static explicit operator double(Bit self) => self.Value;
        public static explicit operator Bit(double self) => new Bit(self);
    }
}