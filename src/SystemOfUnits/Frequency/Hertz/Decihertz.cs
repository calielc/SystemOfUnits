using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dHz")]
    public readonly partial struct Decihertz : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decihertz>,
        IComparable,
        IComparable<Decihertz> {
        public const string Symbol = "dHz";

        public Decihertz(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decihertz other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decihertz other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decihertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decihertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dHz", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decihertz other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dHz";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decihertz(Value);

        public static bool operator ==(Decihertz self, Decihertz other) => self.Equals(other);
        public static bool operator !=(Decihertz self, Decihertz other) => !self.Equals(other);

        public static bool operator <(Decihertz self, Decihertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Decihertz self, Decihertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decihertz self, Decihertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decihertz self, Decihertz other) => self.CompareTo(other) >= 0;

        public static Decihertz operator +(Decihertz self, Decihertz other) => new Decihertz(self.Value + other.Value);
        public static Decihertz operator -(Decihertz self, Decihertz other) => new Decihertz(self.Value - other.Value);

        public static Decihertz operator *(Decihertz self, double other) => new Decihertz(self.Value * other);
        public static Decihertz operator *(double self, Decihertz other) => new Decihertz(self * other.Value);

        public static Decihertz operator /(Decihertz self, double other) => new Decihertz(self.Value / other);

        public static explicit operator double(Decihertz self) => self.Value;
        public static explicit operator Decihertz(double self) => new Decihertz(self);
    }
}