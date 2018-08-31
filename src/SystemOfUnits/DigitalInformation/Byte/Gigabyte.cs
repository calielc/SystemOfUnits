using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Gigabyte (symbol GB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Gigabyte = 1,000 Megabytes
    /// - 1 Gigabyte = 10^9 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} GB")]
    public readonly partial struct Gigabyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Gigabyte>,
        IComparable,
        IComparable<Gigabyte> {
        public const string Symbol = "GB";

        public Gigabyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Gigabyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Gigabyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gigabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gigabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} GB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gigabyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} GB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Gigabyte(Value);

        public static bool operator ==(Gigabyte self, Gigabyte other) => self.Equals(other);
        public static bool operator !=(Gigabyte self, Gigabyte other) => !self.Equals(other);

        public static bool operator <(Gigabyte self, Gigabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Gigabyte self, Gigabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gigabyte self, Gigabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gigabyte self, Gigabyte other) => self.CompareTo(other) >= 0;

        public static Gigabyte operator +(Gigabyte self, Gigabyte other) => new Gigabyte(self.Value + other.Value);
        public static Gigabyte operator -(Gigabyte self, Gigabyte other) => new Gigabyte(self.Value - other.Value);

        public static Gigabyte operator *(Gigabyte self, double other) => new Gigabyte(self.Value * other);
        public static Gigabyte operator *(double self, Gigabyte other) => new Gigabyte(self * other.Value);

        public static Gigabyte operator /(Gigabyte self, double other) => new Gigabyte(self.Value / other);

        public static explicit operator double(Gigabyte self) => self.Value;
        public static explicit operator Gigabyte(double self) => new Gigabyte(self);
    }
}