using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Angle {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} rad")]
    public readonly partial struct Radian : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Radian>,
        IComparable,
        IComparable<Radian> {
        public const string Symbol = "rad";

        public Radian(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Radian other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Radian other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Radian other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Radian)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} rad", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Radian other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} rad";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Radian(Value);

        public static bool operator ==(Radian self, Radian other) => self.Equals(other);
        public static bool operator !=(Radian self, Radian other) => !self.Equals(other);

        public static bool operator <(Radian self, Radian other) => self.CompareTo(other) < 0;
        public static bool operator >(Radian self, Radian other) => self.CompareTo(other) > 0;
        public static bool operator <=(Radian self, Radian other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Radian self, Radian other) => self.CompareTo(other) >= 0;

        public static Radian operator +(Radian self, Radian other) => new Radian(self.Value + other.Value);
        public static Radian operator -(Radian self, Radian other) => new Radian(self.Value - other.Value);

        public static Radian operator *(Radian self, double other) => new Radian(self.Value * other);
        public static Radian operator *(double self, Radian other) => new Radian(self * other.Value);

        public static Radian operator /(Radian self, double other) => new Radian(self.Value / other);

        public static explicit operator double(Radian self) => self.Value;
        public static explicit operator Radian(double self) => new Radian(self);
    }
}