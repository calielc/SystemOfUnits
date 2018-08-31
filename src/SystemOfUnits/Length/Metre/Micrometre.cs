using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} μm")]
    public readonly partial struct Micrometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Micrometre>,
        IComparable,
        IComparable<Micrometre> {
        public const string Symbol = "μm";

        public Micrometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Micrometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Micrometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Micrometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Micrometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} μm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Micrometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} μm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Micrometre(Value);

        public static bool operator ==(Micrometre self, Micrometre other) => self.Equals(other);
        public static bool operator !=(Micrometre self, Micrometre other) => !self.Equals(other);

        public static bool operator <(Micrometre self, Micrometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Micrometre self, Micrometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Micrometre self, Micrometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Micrometre self, Micrometre other) => self.CompareTo(other) >= 0;

        public static Micrometre operator +(Micrometre self, Micrometre other) => new Micrometre(self.Value + other.Value);
        public static Micrometre operator -(Micrometre self, Micrometre other) => new Micrometre(self.Value - other.Value);

        public static Micrometre operator *(Micrometre self, double other) => new Micrometre(self.Value * other);
        public static Micrometre operator *(double self, Micrometre other) => new Micrometre(self * other.Value);

        public static Micrometre operator /(Micrometre self, double other) => new Micrometre(self.Value / other);

        public static explicit operator double(Micrometre self) => self.Value;
        public static explicit operator Micrometre(double self) => new Micrometre(self);
    }
}