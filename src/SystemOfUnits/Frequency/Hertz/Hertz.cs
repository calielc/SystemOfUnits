using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Hz")]
    public readonly partial struct Hertz : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Hertz>,
        IComparable,
        IComparable<Hertz> {
        public const string Symbol = "Hz";

        public Hertz(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Hertz other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Hertz other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Hz", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hertz other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Hz";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Hertz(Value);

        public static bool operator ==(Hertz self, Hertz other) => self.Equals(other);
        public static bool operator !=(Hertz self, Hertz other) => !self.Equals(other);

        public static bool operator <(Hertz self, Hertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Hertz self, Hertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hertz self, Hertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hertz self, Hertz other) => self.CompareTo(other) >= 0;

        public static Hertz operator +(Hertz self, Hertz other) => new Hertz(self.Value + other.Value);
        public static Hertz operator -(Hertz self, Hertz other) => new Hertz(self.Value - other.Value);

        public static Hertz operator *(Hertz self, double other) => new Hertz(self.Value * other);
        public static Hertz operator *(double self, Hertz other) => new Hertz(self * other.Value);

        public static Hertz operator /(Hertz self, double other) => new Hertz(self.Value / other);

        public static explicit operator double(Hertz self) => self.Value;
        public static explicit operator Hertz(double self) => new Hertz(self);
    }
}