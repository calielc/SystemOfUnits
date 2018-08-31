using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cl")]
    public readonly partial struct Centilitre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Centilitre>,
        IComparable,
        IComparable<Centilitre> {
        public const string Symbol = "cl";

        public Centilitre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Centilitre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Centilitre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centilitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centilitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cl", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centilitre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} cl";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Centilitre(Value);

        public static bool operator ==(Centilitre self, Centilitre other) => self.Equals(other);
        public static bool operator !=(Centilitre self, Centilitre other) => !self.Equals(other);

        public static bool operator <(Centilitre self, Centilitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Centilitre self, Centilitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centilitre self, Centilitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centilitre self, Centilitre other) => self.CompareTo(other) >= 0;

        public static Centilitre operator +(Centilitre self, Centilitre other) => new Centilitre(self.Value + other.Value);
        public static Centilitre operator -(Centilitre self, Centilitre other) => new Centilitre(self.Value - other.Value);

        public static Centilitre operator *(Centilitre self, double other) => new Centilitre(self.Value * other);
        public static Centilitre operator *(double self, Centilitre other) => new Centilitre(self * other.Value);

        public static Centilitre operator /(Centilitre self, double other) => new Centilitre(self.Value / other);

        public static explicit operator double(Centilitre self) => self.Value;
        public static explicit operator Centilitre(double self) => new Centilitre(self);
    }
}