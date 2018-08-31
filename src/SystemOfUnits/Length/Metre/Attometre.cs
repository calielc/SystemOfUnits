using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} am")]
    public readonly partial struct Attometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Attometre>,
        IComparable,
        IComparable<Attometre> {
        public const string Symbol = "am";

        public Attometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Attometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Attometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Attometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Attometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} am", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Attometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} am";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Attometre(Value);

        public static bool operator ==(Attometre self, Attometre other) => self.Equals(other);
        public static bool operator !=(Attometre self, Attometre other) => !self.Equals(other);

        public static bool operator <(Attometre self, Attometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Attometre self, Attometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Attometre self, Attometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Attometre self, Attometre other) => self.CompareTo(other) >= 0;

        public static Attometre operator +(Attometre self, Attometre other) => new Attometre(self.Value + other.Value);
        public static Attometre operator -(Attometre self, Attometre other) => new Attometre(self.Value - other.Value);

        public static Attometre operator *(Attometre self, double other) => new Attometre(self.Value * other);
        public static Attometre operator *(double self, Attometre other) => new Attometre(self * other.Value);

        public static Attometre operator /(Attometre self, double other) => new Attometre(self.Value / other);

        public static explicit operator double(Attometre self) => self.Value;
        public static explicit operator Attometre(double self) => new Attometre(self);
    }
}