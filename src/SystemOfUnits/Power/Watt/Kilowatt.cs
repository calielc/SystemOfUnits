using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kW")]
    public readonly partial struct Kilowatt : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kilowatt>,
        IComparable,
        IComparable<Kilowatt> {
        public const string Symbol = "kW";

        public Kilowatt(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kilowatt other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kilowatt other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilowatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilowatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kW", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilowatt other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} kW";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kilowatt(Value);

        public static bool operator ==(Kilowatt self, Kilowatt other) => self.Equals(other);
        public static bool operator !=(Kilowatt self, Kilowatt other) => !self.Equals(other);

        public static bool operator <(Kilowatt self, Kilowatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilowatt self, Kilowatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilowatt self, Kilowatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilowatt self, Kilowatt other) => self.CompareTo(other) >= 0;

        public static Kilowatt operator +(Kilowatt self, Kilowatt other) => new Kilowatt(self.Value + other.Value);
        public static Kilowatt operator -(Kilowatt self, Kilowatt other) => new Kilowatt(self.Value - other.Value);

        public static Kilowatt operator *(Kilowatt self, double other) => new Kilowatt(self.Value * other);
        public static Kilowatt operator *(double self, Kilowatt other) => new Kilowatt(self * other.Value);

        public static Kilowatt operator /(Kilowatt self, double other) => new Kilowatt(self.Value / other);

        public static explicit operator double(Kilowatt self) => self.Value;
        public static explicit operator Kilowatt(double self) => new Kilowatt(self);
    }
}