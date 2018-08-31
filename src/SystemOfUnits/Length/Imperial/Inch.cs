using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Imperial {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} in")]
    public readonly partial struct Inch : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Inch>,
        IComparable,
        IComparable<Inch> {
        public const string Symbol = "in";

        public Inch(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Inch other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Inch other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Inch other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Inch)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} in", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Inch other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} in";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Inch(Value);

        public static bool operator ==(Inch self, Inch other) => self.Equals(other);
        public static bool operator !=(Inch self, Inch other) => !self.Equals(other);

        public static bool operator <(Inch self, Inch other) => self.CompareTo(other) < 0;
        public static bool operator >(Inch self, Inch other) => self.CompareTo(other) > 0;
        public static bool operator <=(Inch self, Inch other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Inch self, Inch other) => self.CompareTo(other) >= 0;

        public static Inch operator +(Inch self, Inch other) => new Inch(self.Value + other.Value);
        public static Inch operator -(Inch self, Inch other) => new Inch(self.Value - other.Value);

        public static Inch operator *(Inch self, double other) => new Inch(self.Value * other);
        public static Inch operator *(double self, Inch other) => new Inch(self * other.Value);

        public static Inch operator /(Inch self, double other) => new Inch(self.Value / other);

        public static explicit operator double(Inch self) => self.Value;
        public static explicit operator Inch(double self) => new Inch(self);
    }
}