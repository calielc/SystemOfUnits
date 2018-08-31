using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} g")]
    public readonly partial struct Gram : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Gram>,
        IComparable,
        IComparable<Gram> {
        public const string Symbol = "g";

        public Gram(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Gram other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Gram other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} g", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gram other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} g";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Gram(Value);

        public static bool operator ==(Gram self, Gram other) => self.Equals(other);
        public static bool operator !=(Gram self, Gram other) => !self.Equals(other);

        public static bool operator <(Gram self, Gram other) => self.CompareTo(other) < 0;
        public static bool operator >(Gram self, Gram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gram self, Gram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gram self, Gram other) => self.CompareTo(other) >= 0;

        public static Gram operator +(Gram self, Gram other) => new Gram(self.Value + other.Value);
        public static Gram operator -(Gram self, Gram other) => new Gram(self.Value - other.Value);

        public static Gram operator *(Gram self, double other) => new Gram(self.Value * other);
        public static Gram operator *(double self, Gram other) => new Gram(self * other.Value);

        public static Gram operator /(Gram self, double other) => new Gram(self.Value / other);

        public static explicit operator double(Gram self) => self.Value;
        public static explicit operator Gram(double self) => new Gram(self);
    }
}