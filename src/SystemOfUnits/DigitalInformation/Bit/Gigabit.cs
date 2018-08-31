using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Gigabit (symbol Gb).
    /// It is a multiple of the unit <c>Bit</c>, where:
    /// - 1 Gigabit = 1,000 Megabit
    /// - 1 Gigabit = 10^9 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Gb")]
    public readonly partial struct Gigabit : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Gigabit>,
        IComparable,
        IComparable<Gigabit> {
        public const string Symbol = "Gb";

        public Gigabit(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Gigabit other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Gigabit other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gigabit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gigabit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Gb", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gigabit other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Gb";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Gigabit(Value);

        public static bool operator ==(Gigabit self, Gigabit other) => self.Equals(other);
        public static bool operator !=(Gigabit self, Gigabit other) => !self.Equals(other);

        public static bool operator <(Gigabit self, Gigabit other) => self.CompareTo(other) < 0;
        public static bool operator >(Gigabit self, Gigabit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gigabit self, Gigabit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gigabit self, Gigabit other) => self.CompareTo(other) >= 0;

        public static Gigabit operator +(Gigabit self, Gigabit other) => new Gigabit(self.Value + other.Value);
        public static Gigabit operator -(Gigabit self, Gigabit other) => new Gigabit(self.Value - other.Value);

        public static Gigabit operator *(Gigabit self, double other) => new Gigabit(self.Value * other);
        public static Gigabit operator *(double self, Gigabit other) => new Gigabit(self * other.Value);

        public static Gigabit operator /(Gigabit self, double other) => new Gigabit(self.Value / other);

        public static explicit operator double(Gigabit self) => self.Value;
        public static explicit operator Gigabit(double self) => new Gigabit(self);
    }
}