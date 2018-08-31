using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dW")]
    public readonly partial struct Deciwatt : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Deciwatt>,
        IComparable,
        IComparable<Deciwatt> {
        public const string Symbol = "dW";

        public Deciwatt(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Deciwatt other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Deciwatt other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Deciwatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Deciwatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dW", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Deciwatt other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dW";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Deciwatt(Value);

        public static bool operator ==(Deciwatt self, Deciwatt other) => self.Equals(other);
        public static bool operator !=(Deciwatt self, Deciwatt other) => !self.Equals(other);

        public static bool operator <(Deciwatt self, Deciwatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Deciwatt self, Deciwatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Deciwatt self, Deciwatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Deciwatt self, Deciwatt other) => self.CompareTo(other) >= 0;

        public static Deciwatt operator +(Deciwatt self, Deciwatt other) => new Deciwatt(self.Value + other.Value);
        public static Deciwatt operator -(Deciwatt self, Deciwatt other) => new Deciwatt(self.Value - other.Value);

        public static Deciwatt operator *(Deciwatt self, double other) => new Deciwatt(self.Value * other);
        public static Deciwatt operator *(double self, Deciwatt other) => new Deciwatt(self * other.Value);

        public static Deciwatt operator /(Deciwatt self, double other) => new Deciwatt(self.Value / other);

        public static explicit operator double(Deciwatt self) => self.Value;
        public static explicit operator Deciwatt(double self) => new Deciwatt(self);
    }
}