using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dg")]
    public readonly partial struct Decigram : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decigram>,
        IComparable,
        IComparable<Decigram> {
        public const string Symbol = "dg";

        public Decigram(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decigram other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decigram other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decigram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decigram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dg", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decigram other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dg";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decigram(Value);

        public static bool operator ==(Decigram self, Decigram other) => self.Equals(other);
        public static bool operator !=(Decigram self, Decigram other) => !self.Equals(other);

        public static bool operator <(Decigram self, Decigram other) => self.CompareTo(other) < 0;
        public static bool operator >(Decigram self, Decigram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decigram self, Decigram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decigram self, Decigram other) => self.CompareTo(other) >= 0;

        public static Decigram operator +(Decigram self, Decigram other) => new Decigram(self.Value + other.Value);
        public static Decigram operator -(Decigram self, Decigram other) => new Decigram(self.Value - other.Value);

        public static Decigram operator *(Decigram self, double other) => new Decigram(self.Value * other);
        public static Decigram operator *(double self, Decigram other) => new Decigram(self * other.Value);

        public static Decigram operator /(Decigram self, double other) => new Decigram(self.Value / other);

        public static explicit operator double(Decigram self) => self.Value;
        public static explicit operator Decigram(double self) => new Decigram(self);
    }
}