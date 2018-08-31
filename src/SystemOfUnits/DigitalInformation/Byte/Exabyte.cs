using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Exabyte (symbol EB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Exabyte = 1,000 Petabytes
    /// - 1 Exabyte = 10^18 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} EB")]
    public readonly partial struct Exabyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Exabyte>,
        IComparable,
        IComparable<Exabyte> {
        public const string Symbol = "EB";

        public Exabyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Exabyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Exabyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Exabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Exabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} EB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Exabyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} EB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Exabyte(Value);

        public static bool operator ==(Exabyte self, Exabyte other) => self.Equals(other);
        public static bool operator !=(Exabyte self, Exabyte other) => !self.Equals(other);

        public static bool operator <(Exabyte self, Exabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Exabyte self, Exabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Exabyte self, Exabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Exabyte self, Exabyte other) => self.CompareTo(other) >= 0;

        public static Exabyte operator +(Exabyte self, Exabyte other) => new Exabyte(self.Value + other.Value);
        public static Exabyte operator -(Exabyte self, Exabyte other) => new Exabyte(self.Value - other.Value);

        public static Exabyte operator *(Exabyte self, double other) => new Exabyte(self.Value * other);
        public static Exabyte operator *(double self, Exabyte other) => new Exabyte(self * other.Value);

        public static Exabyte operator /(Exabyte self, double other) => new Exabyte(self.Value / other);

        public static explicit operator double(Exabyte self) => self.Value;
        public static explicit operator Exabyte(double self) => new Exabyte(self);
    }
}