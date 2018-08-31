using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} minutes")]
    public readonly partial struct Minute : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Minute>,
        IComparable,
        IComparable<Minute> {
        public const string Symbol = "minutes";

        public Minute(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Minute other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Minute other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Minute other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Minute)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} minutes", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Minute other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} minutes";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Minute(Value);

        public static bool operator ==(Minute self, Minute other) => self.Equals(other);
        public static bool operator !=(Minute self, Minute other) => !self.Equals(other);

        public static bool operator <(Minute self, Minute other) => self.CompareTo(other) < 0;
        public static bool operator >(Minute self, Minute other) => self.CompareTo(other) > 0;
        public static bool operator <=(Minute self, Minute other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Minute self, Minute other) => self.CompareTo(other) >= 0;

        public static Minute operator +(Minute self, Minute other) => new Minute(self.Value + other.Value);
        public static Minute operator -(Minute self, Minute other) => new Minute(self.Value - other.Value);

        public static Minute operator *(Minute self, double other) => new Minute(self.Value * other);
        public static Minute operator *(double self, Minute other) => new Minute(self * other.Value);

        public static Minute operator /(Minute self, double other) => new Minute(self.Value / other);

        public static explicit operator double(Minute self) => self.Value;
        public static explicit operator Minute(double self) => new Minute(self);
    }
}