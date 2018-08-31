using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Yobibyte (symbol YiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Yobibyte = 1,024 Zebibytes
    /// - 1 Yobibyte = 1024^8 or 2^80 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} YiB")]
    public readonly partial struct Yobibyte : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Yobibyte>,
        IComparable,
        IComparable<Yobibyte> {
        public const string Symbol = "YiB";

        public Yobibyte(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Yobibyte other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Yobibyte other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Yobibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Yobibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} YiB", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Yobibyte other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} YiB";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Yobibyte(Value);

        public static bool operator ==(Yobibyte self, Yobibyte other) => self.Equals(other);
        public static bool operator !=(Yobibyte self, Yobibyte other) => !self.Equals(other);

        public static bool operator <(Yobibyte self, Yobibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Yobibyte self, Yobibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Yobibyte self, Yobibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Yobibyte self, Yobibyte other) => self.CompareTo(other) >= 0;

        public static Yobibyte operator +(Yobibyte self, Yobibyte other) => new Yobibyte(self.Value + other.Value);
        public static Yobibyte operator -(Yobibyte self, Yobibyte other) => new Yobibyte(self.Value - other.Value);

        public static Yobibyte operator *(Yobibyte self, double other) => new Yobibyte(self.Value * other);
        public static Yobibyte operator *(double self, Yobibyte other) => new Yobibyte(self * other.Value);

        public static Yobibyte operator /(Yobibyte self, double other) => new Yobibyte(self.Value / other);

        public static explicit operator double(Yobibyte self) => self.Value;
        public static explicit operator Yobibyte(double self) => new Yobibyte(self);
    }
}