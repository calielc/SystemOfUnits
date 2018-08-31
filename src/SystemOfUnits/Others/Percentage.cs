using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Others {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} %")]
    public readonly partial struct Percentage : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Percentage>,
        IComparable,
        IComparable<Percentage> {
        public const string Symbol = "%";

        public Percentage(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Percentage other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Percentage other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Percentage other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Percentage)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} %", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Percentage other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} %";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Percentage(Value);

        public static bool operator ==(Percentage self, Percentage other) => self.Equals(other);
        public static bool operator !=(Percentage self, Percentage other) => !self.Equals(other);

        public static bool operator <(Percentage self, Percentage other) => self.CompareTo(other) < 0;
        public static bool operator >(Percentage self, Percentage other) => self.CompareTo(other) > 0;
        public static bool operator <=(Percentage self, Percentage other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Percentage self, Percentage other) => self.CompareTo(other) >= 0;

        public static Percentage operator +(Percentage self, Percentage other) => new Percentage(self.Value + other.Value);
        public static Percentage operator -(Percentage self, Percentage other) => new Percentage(self.Value - other.Value);

        public static Percentage operator *(Percentage self, double other) => new Percentage(self.Value * other);
        public static Percentage operator *(double self, Percentage other) => new Percentage(self * other.Value);

        public static Percentage operator /(Percentage self, double other) => new Percentage(self.Value / other);

        public static explicit operator double(Percentage self) => self.Value;
        public static explicit operator Percentage(double self) => new Percentage(self);
    }
}