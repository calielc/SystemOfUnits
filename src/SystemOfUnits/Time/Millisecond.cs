using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} milliseconds")]
    public readonly partial struct Millisecond : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Millisecond>,
        IComparable,
        IComparable<Millisecond> {
        public const string Symbol = "milliseconds";

        public Millisecond(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Millisecond other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Millisecond other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millisecond other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millisecond)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} milliseconds", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millisecond other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} milliseconds";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Millisecond(Value);

        public static bool operator ==(Millisecond self, Millisecond other) => self.Equals(other);
        public static bool operator !=(Millisecond self, Millisecond other) => !self.Equals(other);

        public static bool operator <(Millisecond self, Millisecond other) => self.CompareTo(other) < 0;
        public static bool operator >(Millisecond self, Millisecond other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millisecond self, Millisecond other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millisecond self, Millisecond other) => self.CompareTo(other) >= 0;

        public static Millisecond operator +(Millisecond self, Millisecond other) => new Millisecond(self.Value + other.Value);
        public static Millisecond operator -(Millisecond self, Millisecond other) => new Millisecond(self.Value - other.Value);

        public static Millisecond operator *(Millisecond self, double other) => new Millisecond(self.Value * other);
        public static Millisecond operator *(double self, Millisecond other) => new Millisecond(self * other.Value);

        public static Millisecond operator /(Millisecond self, double other) => new Millisecond(self.Value / other);

        public static explicit operator double(Millisecond self) => self.Value;
        public static explicit operator Millisecond(double self) => new Millisecond(self);
    }
}