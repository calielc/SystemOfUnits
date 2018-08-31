using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} daW")]
    public readonly partial struct Decawatt : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decawatt>,
        IComparable,
        IComparable<Decawatt> {
        public const string Symbol = "daW";

        public Decawatt(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decawatt other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decawatt other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decawatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decawatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} daW", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decawatt other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} daW";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decawatt(Value);

        public static bool operator ==(Decawatt self, Decawatt other) => self.Equals(other);
        public static bool operator !=(Decawatt self, Decawatt other) => !self.Equals(other);

        public static bool operator <(Decawatt self, Decawatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Decawatt self, Decawatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decawatt self, Decawatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decawatt self, Decawatt other) => self.CompareTo(other) >= 0;

        public static Decawatt operator +(Decawatt self, Decawatt other) => new Decawatt(self.Value + other.Value);
        public static Decawatt operator -(Decawatt self, Decawatt other) => new Decawatt(self.Value - other.Value);

        public static Decawatt operator *(Decawatt self, double other) => new Decawatt(self.Value * other);
        public static Decawatt operator *(double self, Decawatt other) => new Decawatt(self * other.Value);

        public static Decawatt operator /(Decawatt self, double other) => new Decawatt(self.Value / other);

        public static explicit operator double(Decawatt self) => self.Value;
        public static explicit operator Decawatt(double self) => new Decawatt(self);
    }
}