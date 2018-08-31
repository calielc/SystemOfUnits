using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} daHz")]
    public readonly partial struct Decahertz : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decahertz>,
        IComparable,
        IComparable<Decahertz> {
        public const string Symbol = "daHz";

        public Decahertz(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decahertz other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decahertz other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decahertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decahertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} daHz", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decahertz other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} daHz";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decahertz(Value);

        public static bool operator ==(Decahertz self, Decahertz other) => self.Equals(other);
        public static bool operator !=(Decahertz self, Decahertz other) => !self.Equals(other);

        public static bool operator <(Decahertz self, Decahertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Decahertz self, Decahertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decahertz self, Decahertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decahertz self, Decahertz other) => self.CompareTo(other) >= 0;

        public static Decahertz operator +(Decahertz self, Decahertz other) => new Decahertz(self.Value + other.Value);
        public static Decahertz operator -(Decahertz self, Decahertz other) => new Decahertz(self.Value - other.Value);

        public static Decahertz operator *(Decahertz self, double other) => new Decahertz(self.Value * other);
        public static Decahertz operator *(double self, Decahertz other) => new Decahertz(self * other.Value);

        public static Decahertz operator /(Decahertz self, double other) => new Decahertz(self.Value / other);

        public static explicit operator double(Decahertz self) => self.Value;
        public static explicit operator Decahertz(double self) => new Decahertz(self);
    }
}