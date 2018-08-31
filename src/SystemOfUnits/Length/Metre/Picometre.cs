using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} pm")]
    public readonly partial struct Picometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Picometre>,
        IComparable,
        IComparable<Picometre> {
        public const string Symbol = "pm";

        public Picometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Picometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Picometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Picometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Picometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} pm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Picometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} pm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Picometre(Value);

        public static bool operator ==(Picometre self, Picometre other) => self.Equals(other);
        public static bool operator !=(Picometre self, Picometre other) => !self.Equals(other);

        public static bool operator <(Picometre self, Picometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Picometre self, Picometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Picometre self, Picometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Picometre self, Picometre other) => self.CompareTo(other) >= 0;

        public static Picometre operator +(Picometre self, Picometre other) => new Picometre(self.Value + other.Value);
        public static Picometre operator -(Picometre self, Picometre other) => new Picometre(self.Value - other.Value);

        public static Picometre operator *(Picometre self, double other) => new Picometre(self.Value * other);
        public static Picometre operator *(double self, Picometre other) => new Picometre(self * other.Value);

        public static Picometre operator /(Picometre self, double other) => new Picometre(self.Value / other);

        public static explicit operator double(Picometre self) => self.Value;
        public static explicit operator Picometre(double self) => new Picometre(self);
    }
}