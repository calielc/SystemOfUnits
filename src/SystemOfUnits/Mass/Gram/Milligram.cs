using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mg")]
    public readonly partial struct Milligram : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Milligram>,
        IComparable,
        IComparable<Milligram> {
        public const string Symbol = "mg";

        public Milligram(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Milligram other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Milligram other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Milligram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Milligram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mg", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Milligram other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mg";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Milligram(Value);

        public static bool operator ==(Milligram self, Milligram other) => self.Equals(other);
        public static bool operator !=(Milligram self, Milligram other) => !self.Equals(other);

        public static bool operator <(Milligram self, Milligram other) => self.CompareTo(other) < 0;
        public static bool operator >(Milligram self, Milligram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Milligram self, Milligram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Milligram self, Milligram other) => self.CompareTo(other) >= 0;

        public static Milligram operator +(Milligram self, Milligram other) => new Milligram(self.Value + other.Value);
        public static Milligram operator -(Milligram self, Milligram other) => new Milligram(self.Value - other.Value);

        public static Milligram operator *(Milligram self, double other) => new Milligram(self.Value * other);
        public static Milligram operator *(double self, Milligram other) => new Milligram(self * other.Value);

        public static Milligram operator /(Milligram self, double other) => new Milligram(self.Value / other);

        public static explicit operator double(Milligram self) => self.Value;
        public static explicit operator Milligram(double self) => new Milligram(self);
    }
}