using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Em")]
    public readonly partial struct Exametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Exametre>,
        IComparable,
        IComparable<Exametre> {
        public const string Symbol = "Em";

        public Exametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Exametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Exametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Exametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Exametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Em", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Exametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Em";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Exametre(Value);

        public static bool operator ==(Exametre self, Exametre other) => self.Equals(other);
        public static bool operator !=(Exametre self, Exametre other) => !self.Equals(other);

        public static bool operator <(Exametre self, Exametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Exametre self, Exametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Exametre self, Exametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Exametre self, Exametre other) => self.CompareTo(other) >= 0;

        public static Exametre operator +(Exametre self, Exametre other) => new Exametre(self.Value + other.Value);
        public static Exametre operator -(Exametre self, Exametre other) => new Exametre(self.Value - other.Value);

        public static Exametre operator *(Exametre self, double other) => new Exametre(self.Value * other);
        public static Exametre operator *(double self, Exametre other) => new Exametre(self * other.Value);

        public static Exametre operator /(Exametre self, double other) => new Exametre(self.Value / other);

        public static explicit operator double(Exametre self) => self.Value;
        public static explicit operator Exametre(double self) => new Exametre(self);
    }
}