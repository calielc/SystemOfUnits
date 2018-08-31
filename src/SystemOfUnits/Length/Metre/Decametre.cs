using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dam")]
    public readonly partial struct Decametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decametre>,
        IComparable,
        IComparable<Decametre> {
        public const string Symbol = "dam";

        public Decametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dam", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dam";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decametre(Value);

        public static bool operator ==(Decametre self, Decametre other) => self.Equals(other);
        public static bool operator !=(Decametre self, Decametre other) => !self.Equals(other);

        public static bool operator <(Decametre self, Decametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Decametre self, Decametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decametre self, Decametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decametre self, Decametre other) => self.CompareTo(other) >= 0;

        public static Decametre operator +(Decametre self, Decametre other) => new Decametre(self.Value + other.Value);
        public static Decametre operator -(Decametre self, Decametre other) => new Decametre(self.Value - other.Value);

        public static Decametre operator *(Decametre self, double other) => new Decametre(self.Value * other);
        public static Decametre operator *(double self, Decametre other) => new Decametre(self * other.Value);

        public static Decametre operator /(Decametre self, double other) => new Decametre(self.Value / other);

        public static explicit operator double(Decametre self) => self.Value;
        public static explicit operator Decametre(double self) => new Decametre(self);
    }
}