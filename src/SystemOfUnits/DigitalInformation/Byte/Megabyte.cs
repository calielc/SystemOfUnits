using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Megabyte (symbol MB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Megabyte = 1,000 Kilobytes
    /// - 1 Megabyte = 10^6 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} MB")]
    public readonly partial struct Megabyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Megabyte>,
        IComparable,
        IComparable<Megabyte> {
        public const string Symbol = "MB";

        public Megabyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Megabyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Megabyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Megabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Megabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} MB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Megabyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} MB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Megabyte(Value);

        public static bool operator ==(Megabyte self, Megabyte other) => self.Equals(other);
        public static bool operator !=(Megabyte self, Megabyte other) => !self.Equals(other);

        public static bool operator <(Megabyte self, Megabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Megabyte self, Megabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Megabyte self, Megabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Megabyte self, Megabyte other) => self.CompareTo(other) >= 0;

        public static Megabyte operator +(Megabyte self, Megabyte other) => new Megabyte(self.Value + other.Value);
        public static Megabyte operator -(Megabyte self, Megabyte other) => new Megabyte(self.Value - other.Value);

        public static Megabyte operator *(Megabyte self, double other) => new Megabyte(self.Value * other);
        public static Megabyte operator *(double self, Megabyte other) => new Megabyte(self * other.Value);

        public static Megabyte operator /(Megabyte self, double other) => new Megabyte(self.Value / other);

        public static explicit operator double(Megabyte self) => self.Value;
        public static explicit operator Megabyte(double self) => new Megabyte(self);
    }
}