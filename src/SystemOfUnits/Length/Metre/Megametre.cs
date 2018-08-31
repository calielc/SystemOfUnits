using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Mm")]
    public readonly partial struct Megametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Megametre>,
        IComparable,
        IComparable<Megametre> {
        public const string Symbol = "Mm";

        public Megametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Megametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Megametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Megametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Megametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Mm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Megametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Mm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Megametre(Value);

        public static bool operator ==(Megametre self, Megametre other) => self.Equals(other);
        public static bool operator !=(Megametre self, Megametre other) => !self.Equals(other);

        public static bool operator <(Megametre self, Megametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Megametre self, Megametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Megametre self, Megametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Megametre self, Megametre other) => self.CompareTo(other) >= 0;

        public static Megametre operator +(Megametre self, Megametre other) => new Megametre(self.Value + other.Value);
        public static Megametre operator -(Megametre self, Megametre other) => new Megametre(self.Value - other.Value);

        public static Megametre operator *(Megametre self, double other) => new Megametre(self.Value * other);
        public static Megametre operator *(double self, Megametre other) => new Megametre(self * other.Value);

        public static Megametre operator /(Megametre self, double other) => new Megametre(self.Value / other);

        public static explicit operator double(Megametre self) => self.Value;
        public static explicit operator Megametre(double self) => new Megametre(self);
    }
}