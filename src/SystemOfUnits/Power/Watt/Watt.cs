using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} W")]
    public readonly partial struct Watt : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Watt>,
        IComparable,
        IComparable<Watt> {
        public const string Symbol = "W";

        public Watt(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Watt other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Watt other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Watt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Watt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} W", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Watt other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} W";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Watt(Value);

        public static bool operator ==(Watt self, Watt other) => self.Equals(other);
        public static bool operator !=(Watt self, Watt other) => !self.Equals(other);

        public static bool operator <(Watt self, Watt other) => self.CompareTo(other) < 0;
        public static bool operator >(Watt self, Watt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Watt self, Watt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Watt self, Watt other) => self.CompareTo(other) >= 0;

        public static Watt operator +(Watt self, Watt other) => new Watt(self.Value + other.Value);
        public static Watt operator -(Watt self, Watt other) => new Watt(self.Value - other.Value);

        public static Watt operator *(Watt self, double other) => new Watt(self.Value * other);
        public static Watt operator *(double self, Watt other) => new Watt(self * other.Value);

        public static Watt operator /(Watt self, double other) => new Watt(self.Value / other);

        public static explicit operator double(Watt self) => self.Value;
        public static explicit operator Watt(double self) => new Watt(self);
    }
}