using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} daJ")]
    public readonly partial struct Decajoule : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decajoule>,
        IComparable,
        IComparable<Decajoule> {
        public const string Symbol = "daJ";

        public Decajoule(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decajoule other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decajoule other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decajoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decajoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} daJ", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decajoule other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} daJ";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decajoule(Value);

        public static bool operator ==(Decajoule self, Decajoule other) => self.Equals(other);
        public static bool operator !=(Decajoule self, Decajoule other) => !self.Equals(other);

        public static bool operator <(Decajoule self, Decajoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Decajoule self, Decajoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decajoule self, Decajoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decajoule self, Decajoule other) => self.CompareTo(other) >= 0;

        public static Decajoule operator +(Decajoule self, Decajoule other) => new Decajoule(self.Value + other.Value);
        public static Decajoule operator -(Decajoule self, Decajoule other) => new Decajoule(self.Value - other.Value);

        public static Decajoule operator *(Decajoule self, double other) => new Decajoule(self.Value * other);
        public static Decajoule operator *(double self, Decajoule other) => new Decajoule(self * other.Value);

        public static Decajoule operator /(Decajoule self, double other) => new Decajoule(self.Value / other);

        public static explicit operator double(Decajoule self) => self.Value;
        public static explicit operator Decajoule(double self) => new Decajoule(self);
    }
}