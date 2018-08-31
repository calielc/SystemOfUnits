using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dag")]
    public readonly partial struct Decagram : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decagram>,
        IComparable,
        IComparable<Decagram> {
        public const string Symbol = "dag";

        public Decagram(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decagram other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decagram other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decagram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decagram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dag", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decagram other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dag";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decagram(Value);

        public static bool operator ==(Decagram self, Decagram other) => self.Equals(other);
        public static bool operator !=(Decagram self, Decagram other) => !self.Equals(other);

        public static bool operator <(Decagram self, Decagram other) => self.CompareTo(other) < 0;
        public static bool operator >(Decagram self, Decagram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decagram self, Decagram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decagram self, Decagram other) => self.CompareTo(other) >= 0;

        public static Decagram operator +(Decagram self, Decagram other) => new Decagram(self.Value + other.Value);
        public static Decagram operator -(Decagram self, Decagram other) => new Decagram(self.Value - other.Value);

        public static Decagram operator *(Decagram self, double other) => new Decagram(self.Value * other);
        public static Decagram operator *(double self, Decagram other) => new Decagram(self * other.Value);

        public static Decagram operator /(Decagram self, double other) => new Decagram(self.Value / other);

        public static explicit operator double(Decagram self) => self.Value;
        public static explicit operator Decagram(double self) => new Decagram(self);
    }
}