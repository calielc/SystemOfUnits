using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} fm")]
    public readonly partial struct Femtometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Femtometre>,
        IComparable,
        IComparable<Femtometre> {
        public const string Symbol = "fm";

        public Femtometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Femtometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Femtometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Femtometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Femtometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} fm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Femtometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} fm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Femtometre(Value);

        public static bool operator ==(Femtometre self, Femtometre other) => self.Equals(other);
        public static bool operator !=(Femtometre self, Femtometre other) => !self.Equals(other);

        public static bool operator <(Femtometre self, Femtometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Femtometre self, Femtometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Femtometre self, Femtometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Femtometre self, Femtometre other) => self.CompareTo(other) >= 0;

        public static Femtometre operator +(Femtometre self, Femtometre other) => new Femtometre(self.Value + other.Value);
        public static Femtometre operator -(Femtometre self, Femtometre other) => new Femtometre(self.Value - other.Value);

        public static Femtometre operator *(Femtometre self, double other) => new Femtometre(self.Value * other);
        public static Femtometre operator *(double self, Femtometre other) => new Femtometre(self * other.Value);

        public static Femtometre operator /(Femtometre self, double other) => new Femtometre(self.Value / other);

        public static explicit operator double(Femtometre self) => self.Value;
        public static explicit operator Femtometre(double self) => new Femtometre(self);
    }
}