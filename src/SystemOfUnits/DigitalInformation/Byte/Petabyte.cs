using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Petabyte (symbol PB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Petabyte = 1,000 Terabytes
    /// - 1 Petabyte = 10^15 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} PB")]
    public readonly partial struct Petabyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Petabyte>,
        IComparable,
        IComparable<Petabyte> {
        public const string Symbol = "PB";

        public Petabyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Petabyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Petabyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Petabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Petabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} PB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Petabyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} PB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Petabyte(Value);

        public static bool operator ==(Petabyte self, Petabyte other) => self.Equals(other);
        public static bool operator !=(Petabyte self, Petabyte other) => !self.Equals(other);

        public static bool operator <(Petabyte self, Petabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Petabyte self, Petabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Petabyte self, Petabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Petabyte self, Petabyte other) => self.CompareTo(other) >= 0;

        public static Petabyte operator +(Petabyte self, Petabyte other) => new Petabyte(self.Value + other.Value);
        public static Petabyte operator -(Petabyte self, Petabyte other) => new Petabyte(self.Value - other.Value);

        public static Petabyte operator *(Petabyte self, double other) => new Petabyte(self.Value * other);
        public static Petabyte operator *(double self, Petabyte other) => new Petabyte(self * other.Value);

        public static Petabyte operator /(Petabyte self, double other) => new Petabyte(self.Value / other);

        public static explicit operator double(Petabyte self) => self.Value;
        public static explicit operator Petabyte(double self) => new Petabyte(self);
    }
}