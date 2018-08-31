using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Kilobit (symbol Kb).
    /// It is a multiple of the unit <c>Bit</c>, where:
    /// - 1 Kilobit = 1,000 Bits
    /// - 1 Kilobit = 10^3 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Kb")]
    public readonly partial struct Kilobit : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kilobit>,
        IComparable,
        IComparable<Kilobit> {
        public const string Symbol = "Kb";

        public Kilobit(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kilobit other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kilobit other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilobit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilobit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Kb", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilobit other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Kb";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kilobit(Value);

        public static bool operator ==(Kilobit self, Kilobit other) => self.Equals(other);
        public static bool operator !=(Kilobit self, Kilobit other) => !self.Equals(other);

        public static bool operator <(Kilobit self, Kilobit other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilobit self, Kilobit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilobit self, Kilobit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilobit self, Kilobit other) => self.CompareTo(other) >= 0;

        public static Kilobit operator +(Kilobit self, Kilobit other) => new Kilobit(self.Value + other.Value);
        public static Kilobit operator -(Kilobit self, Kilobit other) => new Kilobit(self.Value - other.Value);

        public static Kilobit operator *(Kilobit self, double other) => new Kilobit(self.Value * other);
        public static Kilobit operator *(double self, Kilobit other) => new Kilobit(self * other.Value);

        public static Kilobit operator /(Kilobit self, double other) => new Kilobit(self.Value / other);

        public static explicit operator double(Kilobit self) => self.Value;
        public static explicit operator Kilobit(double self) => new Kilobit(self);
    }
}