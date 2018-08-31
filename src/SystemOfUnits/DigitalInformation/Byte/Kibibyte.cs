using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Kibibyte (symbol KiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Kibibyte = 1,024 bytes
    /// - 1 Kibibyte = 1024^1 or 2^10 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} KiB")]
    public readonly partial struct Kibibyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kibibyte>,
        IComparable,
        IComparable<Kibibyte> {
        public const string Symbol = "KiB";

        public Kibibyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kibibyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kibibyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kibibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kibibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} KiB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kibibyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} KiB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kibibyte(Value);

        public static bool operator ==(Kibibyte self, Kibibyte other) => self.Equals(other);
        public static bool operator !=(Kibibyte self, Kibibyte other) => !self.Equals(other);

        public static bool operator <(Kibibyte self, Kibibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Kibibyte self, Kibibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kibibyte self, Kibibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kibibyte self, Kibibyte other) => self.CompareTo(other) >= 0;

        public static Kibibyte operator +(Kibibyte self, Kibibyte other) => new Kibibyte(self.Value + other.Value);
        public static Kibibyte operator -(Kibibyte self, Kibibyte other) => new Kibibyte(self.Value - other.Value);

        public static Kibibyte operator *(Kibibyte self, double other) => new Kibibyte(self.Value * other);
        public static Kibibyte operator *(double self, Kibibyte other) => new Kibibyte(self * other.Value);

        public static Kibibyte operator /(Kibibyte self, double other) => new Kibibyte(self.Value / other);

        public static explicit operator double(Kibibyte self) => self.Value;
        public static explicit operator Kibibyte(double self) => new Kibibyte(self);
    }
}