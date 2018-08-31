using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cJ")]
    public readonly partial struct Centijoule : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Centijoule>,
        IComparable,
        IComparable<Centijoule> {
        public const string Symbol = "cJ";

        public Centijoule(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Centijoule other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Centijoule other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centijoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centijoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cJ", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centijoule other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} cJ";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Centijoule(Value);

        public static bool operator ==(Centijoule self, Centijoule other) => self.Equals(other);
        public static bool operator !=(Centijoule self, Centijoule other) => !self.Equals(other);

        public static bool operator <(Centijoule self, Centijoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Centijoule self, Centijoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centijoule self, Centijoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centijoule self, Centijoule other) => self.CompareTo(other) >= 0;

        public static Centijoule operator +(Centijoule self, Centijoule other) => new Centijoule(self.Value + other.Value);
        public static Centijoule operator -(Centijoule self, Centijoule other) => new Centijoule(self.Value - other.Value);

        public static Centijoule operator *(Centijoule self, double other) => new Centijoule(self.Value * other);
        public static Centijoule operator *(double self, Centijoule other) => new Centijoule(self * other.Value);

        public static Centijoule operator /(Centijoule self, double other) => new Centijoule(self.Value / other);

        public static explicit operator double(Centijoule self) => self.Value;
        public static explicit operator Centijoule(double self) => new Centijoule(self);
    }
}