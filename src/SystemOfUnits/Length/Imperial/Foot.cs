using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Imperial {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} ft")]
    public readonly partial struct Foot : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Foot>,
        IComparable,
        IComparable<Foot> {
        public const string Symbol = "ft";

        public Foot(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Foot other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Foot other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Foot other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Foot)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} ft", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Foot other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} ft";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Foot(Value);

        public static bool operator ==(Foot self, Foot other) => self.Equals(other);
        public static bool operator !=(Foot self, Foot other) => !self.Equals(other);

        public static bool operator <(Foot self, Foot other) => self.CompareTo(other) < 0;
        public static bool operator >(Foot self, Foot other) => self.CompareTo(other) > 0;
        public static bool operator <=(Foot self, Foot other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Foot self, Foot other) => self.CompareTo(other) >= 0;

        public static Foot operator +(Foot self, Foot other) => new Foot(self.Value + other.Value);
        public static Foot operator -(Foot self, Foot other) => new Foot(self.Value - other.Value);

        public static Foot operator *(Foot self, double other) => new Foot(self.Value * other);
        public static Foot operator *(double self, Foot other) => new Foot(self * other.Value);

        public static Foot operator /(Foot self, double other) => new Foot(self.Value / other);

        public static explicit operator double(Foot self) => self.Value;
        public static explicit operator Foot(double self) => new Foot(self);
    }
}