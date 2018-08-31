using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cg")]
    public readonly partial struct Centigram : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Centigram>,
        IComparable,
        IComparable<Centigram> {
        public const string Symbol = "cg";

        public Centigram(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Centigram other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Centigram other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centigram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centigram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cg", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centigram other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} cg";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Centigram(Value);

        public static bool operator ==(Centigram self, Centigram other) => self.Equals(other);
        public static bool operator !=(Centigram self, Centigram other) => !self.Equals(other);

        public static bool operator <(Centigram self, Centigram other) => self.CompareTo(other) < 0;
        public static bool operator >(Centigram self, Centigram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centigram self, Centigram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centigram self, Centigram other) => self.CompareTo(other) >= 0;

        public static Centigram operator +(Centigram self, Centigram other) => new Centigram(self.Value + other.Value);
        public static Centigram operator -(Centigram self, Centigram other) => new Centigram(self.Value - other.Value);

        public static Centigram operator *(Centigram self, double other) => new Centigram(self.Value * other);
        public static Centigram operator *(double self, Centigram other) => new Centigram(self * other.Value);

        public static Centigram operator /(Centigram self, double other) => new Centigram(self.Value / other);

        public static explicit operator double(Centigram self) => self.Value;
        public static explicit operator Centigram(double self) => new Centigram(self);
    }
}