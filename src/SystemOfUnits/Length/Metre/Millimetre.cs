using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mm")]
    public readonly partial struct Millimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Millimetre>,
        IComparable,
        IComparable<Millimetre> {
        public const string Symbol = "mm";

        public Millimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Millimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Millimetre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Millimetre(Value);

        public static bool operator ==(Millimetre self, Millimetre other) => self.Equals(other);
        public static bool operator !=(Millimetre self, Millimetre other) => !self.Equals(other);

        public static bool operator <(Millimetre self, Millimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(Millimetre self, Millimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millimetre self, Millimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millimetre self, Millimetre other) => self.CompareTo(other) >= 0;

        public static Millimetre operator +(Millimetre self, Millimetre other) => new Millimetre(self.Value + other.Value);
        public static Millimetre operator -(Millimetre self, Millimetre other) => new Millimetre(self.Value - other.Value);

        public static Millimetre operator *(Millimetre self, double other) => new Millimetre(self.Value * other);
        public static Millimetre operator *(double self, Millimetre other) => new Millimetre(self * other.Value);

        public static Millimetre operator /(Millimetre self, double other) => new Millimetre(self.Value / other);

        public static explicit operator double(Millimetre self) => self.Value;
        public static explicit operator Millimetre(double self) => new Millimetre(self);
    }
}