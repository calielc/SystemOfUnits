using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Megabit (symbol Mb).
    /// It is a multiple of the unit <c>Bit</c>, where:
    /// - 1 Megabit = 1,000 Kilobit
    /// - 1 Megabit = 10^6 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Mb")]
    public readonly partial struct Megabit : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Megabit>,
        IComparable,
        IComparable<Megabit> {
        public const string Symbol = "Mb";

        public Megabit(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Megabit other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Megabit other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Megabit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Megabit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Mb", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Megabit other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Mb";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Megabit(Value);

        public static bool operator ==(Megabit self, Megabit other) => self.Equals(other);
        public static bool operator !=(Megabit self, Megabit other) => !self.Equals(other);

        public static bool operator <(Megabit self, Megabit other) => self.CompareTo(other) < 0;
        public static bool operator >(Megabit self, Megabit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Megabit self, Megabit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Megabit self, Megabit other) => self.CompareTo(other) >= 0;

        public static Megabit operator +(Megabit self, Megabit other) => new Megabit(self.Value + other.Value);
        public static Megabit operator -(Megabit self, Megabit other) => new Megabit(self.Value - other.Value);

        public static Megabit operator *(Megabit self, double other) => new Megabit(self.Value * other);
        public static Megabit operator *(double self, Megabit other) => new Megabit(self * other.Value);

        public static Megabit operator /(Megabit self, double other) => new Megabit(self.Value / other);

        public static explicit operator double(Megabit self) => self.Value;
        public static explicit operator Megabit(double self) => new Megabit(self);
    }
}