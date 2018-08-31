using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Terabyte (symbol TB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Terabyte = 1,000 Gigabytes
    /// - 1 Terabyte = 10^12 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} TB")]
    public readonly partial struct Terabyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Terabyte>,
        IComparable,
        IComparable<Terabyte> {
        public const string Symbol = "TB";

        public Terabyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Terabyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Terabyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Terabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Terabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} TB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Terabyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} TB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Terabyte(Value);

        public static bool operator ==(Terabyte self, Terabyte other) => self.Equals(other);
        public static bool operator !=(Terabyte self, Terabyte other) => !self.Equals(other);

        public static bool operator <(Terabyte self, Terabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Terabyte self, Terabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Terabyte self, Terabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Terabyte self, Terabyte other) => self.CompareTo(other) >= 0;

        public static Terabyte operator +(Terabyte self, Terabyte other) => new Terabyte(self.Value + other.Value);
        public static Terabyte operator -(Terabyte self, Terabyte other) => new Terabyte(self.Value - other.Value);

        public static Terabyte operator *(Terabyte self, double other) => new Terabyte(self.Value * other);
        public static Terabyte operator *(double self, Terabyte other) => new Terabyte(self * other.Value);

        public static Terabyte operator /(Terabyte self, double other) => new Terabyte(self.Value / other);

        public static explicit operator double(Terabyte self) => self.Value;
        public static explicit operator Terabyte(double self) => new Terabyte(self);
    }
}