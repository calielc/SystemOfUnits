using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cW")]
    public readonly partial struct Centiwatt : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Centiwatt>,
        IComparable,
        IComparable<Centiwatt> {
        public const string Symbol = "cW";

        public Centiwatt(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Centiwatt other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Centiwatt other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centiwatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centiwatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cW", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centiwatt other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} cW";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Centiwatt(Value);

        public static bool operator ==(Centiwatt self, Centiwatt other) => self.Equals(other);
        public static bool operator !=(Centiwatt self, Centiwatt other) => !self.Equals(other);

        public static bool operator <(Centiwatt self, Centiwatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Centiwatt self, Centiwatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centiwatt self, Centiwatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centiwatt self, Centiwatt other) => self.CompareTo(other) >= 0;

        public static Centiwatt operator +(Centiwatt self, Centiwatt other) => new Centiwatt(self.Value + other.Value);
        public static Centiwatt operator -(Centiwatt self, Centiwatt other) => new Centiwatt(self.Value - other.Value);

        public static Centiwatt operator *(Centiwatt self, double other) => new Centiwatt(self.Value * other);
        public static Centiwatt operator *(double self, Centiwatt other) => new Centiwatt(self * other.Value);

        public static Centiwatt operator /(Centiwatt self, double other) => new Centiwatt(self.Value / other);

        public static explicit operator double(Centiwatt self) => self.Value;
        public static explicit operator Centiwatt(double self) => new Centiwatt(self);
    }
}