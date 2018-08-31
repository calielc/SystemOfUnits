using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Pebibyte (symbol PiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Pebibyte = 1,024 Tebibytes
    /// - 1 Pebibyte = 1024^5 or 2^50 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} PiB")]
    public readonly partial struct Pebibyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Pebibyte>,
        IComparable,
        IComparable<Pebibyte> {
        public const string Symbol = "PiB";

        public Pebibyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Pebibyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Pebibyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Pebibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Pebibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} PiB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Pebibyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} PiB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Pebibyte(Value);

        public static bool operator ==(Pebibyte self, Pebibyte other) => self.Equals(other);
        public static bool operator !=(Pebibyte self, Pebibyte other) => !self.Equals(other);

        public static bool operator <(Pebibyte self, Pebibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Pebibyte self, Pebibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Pebibyte self, Pebibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Pebibyte self, Pebibyte other) => self.CompareTo(other) >= 0;

        public static Pebibyte operator +(Pebibyte self, Pebibyte other) => new Pebibyte(self.Value + other.Value);
        public static Pebibyte operator -(Pebibyte self, Pebibyte other) => new Pebibyte(self.Value - other.Value);

        public static Pebibyte operator *(Pebibyte self, double other) => new Pebibyte(self.Value * other);
        public static Pebibyte operator *(double self, Pebibyte other) => new Pebibyte(self * other.Value);

        public static Pebibyte operator /(Pebibyte self, double other) => new Pebibyte(self.Value / other);

        public static explicit operator double(Pebibyte self) => self.Value;
        public static explicit operator Pebibyte(double self) => new Pebibyte(self);
    }
}