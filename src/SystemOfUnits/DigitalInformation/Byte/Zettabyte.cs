using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Zettabyte (symbol ZB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Zettabyte = 1,000 Exabytes
    /// - 1 Zettabyte = 10^21 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} ZB")]
    public readonly partial struct Zettabyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Zettabyte>,
        IComparable,
        IComparable<Zettabyte> {
        public const string Symbol = "ZB";

        public Zettabyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Zettabyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Zettabyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Zettabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Zettabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} ZB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Zettabyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} ZB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Zettabyte(Value);

        public static bool operator ==(Zettabyte self, Zettabyte other) => self.Equals(other);
        public static bool operator !=(Zettabyte self, Zettabyte other) => !self.Equals(other);

        public static bool operator <(Zettabyte self, Zettabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Zettabyte self, Zettabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Zettabyte self, Zettabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Zettabyte self, Zettabyte other) => self.CompareTo(other) >= 0;

        public static Zettabyte operator +(Zettabyte self, Zettabyte other) => new Zettabyte(self.Value + other.Value);
        public static Zettabyte operator -(Zettabyte self, Zettabyte other) => new Zettabyte(self.Value - other.Value);

        public static Zettabyte operator *(Zettabyte self, double other) => new Zettabyte(self.Value * other);
        public static Zettabyte operator *(double self, Zettabyte other) => new Zettabyte(self * other.Value);

        public static Zettabyte operator /(Zettabyte self, double other) => new Zettabyte(self.Value / other);

        public static explicit operator double(Zettabyte self) => self.Value;
        public static explicit operator Zettabyte(double self) => new Zettabyte(self);
    }
}