using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kHz")]
    public readonly partial struct Kilohertz : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kilohertz>,
        IComparable,
        IComparable<Kilohertz> {
        public const string Symbol = "kHz";

        public Kilohertz(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kilohertz other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kilohertz other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilohertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilohertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kHz", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilohertz other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} kHz";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kilohertz(Value);

        public static bool operator ==(Kilohertz self, Kilohertz other) => self.Equals(other);
        public static bool operator !=(Kilohertz self, Kilohertz other) => !self.Equals(other);

        public static bool operator <(Kilohertz self, Kilohertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilohertz self, Kilohertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilohertz self, Kilohertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilohertz self, Kilohertz other) => self.CompareTo(other) >= 0;

        public static Kilohertz operator +(Kilohertz self, Kilohertz other) => new Kilohertz(self.Value + other.Value);
        public static Kilohertz operator -(Kilohertz self, Kilohertz other) => new Kilohertz(self.Value - other.Value);

        public static Kilohertz operator *(Kilohertz self, double other) => new Kilohertz(self.Value * other);
        public static Kilohertz operator *(double self, Kilohertz other) => new Kilohertz(self * other.Value);

        public static Kilohertz operator /(Kilohertz self, double other) => new Kilohertz(self.Value / other);

        public static explicit operator double(Kilohertz self) => self.Value;
        public static explicit operator Kilohertz(double self) => new Kilohertz(self);
    }
}