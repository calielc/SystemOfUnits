using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kl")]
    public readonly partial struct Kilolitre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kilolitre>,
        IComparable,
        IComparable<Kilolitre> {
        public const string Symbol = "kl";

        public Kilolitre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kilolitre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kilolitre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilolitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilolitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kl", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilolitre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} kl";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kilolitre(Value);

        public static bool operator ==(Kilolitre self, Kilolitre other) => self.Equals(other);
        public static bool operator !=(Kilolitre self, Kilolitre other) => !self.Equals(other);

        public static bool operator <(Kilolitre self, Kilolitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilolitre self, Kilolitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilolitre self, Kilolitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilolitre self, Kilolitre other) => self.CompareTo(other) >= 0;

        public static Kilolitre operator +(Kilolitre self, Kilolitre other) => new Kilolitre(self.Value + other.Value);
        public static Kilolitre operator -(Kilolitre self, Kilolitre other) => new Kilolitre(self.Value - other.Value);

        public static Kilolitre operator *(Kilolitre self, double other) => new Kilolitre(self.Value * other);
        public static Kilolitre operator *(double self, Kilolitre other) => new Kilolitre(self * other.Value);

        public static Kilolitre operator /(Kilolitre self, double other) => new Kilolitre(self.Value / other);

        public static explicit operator double(Kilolitre self) => self.Value;
        public static explicit operator Kilolitre(double self) => new Kilolitre(self);
    }
}