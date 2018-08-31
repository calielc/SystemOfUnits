using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Gibibyte (symbol GiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Gibibyte = 1,024 Mebibytes
    /// - 1 Gibibyte = 1024^3 or 2^30 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} GiB")]
    public readonly partial struct Gibibyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Gibibyte>,
        IComparable,
        IComparable<Gibibyte> {
        public const string Symbol = "GiB";

        public Gibibyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Gibibyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Gibibyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gibibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gibibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} GiB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gibibyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} GiB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Gibibyte(Value);

        public static bool operator ==(Gibibyte self, Gibibyte other) => self.Equals(other);
        public static bool operator !=(Gibibyte self, Gibibyte other) => !self.Equals(other);

        public static bool operator <(Gibibyte self, Gibibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Gibibyte self, Gibibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gibibyte self, Gibibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gibibyte self, Gibibyte other) => self.CompareTo(other) >= 0;

        public static Gibibyte operator +(Gibibyte self, Gibibyte other) => new Gibibyte(self.Value + other.Value);
        public static Gibibyte operator -(Gibibyte self, Gibibyte other) => new Gibibyte(self.Value - other.Value);

        public static Gibibyte operator *(Gibibyte self, double other) => new Gibibyte(self.Value * other);
        public static Gibibyte operator *(double self, Gibibyte other) => new Gibibyte(self * other.Value);

        public static Gibibyte operator /(Gibibyte self, double other) => new Gibibyte(self.Value / other);

        public static explicit operator double(Gibibyte self) => self.Value;
        public static explicit operator Gibibyte(double self) => new Gibibyte(self);
    }
}