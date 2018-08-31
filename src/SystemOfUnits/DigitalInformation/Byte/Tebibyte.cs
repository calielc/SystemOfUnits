using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Tebibyte (symbol TiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Tebibyte = 1,024 Gibibytes
    /// - 1 Tebibyte = 1024^4 or 2^40 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} TiB")]
    public readonly partial struct Tebibyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Tebibyte>,
        IComparable,
        IComparable<Tebibyte> {
        public const string Symbol = "TiB";

        public Tebibyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Tebibyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Tebibyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Tebibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Tebibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} TiB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Tebibyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} TiB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Tebibyte(Value);

        public static bool operator ==(Tebibyte self, Tebibyte other) => self.Equals(other);
        public static bool operator !=(Tebibyte self, Tebibyte other) => !self.Equals(other);

        public static bool operator <(Tebibyte self, Tebibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Tebibyte self, Tebibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Tebibyte self, Tebibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Tebibyte self, Tebibyte other) => self.CompareTo(other) >= 0;

        public static Tebibyte operator +(Tebibyte self, Tebibyte other) => new Tebibyte(self.Value + other.Value);
        public static Tebibyte operator -(Tebibyte self, Tebibyte other) => new Tebibyte(self.Value - other.Value);

        public static Tebibyte operator *(Tebibyte self, double other) => new Tebibyte(self.Value * other);
        public static Tebibyte operator *(double self, Tebibyte other) => new Tebibyte(self * other.Value);

        public static Tebibyte operator /(Tebibyte self, double other) => new Tebibyte(self.Value / other);

        public static explicit operator double(Tebibyte self) => self.Value;
        public static explicit operator Tebibyte(double self) => new Tebibyte(self);
    }
}