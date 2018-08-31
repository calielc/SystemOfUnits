using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Angle {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mrad")]
    public readonly partial struct Milliradian : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Milliradian>,
        IComparable,
        IComparable<Milliradian> {
        public const string Symbol = "mrad";

        public Milliradian(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Milliradian other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Milliradian other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Milliradian other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Milliradian)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mrad", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Milliradian other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mrad";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Milliradian(Value);

        public static bool operator ==(Milliradian self, Milliradian other) => self.Equals(other);
        public static bool operator !=(Milliradian self, Milliradian other) => !self.Equals(other);

        public static bool operator <(Milliradian self, Milliradian other) => self.CompareTo(other) < 0;
        public static bool operator >(Milliradian self, Milliradian other) => self.CompareTo(other) > 0;
        public static bool operator <=(Milliradian self, Milliradian other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Milliradian self, Milliradian other) => self.CompareTo(other) >= 0;

        public static Milliradian operator +(Milliradian self, Milliradian other) => new Milliradian(self.Value + other.Value);
        public static Milliradian operator -(Milliradian self, Milliradian other) => new Milliradian(self.Value - other.Value);

        public static Milliradian operator *(Milliradian self, double other) => new Milliradian(self.Value * other);
        public static Milliradian operator *(double self, Milliradian other) => new Milliradian(self * other.Value);

        public static Milliradian operator /(Milliradian self, double other) => new Milliradian(self.Value / other);

        public static explicit operator double(Milliradian self) => self.Value;
        public static explicit operator Milliradian(double self) => new Milliradian(self);
    }
}