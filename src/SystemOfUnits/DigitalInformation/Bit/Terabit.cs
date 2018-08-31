using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Terabit (symbol Tb).
    /// It is a multiple of the unit <c>Bit</c>, where:
    /// - 1 Terabit = 1,000 Gigabit
    /// - 1 Terabit = 10^12 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Tb")]
    public readonly partial struct Terabit : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Terabit>,
        IComparable,
        IComparable<Terabit> {
        public const string Symbol = "Tb";

        public Terabit(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Terabit other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Terabit other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Terabit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Terabit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Tb", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Terabit other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Tb";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Terabit(Value);

        public static bool operator ==(Terabit self, Terabit other) => self.Equals(other);
        public static bool operator !=(Terabit self, Terabit other) => !self.Equals(other);

        public static bool operator <(Terabit self, Terabit other) => self.CompareTo(other) < 0;
        public static bool operator >(Terabit self, Terabit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Terabit self, Terabit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Terabit self, Terabit other) => self.CompareTo(other) >= 0;

        public static Terabit operator +(Terabit self, Terabit other) => new Terabit(self.Value + other.Value);
        public static Terabit operator -(Terabit self, Terabit other) => new Terabit(self.Value - other.Value);

        public static Terabit operator *(Terabit self, double other) => new Terabit(self.Value * other);
        public static Terabit operator *(double self, Terabit other) => new Terabit(self * other.Value);

        public static Terabit operator /(Terabit self, double other) => new Terabit(self.Value / other);

        public static explicit operator double(Terabit self) => self.Value;
        public static explicit operator Terabit(double self) => new Terabit(self);
    }
}