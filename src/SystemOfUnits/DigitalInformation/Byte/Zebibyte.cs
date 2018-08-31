using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Zebibyte (symbol ZiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Zebibyte = 1,024 Exbibytes
    /// - 1 Zebibyte = 1024^7 or 2^70 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} ZiB")]
    public readonly partial struct Zebibyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Zebibyte>,
        IComparable,
        IComparable<Zebibyte> {
        public const string Symbol = "ZiB";

        public Zebibyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Zebibyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Zebibyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Zebibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Zebibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} ZiB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Zebibyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} ZiB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Zebibyte(Value);

        public static bool operator ==(Zebibyte self, Zebibyte other) => self.Equals(other);
        public static bool operator !=(Zebibyte self, Zebibyte other) => !self.Equals(other);

        public static bool operator <(Zebibyte self, Zebibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Zebibyte self, Zebibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Zebibyte self, Zebibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Zebibyte self, Zebibyte other) => self.CompareTo(other) >= 0;

        public static Zebibyte operator +(Zebibyte self, Zebibyte other) => new Zebibyte(self.Value + other.Value);
        public static Zebibyte operator -(Zebibyte self, Zebibyte other) => new Zebibyte(self.Value - other.Value);

        public static Zebibyte operator *(Zebibyte self, double other) => new Zebibyte(self.Value * other);
        public static Zebibyte operator *(double self, Zebibyte other) => new Zebibyte(self * other.Value);

        public static Zebibyte operator /(Zebibyte self, double other) => new Zebibyte(self.Value / other);

        public static explicit operator double(Zebibyte self) => self.Value;
        public static explicit operator Zebibyte(double self) => new Zebibyte(self);
    }
}