using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Kilobyte (symbol kB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Kilobyte = 1,000 Bytes
    /// -  1 Kilobyte = 10^3 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kB")]
    public readonly partial struct Kilobyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kilobyte>,
        IComparable,
        IComparable<Kilobyte> {
        public const string Symbol = "kB";

        public Kilobyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kilobyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kilobyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilobyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilobyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilobyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} kB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kilobyte(Value);

        public static bool operator ==(Kilobyte self, Kilobyte other) => self.Equals(other);
        public static bool operator !=(Kilobyte self, Kilobyte other) => !self.Equals(other);

        public static bool operator <(Kilobyte self, Kilobyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilobyte self, Kilobyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilobyte self, Kilobyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilobyte self, Kilobyte other) => self.CompareTo(other) >= 0;

        public static Kilobyte operator +(Kilobyte self, Kilobyte other) => new Kilobyte(self.Value + other.Value);
        public static Kilobyte operator -(Kilobyte self, Kilobyte other) => new Kilobyte(self.Value - other.Value);

        public static Kilobyte operator *(Kilobyte self, double other) => new Kilobyte(self.Value * other);
        public static Kilobyte operator *(double self, Kilobyte other) => new Kilobyte(self * other.Value);

        public static Kilobyte operator /(Kilobyte self, double other) => new Kilobyte(self.Value / other);

        public static explicit operator double(Kilobyte self) => self.Value;
        public static explicit operator Kilobyte(double self) => new Kilobyte(self);
    }
}