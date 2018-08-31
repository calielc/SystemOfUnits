using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hW")]
    public readonly partial struct Hectowatt : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Hectowatt>,
        IComparable,
        IComparable<Hectowatt> {
        public const string Symbol = "hW";

        public Hectowatt(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Hectowatt other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Hectowatt other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectowatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectowatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hW", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectowatt other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hW";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Hectowatt(Value);

        public static bool operator ==(Hectowatt self, Hectowatt other) => self.Equals(other);
        public static bool operator !=(Hectowatt self, Hectowatt other) => !self.Equals(other);

        public static bool operator <(Hectowatt self, Hectowatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectowatt self, Hectowatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectowatt self, Hectowatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectowatt self, Hectowatt other) => self.CompareTo(other) >= 0;

        public static Hectowatt operator +(Hectowatt self, Hectowatt other) => new Hectowatt(self.Value + other.Value);
        public static Hectowatt operator -(Hectowatt self, Hectowatt other) => new Hectowatt(self.Value - other.Value);

        public static Hectowatt operator *(Hectowatt self, double other) => new Hectowatt(self.Value * other);
        public static Hectowatt operator *(double self, Hectowatt other) => new Hectowatt(self * other.Value);

        public static Hectowatt operator /(Hectowatt self, double other) => new Hectowatt(self.Value / other);

        public static explicit operator double(Hectowatt self) => self.Value;
        public static explicit operator Hectowatt(double self) => new Hectowatt(self);
    }
}