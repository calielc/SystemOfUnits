using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Mebibyte (symbol MiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Mebibyte = 1,024 Kibibytes
    /// - 1 Mebibyte = 1024^2 or 2^20 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} MiB")]
    public readonly partial struct Mebibyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Mebibyte>,
        IComparable,
        IComparable<Mebibyte> {
        public const string Symbol = "MiB";

        public Mebibyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Mebibyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Mebibyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Mebibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Mebibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} MiB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Mebibyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} MiB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Mebibyte(Value);

        public static bool operator ==(Mebibyte self, Mebibyte other) => self.Equals(other);
        public static bool operator !=(Mebibyte self, Mebibyte other) => !self.Equals(other);

        public static bool operator <(Mebibyte self, Mebibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Mebibyte self, Mebibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Mebibyte self, Mebibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Mebibyte self, Mebibyte other) => self.CompareTo(other) >= 0;

        public static Mebibyte operator +(Mebibyte self, Mebibyte other) => new Mebibyte(self.Value + other.Value);
        public static Mebibyte operator -(Mebibyte self, Mebibyte other) => new Mebibyte(self.Value - other.Value);

        public static Mebibyte operator *(Mebibyte self, double other) => new Mebibyte(self.Value * other);
        public static Mebibyte operator *(double self, Mebibyte other) => new Mebibyte(self * other.Value);

        public static Mebibyte operator /(Mebibyte self, double other) => new Mebibyte(self.Value / other);

        public static explicit operator double(Mebibyte self) => self.Value;
        public static explicit operator Mebibyte(double self) => new Mebibyte(self);
    }
}