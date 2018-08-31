using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dm")]
    public readonly partial struct Decimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decimetre>,
        IComparable,
        IComparable<Decimetre> {
        public const string Symbol = "dm";

        public Decimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decimetre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decimetre(Value);

        public static bool operator ==(Decimetre self, Decimetre other) => self.Equals(other);
        public static bool operator !=(Decimetre self, Decimetre other) => !self.Equals(other);

        public static bool operator <(Decimetre self, Decimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(Decimetre self, Decimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decimetre self, Decimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decimetre self, Decimetre other) => self.CompareTo(other) >= 0;

        public static Decimetre operator +(Decimetre self, Decimetre other) => new Decimetre(self.Value + other.Value);
        public static Decimetre operator -(Decimetre self, Decimetre other) => new Decimetre(self.Value - other.Value);

        public static Decimetre operator *(Decimetre self, double other) => new Decimetre(self.Value * other);
        public static Decimetre operator *(double self, Decimetre other) => new Decimetre(self * other.Value);

        public static Decimetre operator /(Decimetre self, double other) => new Decimetre(self.Value / other);

        public static explicit operator double(Decimetre self) => self.Value;
        public static explicit operator Decimetre(double self) => new Decimetre(self);
    }
}