using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mJ")]
    public readonly partial struct Millijoule : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Millijoule>,
        IComparable,
        IComparable<Millijoule> {
        public const string Symbol = "mJ";

        public Millijoule(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Millijoule other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Millijoule other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millijoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millijoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mJ", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millijoule other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mJ";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Millijoule(Value);

        public static bool operator ==(Millijoule self, Millijoule other) => self.Equals(other);
        public static bool operator !=(Millijoule self, Millijoule other) => !self.Equals(other);

        public static bool operator <(Millijoule self, Millijoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Millijoule self, Millijoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millijoule self, Millijoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millijoule self, Millijoule other) => self.CompareTo(other) >= 0;

        public static Millijoule operator +(Millijoule self, Millijoule other) => new Millijoule(self.Value + other.Value);
        public static Millijoule operator -(Millijoule self, Millijoule other) => new Millijoule(self.Value - other.Value);

        public static Millijoule operator *(Millijoule self, double other) => new Millijoule(self.Value * other);
        public static Millijoule operator *(double self, Millijoule other) => new Millijoule(self * other.Value);

        public static Millijoule operator /(Millijoule self, double other) => new Millijoule(self.Value / other);

        public static explicit operator double(Millijoule self) => self.Value;
        public static explicit operator Millijoule(double self) => new Millijoule(self);
    }
}