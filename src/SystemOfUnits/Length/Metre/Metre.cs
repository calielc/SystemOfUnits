using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} m")]
    public readonly partial struct Metre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Metre>,
        IComparable,
        IComparable<Metre> {
        public const string Symbol = "m";

        public Metre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Metre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Metre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Metre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Metre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} m", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Metre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} m";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Metre(Value);

        public static bool operator ==(Metre self, Metre other) => self.Equals(other);
        public static bool operator !=(Metre self, Metre other) => !self.Equals(other);

        public static bool operator <(Metre self, Metre other) => self.CompareTo(other) < 0;
        public static bool operator >(Metre self, Metre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Metre self, Metre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Metre self, Metre other) => self.CompareTo(other) >= 0;

        public static Metre operator +(Metre self, Metre other) => new Metre(self.Value + other.Value);
        public static Metre operator -(Metre self, Metre other) => new Metre(self.Value - other.Value);

        public static Metre operator *(Metre self, double other) => new Metre(self.Value * other);
        public static Metre operator *(double self, Metre other) => new Metre(self * other.Value);

        public static Metre operator /(Metre self, double other) => new Metre(self.Value / other);

        public static explicit operator double(Metre self) => self.Value;
        public static explicit operator Metre(double self) => new Metre(self);
    }
}