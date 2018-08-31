using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Imperial {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} yd")]
    public readonly partial struct Yard : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Yard>,
        IComparable,
        IComparable<Yard> {
        public const string Symbol = "yd";

        public Yard(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Yard other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Yard other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Yard other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Yard)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} yd", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Yard other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} yd";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Yard(Value);

        public static bool operator ==(Yard self, Yard other) => self.Equals(other);
        public static bool operator !=(Yard self, Yard other) => !self.Equals(other);

        public static bool operator <(Yard self, Yard other) => self.CompareTo(other) < 0;
        public static bool operator >(Yard self, Yard other) => self.CompareTo(other) > 0;
        public static bool operator <=(Yard self, Yard other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Yard self, Yard other) => self.CompareTo(other) >= 0;

        public static Yard operator +(Yard self, Yard other) => new Yard(self.Value + other.Value);
        public static Yard operator -(Yard self, Yard other) => new Yard(self.Value - other.Value);

        public static Yard operator *(Yard self, double other) => new Yard(self.Value * other);
        public static Yard operator *(double self, Yard other) => new Yard(self * other.Value);

        public static Yard operator /(Yard self, double other) => new Yard(self.Value / other);

        public static explicit operator double(Yard self) => self.Value;
        public static explicit operator Yard(double self) => new Yard(self);
    }
}