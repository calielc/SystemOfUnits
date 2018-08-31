using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mHz")]
    public readonly partial struct Millihertz : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Millihertz>,
        IComparable,
        IComparable<Millihertz> {
        public const string Symbol = "mHz";

        public Millihertz(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Millihertz other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Millihertz other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millihertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millihertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mHz", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millihertz other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mHz";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Millihertz(Value);

        public static bool operator ==(Millihertz self, Millihertz other) => self.Equals(other);
        public static bool operator !=(Millihertz self, Millihertz other) => !self.Equals(other);

        public static bool operator <(Millihertz self, Millihertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Millihertz self, Millihertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millihertz self, Millihertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millihertz self, Millihertz other) => self.CompareTo(other) >= 0;

        public static Millihertz operator +(Millihertz self, Millihertz other) => new Millihertz(self.Value + other.Value);
        public static Millihertz operator -(Millihertz self, Millihertz other) => new Millihertz(self.Value - other.Value);

        public static Millihertz operator *(Millihertz self, double other) => new Millihertz(self.Value * other);
        public static Millihertz operator *(double self, Millihertz other) => new Millihertz(self * other.Value);

        public static Millihertz operator /(Millihertz self, double other) => new Millihertz(self.Value / other);

        public static explicit operator double(Millihertz self) => self.Value;
        public static explicit operator Millihertz(double self) => new Millihertz(self);
    }
}