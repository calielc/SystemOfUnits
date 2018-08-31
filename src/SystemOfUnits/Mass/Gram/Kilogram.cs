using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kg")]
    public readonly partial struct Kilogram : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kilogram>,
        IComparable,
        IComparable<Kilogram> {
        public const string Symbol = "kg";

        public Kilogram(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kilogram other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kilogram other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilogram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilogram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kg", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilogram other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} kg";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kilogram(Value);

        public static bool operator ==(Kilogram self, Kilogram other) => self.Equals(other);
        public static bool operator !=(Kilogram self, Kilogram other) => !self.Equals(other);

        public static bool operator <(Kilogram self, Kilogram other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilogram self, Kilogram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilogram self, Kilogram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilogram self, Kilogram other) => self.CompareTo(other) >= 0;

        public static Kilogram operator +(Kilogram self, Kilogram other) => new Kilogram(self.Value + other.Value);
        public static Kilogram operator -(Kilogram self, Kilogram other) => new Kilogram(self.Value - other.Value);

        public static Kilogram operator *(Kilogram self, double other) => new Kilogram(self.Value * other);
        public static Kilogram operator *(double self, Kilogram other) => new Kilogram(self * other.Value);

        public static Kilogram operator /(Kilogram self, double other) => new Kilogram(self.Value / other);

        public static explicit operator double(Kilogram self) => self.Value;
        public static explicit operator Kilogram(double self) => new Kilogram(self);
    }
}