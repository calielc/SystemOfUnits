using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hHz")]
    public readonly partial struct Hectohertz : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Hectohertz>,
        IComparable,
        IComparable<Hectohertz> {
        public const string Symbol = "hHz";

        public Hectohertz(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Hectohertz other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Hectohertz other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectohertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectohertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hHz", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectohertz other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hHz";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Hectohertz(Value);

        public static bool operator ==(Hectohertz self, Hectohertz other) => self.Equals(other);
        public static bool operator !=(Hectohertz self, Hectohertz other) => !self.Equals(other);

        public static bool operator <(Hectohertz self, Hectohertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectohertz self, Hectohertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectohertz self, Hectohertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectohertz self, Hectohertz other) => self.CompareTo(other) >= 0;

        public static Hectohertz operator +(Hectohertz self, Hectohertz other) => new Hectohertz(self.Value + other.Value);
        public static Hectohertz operator -(Hectohertz self, Hectohertz other) => new Hectohertz(self.Value - other.Value);

        public static Hectohertz operator *(Hectohertz self, double other) => new Hectohertz(self.Value * other);
        public static Hectohertz operator *(double self, Hectohertz other) => new Hectohertz(self * other.Value);

        public static Hectohertz operator /(Hectohertz self, double other) => new Hectohertz(self.Value / other);

        public static explicit operator double(Hectohertz self) => self.Value;
        public static explicit operator Hectohertz(double self) => new Hectohertz(self);
    }
}