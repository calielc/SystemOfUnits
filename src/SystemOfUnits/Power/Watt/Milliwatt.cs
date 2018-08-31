using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mW")]
    public readonly partial struct Milliwatt : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Milliwatt>,
        IComparable,
        IComparable<Milliwatt> {
        public const string Symbol = "mW";

        public Milliwatt(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Milliwatt other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Milliwatt other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Milliwatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Milliwatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mW", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Milliwatt other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mW";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Milliwatt(Value);

        public static bool operator ==(Milliwatt self, Milliwatt other) => self.Equals(other);
        public static bool operator !=(Milliwatt self, Milliwatt other) => !self.Equals(other);

        public static bool operator <(Milliwatt self, Milliwatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Milliwatt self, Milliwatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Milliwatt self, Milliwatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Milliwatt self, Milliwatt other) => self.CompareTo(other) >= 0;

        public static Milliwatt operator +(Milliwatt self, Milliwatt other) => new Milliwatt(self.Value + other.Value);
        public static Milliwatt operator -(Milliwatt self, Milliwatt other) => new Milliwatt(self.Value - other.Value);

        public static Milliwatt operator *(Milliwatt self, double other) => new Milliwatt(self.Value * other);
        public static Milliwatt operator *(double self, Milliwatt other) => new Milliwatt(self * other.Value);

        public static Milliwatt operator /(Milliwatt self, double other) => new Milliwatt(self.Value / other);

        public static explicit operator double(Milliwatt self) => self.Value;
        public static explicit operator Milliwatt(double self) => new Milliwatt(self);
    }
}