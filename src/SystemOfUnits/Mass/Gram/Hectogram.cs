using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hg")]
    public readonly partial struct Hectogram : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Hectogram>,
        IComparable,
        IComparable<Hectogram> {
        public const string Symbol = "hg";

        public Hectogram(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Hectogram other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Hectogram other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectogram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectogram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hg", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectogram other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hg";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Hectogram(Value);

        public static bool operator ==(Hectogram self, Hectogram other) => self.Equals(other);
        public static bool operator !=(Hectogram self, Hectogram other) => !self.Equals(other);

        public static bool operator <(Hectogram self, Hectogram other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectogram self, Hectogram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectogram self, Hectogram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectogram self, Hectogram other) => self.CompareTo(other) >= 0;

        public static Hectogram operator +(Hectogram self, Hectogram other) => new Hectogram(self.Value + other.Value);
        public static Hectogram operator -(Hectogram self, Hectogram other) => new Hectogram(self.Value - other.Value);

        public static Hectogram operator *(Hectogram self, double other) => new Hectogram(self.Value * other);
        public static Hectogram operator *(double self, Hectogram other) => new Hectogram(self * other.Value);

        public static Hectogram operator /(Hectogram self, double other) => new Hectogram(self.Value / other);

        public static explicit operator double(Hectogram self) => self.Value;
        public static explicit operator Hectogram(double self) => new Hectogram(self);
    }
}