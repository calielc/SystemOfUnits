using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cHz")]
    public readonly partial struct Centihertz : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Centihertz>,
        IComparable,
        IComparable<Centihertz> {
        public const string Symbol = "cHz";

        public Centihertz(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Centihertz other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Centihertz other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centihertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centihertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cHz", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centihertz other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} cHz";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Centihertz(Value);

        public static bool operator ==(Centihertz self, Centihertz other) => self.Equals(other);
        public static bool operator !=(Centihertz self, Centihertz other) => !self.Equals(other);

        public static bool operator <(Centihertz self, Centihertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Centihertz self, Centihertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centihertz self, Centihertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centihertz self, Centihertz other) => self.CompareTo(other) >= 0;

        public static Centihertz operator +(Centihertz self, Centihertz other) => new Centihertz(self.Value + other.Value);
        public static Centihertz operator -(Centihertz self, Centihertz other) => new Centihertz(self.Value - other.Value);

        public static Centihertz operator *(Centihertz self, double other) => new Centihertz(self.Value * other);
        public static Centihertz operator *(double self, Centihertz other) => new Centihertz(self * other.Value);

        public static Centihertz operator /(Centihertz self, double other) => new Centihertz(self.Value / other);

        public static explicit operator double(Centihertz self) => self.Value;
        public static explicit operator Centihertz(double self) => new Centihertz(self);
    }
}