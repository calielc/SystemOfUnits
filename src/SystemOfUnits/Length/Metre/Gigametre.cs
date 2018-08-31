using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Gm")]
    public readonly partial struct Gigametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Gigametre>,
        IComparable,
        IComparable<Gigametre> {
        public const string Symbol = "Gm";

        public Gigametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Gigametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Gigametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gigametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gigametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Gm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gigametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Gm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Gigametre(Value);

        public static bool operator ==(Gigametre self, Gigametre other) => self.Equals(other);
        public static bool operator !=(Gigametre self, Gigametre other) => !self.Equals(other);

        public static bool operator <(Gigametre self, Gigametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Gigametre self, Gigametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gigametre self, Gigametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gigametre self, Gigametre other) => self.CompareTo(other) >= 0;

        public static Gigametre operator +(Gigametre self, Gigametre other) => new Gigametre(self.Value + other.Value);
        public static Gigametre operator -(Gigametre self, Gigametre other) => new Gigametre(self.Value - other.Value);

        public static Gigametre operator *(Gigametre self, double other) => new Gigametre(self.Value * other);
        public static Gigametre operator *(double self, Gigametre other) => new Gigametre(self * other.Value);

        public static Gigametre operator /(Gigametre self, double other) => new Gigametre(self.Value / other);

        public static explicit operator double(Gigametre self) => self.Value;
        public static explicit operator Gigametre(double self) => new Gigametre(self);
    }
}