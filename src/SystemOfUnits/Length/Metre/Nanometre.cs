using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} nm")]
    public readonly partial struct Nanometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Nanometre>,
        IComparable,
        IComparable<Nanometre> {
        public const string Symbol = "nm";

        public Nanometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Nanometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Nanometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Nanometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Nanometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} nm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Nanometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} nm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Nanometre(Value);

        public static bool operator ==(Nanometre self, Nanometre other) => self.Equals(other);
        public static bool operator !=(Nanometre self, Nanometre other) => !self.Equals(other);

        public static bool operator <(Nanometre self, Nanometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Nanometre self, Nanometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Nanometre self, Nanometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Nanometre self, Nanometre other) => self.CompareTo(other) >= 0;

        public static Nanometre operator +(Nanometre self, Nanometre other) => new Nanometre(self.Value + other.Value);
        public static Nanometre operator -(Nanometre self, Nanometre other) => new Nanometre(self.Value - other.Value);

        public static Nanometre operator *(Nanometre self, double other) => new Nanometre(self.Value * other);
        public static Nanometre operator *(double self, Nanometre other) => new Nanometre(self * other.Value);

        public static Nanometre operator /(Nanometre self, double other) => new Nanometre(self.Value / other);

        public static explicit operator double(Nanometre self) => self.Value;
        public static explicit operator Nanometre(double self) => new Nanometre(self);
    }
}