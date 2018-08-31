using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cm")]
    public readonly partial struct Centimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Centimetre>,
        IComparable,
        IComparable<Centimetre> {
        public const string Symbol = "cm";

        public Centimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Centimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Centimetre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} cm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Centimetre(Value);

        public static bool operator ==(Centimetre self, Centimetre other) => self.Equals(other);
        public static bool operator !=(Centimetre self, Centimetre other) => !self.Equals(other);

        public static bool operator <(Centimetre self, Centimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(Centimetre self, Centimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centimetre self, Centimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centimetre self, Centimetre other) => self.CompareTo(other) >= 0;

        public static Centimetre operator +(Centimetre self, Centimetre other) => new Centimetre(self.Value + other.Value);
        public static Centimetre operator -(Centimetre self, Centimetre other) => new Centimetre(self.Value - other.Value);

        public static Centimetre operator *(Centimetre self, double other) => new Centimetre(self.Value * other);
        public static Centimetre operator *(double self, Centimetre other) => new Centimetre(self * other.Value);

        public static Centimetre operator /(Centimetre self, double other) => new Centimetre(self.Value / other);

        public static explicit operator double(Centimetre self) => self.Value;
        public static explicit operator Centimetre(double self) => new Centimetre(self);
    }
}