using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Angle {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} °")]
    public readonly partial struct Degree : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Degree>,
        IComparable,
        IComparable<Degree> {
        public const string Symbol = "°";

        public Degree(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Degree other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Degree other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Degree other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Degree)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} °", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Degree other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} °";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Degree(Value);

        public static bool operator ==(Degree self, Degree other) => self.Equals(other);
        public static bool operator !=(Degree self, Degree other) => !self.Equals(other);

        public static bool operator <(Degree self, Degree other) => self.CompareTo(other) < 0;
        public static bool operator >(Degree self, Degree other) => self.CompareTo(other) > 0;
        public static bool operator <=(Degree self, Degree other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Degree self, Degree other) => self.CompareTo(other) >= 0;

        public static Degree operator +(Degree self, Degree other) => new Degree(self.Value + other.Value);
        public static Degree operator -(Degree self, Degree other) => new Degree(self.Value - other.Value);

        public static Degree operator *(Degree self, double other) => new Degree(self.Value * other);
        public static Degree operator *(double self, Degree other) => new Degree(self * other.Value);

        public static Degree operator /(Degree self, double other) => new Degree(self.Value / other);

        public static explicit operator double(Degree self) => self.Value;
        public static explicit operator Degree(double self) => new Degree(self);
    }
}