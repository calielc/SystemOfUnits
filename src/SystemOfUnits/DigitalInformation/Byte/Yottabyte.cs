using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Yottabyte (symbol YB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Yottabyte = 1,000 Zettabytes
    /// - 1 Yottabyte = 10^24 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} YB")]
    public readonly partial struct Yottabyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Yottabyte>,
        IComparable,
        IComparable<Yottabyte> {
        public const string Symbol = "YB";

        public Yottabyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Yottabyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Yottabyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Yottabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Yottabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} YB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Yottabyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} YB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Yottabyte(Value);

        public static bool operator ==(Yottabyte self, Yottabyte other) => self.Equals(other);
        public static bool operator !=(Yottabyte self, Yottabyte other) => !self.Equals(other);

        public static bool operator <(Yottabyte self, Yottabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Yottabyte self, Yottabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Yottabyte self, Yottabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Yottabyte self, Yottabyte other) => self.CompareTo(other) >= 0;

        public static Yottabyte operator +(Yottabyte self, Yottabyte other) => new Yottabyte(self.Value + other.Value);
        public static Yottabyte operator -(Yottabyte self, Yottabyte other) => new Yottabyte(self.Value - other.Value);

        public static Yottabyte operator *(Yottabyte self, double other) => new Yottabyte(self.Value * other);
        public static Yottabyte operator *(double self, Yottabyte other) => new Yottabyte(self * other.Value);

        public static Yottabyte operator /(Yottabyte self, double other) => new Yottabyte(self.Value / other);

        public static explicit operator double(Yottabyte self) => self.Value;
        public static explicit operator Yottabyte(double self) => new Yottabyte(self);
    }
}