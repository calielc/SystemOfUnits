using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hm")]
    public readonly partial struct Hectometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Hectometre>,
        IComparable,
        IComparable<Hectometre> {
        public const string Symbol = "hm";

        public Hectometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Hectometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Hectometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Hectometre(Value);

        public static bool operator ==(Hectometre self, Hectometre other) => self.Equals(other);
        public static bool operator !=(Hectometre self, Hectometre other) => !self.Equals(other);

        public static bool operator <(Hectometre self, Hectometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectometre self, Hectometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectometre self, Hectometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectometre self, Hectometre other) => self.CompareTo(other) >= 0;

        public static Hectometre operator +(Hectometre self, Hectometre other) => new Hectometre(self.Value + other.Value);
        public static Hectometre operator -(Hectometre self, Hectometre other) => new Hectometre(self.Value - other.Value);

        public static Hectometre operator *(Hectometre self, double other) => new Hectometre(self.Value * other);
        public static Hectometre operator *(double self, Hectometre other) => new Hectometre(self * other.Value);

        public static Hectometre operator /(Hectometre self, double other) => new Hectometre(self.Value / other);

        public static explicit operator double(Hectometre self) => self.Value;
        public static explicit operator Hectometre(double self) => new Hectometre(self);
    }
}