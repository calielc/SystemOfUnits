using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kJ")]
    public readonly partial struct Kilojoule : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kilojoule>,
        IComparable,
        IComparable<Kilojoule> {
        public const string Symbol = "kJ";

        public Kilojoule(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kilojoule other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kilojoule other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilojoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilojoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kJ", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilojoule other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} kJ";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kilojoule(Value);

        public static bool operator ==(Kilojoule self, Kilojoule other) => self.Equals(other);
        public static bool operator !=(Kilojoule self, Kilojoule other) => !self.Equals(other);

        public static bool operator <(Kilojoule self, Kilojoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilojoule self, Kilojoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilojoule self, Kilojoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilojoule self, Kilojoule other) => self.CompareTo(other) >= 0;

        public static Kilojoule operator +(Kilojoule self, Kilojoule other) => new Kilojoule(self.Value + other.Value);
        public static Kilojoule operator -(Kilojoule self, Kilojoule other) => new Kilojoule(self.Value - other.Value);

        public static Kilojoule operator *(Kilojoule self, double other) => new Kilojoule(self.Value * other);
        public static Kilojoule operator *(double self, Kilojoule other) => new Kilojoule(self * other.Value);

        public static Kilojoule operator /(Kilojoule self, double other) => new Kilojoule(self.Value / other);

        public static explicit operator double(Kilojoule self) => self.Value;
        public static explicit operator Kilojoule(double self) => new Kilojoule(self);
    }
}