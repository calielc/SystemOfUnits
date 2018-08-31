using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dJ")]
    public readonly partial struct Decijoule : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decijoule>,
        IComparable,
        IComparable<Decijoule> {
        public const string Symbol = "dJ";

        public Decijoule(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decijoule other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decijoule other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decijoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decijoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dJ", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decijoule other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dJ";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decijoule(Value);

        public static bool operator ==(Decijoule self, Decijoule other) => self.Equals(other);
        public static bool operator !=(Decijoule self, Decijoule other) => !self.Equals(other);

        public static bool operator <(Decijoule self, Decijoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Decijoule self, Decijoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decijoule self, Decijoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decijoule self, Decijoule other) => self.CompareTo(other) >= 0;

        public static Decijoule operator +(Decijoule self, Decijoule other) => new Decijoule(self.Value + other.Value);
        public static Decijoule operator -(Decijoule self, Decijoule other) => new Decijoule(self.Value - other.Value);

        public static Decijoule operator *(Decijoule self, double other) => new Decijoule(self.Value * other);
        public static Decijoule operator *(double self, Decijoule other) => new Decijoule(self * other.Value);

        public static Decijoule operator /(Decijoule self, double other) => new Decijoule(self.Value / other);

        public static explicit operator double(Decijoule self) => self.Value;
        public static explicit operator Decijoule(double self) => new Decijoule(self);
    }
}