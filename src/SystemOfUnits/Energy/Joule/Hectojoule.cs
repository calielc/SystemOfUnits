using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hJ")]
    public readonly partial struct Hectojoule : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Hectojoule>,
        IComparable,
        IComparable<Hectojoule> {
        public const string Symbol = "hJ";

        public Hectojoule(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Hectojoule other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Hectojoule other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectojoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectojoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hJ", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectojoule other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hJ";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Hectojoule(Value);

        public static bool operator ==(Hectojoule self, Hectojoule other) => self.Equals(other);
        public static bool operator !=(Hectojoule self, Hectojoule other) => !self.Equals(other);

        public static bool operator <(Hectojoule self, Hectojoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectojoule self, Hectojoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectojoule self, Hectojoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectojoule self, Hectojoule other) => self.CompareTo(other) >= 0;

        public static Hectojoule operator +(Hectojoule self, Hectojoule other) => new Hectojoule(self.Value + other.Value);
        public static Hectojoule operator -(Hectojoule self, Hectojoule other) => new Hectojoule(self.Value - other.Value);

        public static Hectojoule operator *(Hectojoule self, double other) => new Hectojoule(self.Value * other);
        public static Hectojoule operator *(double self, Hectojoule other) => new Hectojoule(self * other.Value);

        public static Hectojoule operator /(Hectojoule self, double other) => new Hectojoule(self.Value / other);

        public static explicit operator double(Hectojoule self) => self.Value;
        public static explicit operator Hectojoule(double self) => new Hectojoule(self);
    }
}