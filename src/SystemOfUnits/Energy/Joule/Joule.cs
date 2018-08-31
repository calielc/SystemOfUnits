using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} J")]
    public readonly partial struct Joule : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Joule>,
        IComparable,
        IComparable<Joule> {
        public const string Symbol = "J";

        public Joule(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Joule other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Joule other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Joule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Joule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} J", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Joule other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} J";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Joule(Value);

        public static bool operator ==(Joule self, Joule other) => self.Equals(other);
        public static bool operator !=(Joule self, Joule other) => !self.Equals(other);

        public static bool operator <(Joule self, Joule other) => self.CompareTo(other) < 0;
        public static bool operator >(Joule self, Joule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Joule self, Joule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Joule self, Joule other) => self.CompareTo(other) >= 0;

        public static Joule operator +(Joule self, Joule other) => new Joule(self.Value + other.Value);
        public static Joule operator -(Joule self, Joule other) => new Joule(self.Value - other.Value);

        public static Joule operator *(Joule self, double other) => new Joule(self.Value * other);
        public static Joule operator *(double self, Joule other) => new Joule(self * other.Value);

        public static Joule operator /(Joule self, double other) => new Joule(self.Value / other);

        public static explicit operator double(Joule self) => self.Value;
        public static explicit operator Joule(double self) => new Joule(self);
    }
}