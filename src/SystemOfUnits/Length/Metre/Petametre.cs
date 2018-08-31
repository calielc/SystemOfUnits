using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Pm")]
    public readonly partial struct Petametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Petametre>,
        IComparable,
        IComparable<Petametre> {
        public const string Symbol = "Pm";

        public Petametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Petametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Petametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Petametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Petametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Pm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Petametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Pm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Petametre(Value);

        public static bool operator ==(Petametre self, Petametre other) => self.Equals(other);
        public static bool operator !=(Petametre self, Petametre other) => !self.Equals(other);

        public static bool operator <(Petametre self, Petametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Petametre self, Petametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Petametre self, Petametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Petametre self, Petametre other) => self.CompareTo(other) >= 0;

        public static Petametre operator +(Petametre self, Petametre other) => new Petametre(self.Value + other.Value);
        public static Petametre operator -(Petametre self, Petametre other) => new Petametre(self.Value - other.Value);

        public static Petametre operator *(Petametre self, double other) => new Petametre(self.Value * other);
        public static Petametre operator *(double self, Petametre other) => new Petametre(self * other.Value);

        public static Petametre operator /(Petametre self, double other) => new Petametre(self.Value / other);

        public static explicit operator double(Petametre self) => self.Value;
        public static explicit operator Petametre(double self) => new Petametre(self);
    }
}