using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Exbibyte (symbol EiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Exbibyte = 1,024 Pebibytes
    /// - 1 Exbibyte = 1024^6 or 2^60 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} EiB")]
    public readonly partial struct Exbibyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Exbibyte>,
        IComparable,
        IComparable<Exbibyte> {
        public const string Symbol = "EiB";

        public Exbibyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Exbibyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Exbibyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Exbibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Exbibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} EiB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Exbibyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} EiB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Exbibyte(Value);

        public static bool operator ==(Exbibyte self, Exbibyte other) => self.Equals(other);
        public static bool operator !=(Exbibyte self, Exbibyte other) => !self.Equals(other);

        public static bool operator <(Exbibyte self, Exbibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Exbibyte self, Exbibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Exbibyte self, Exbibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Exbibyte self, Exbibyte other) => self.CompareTo(other) >= 0;

        public static Exbibyte operator +(Exbibyte self, Exbibyte other) => new Exbibyte(self.Value + other.Value);
        public static Exbibyte operator -(Exbibyte self, Exbibyte other) => new Exbibyte(self.Value - other.Value);

        public static Exbibyte operator *(Exbibyte self, double other) => new Exbibyte(self.Value * other);
        public static Exbibyte operator *(double self, Exbibyte other) => new Exbibyte(self * other.Value);

        public static Exbibyte operator /(Exbibyte self, double other) => new Exbibyte(self.Value / other);

        public static explicit operator double(Exbibyte self) => self.Value;
        public static explicit operator Exbibyte(double self) => new Exbibyte(self);
    }
}