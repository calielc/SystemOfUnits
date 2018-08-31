using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} km")]
    public readonly partial struct Kilometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kilometre>,
        IComparable,
        IComparable<Kilometre> {
        public const string Symbol = "km";

        public Kilometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kilometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kilometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} km", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} km";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kilometre(Value);

        public static bool operator ==(Kilometre self, Kilometre other) => self.Equals(other);
        public static bool operator !=(Kilometre self, Kilometre other) => !self.Equals(other);

        public static bool operator <(Kilometre self, Kilometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilometre self, Kilometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilometre self, Kilometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilometre self, Kilometre other) => self.CompareTo(other) >= 0;

        public static Kilometre operator +(Kilometre self, Kilometre other) => new Kilometre(self.Value + other.Value);
        public static Kilometre operator -(Kilometre self, Kilometre other) => new Kilometre(self.Value - other.Value);

        public static Kilometre operator *(Kilometre self, double other) => new Kilometre(self.Value * other);
        public static Kilometre operator *(double self, Kilometre other) => new Kilometre(self * other.Value);

        public static Kilometre operator /(Kilometre self, double other) => new Kilometre(self.Value / other);

        public static explicit operator double(Kilometre self) => self.Value;
        public static explicit operator Kilometre(double self) => new Kilometre(self);
    }
}