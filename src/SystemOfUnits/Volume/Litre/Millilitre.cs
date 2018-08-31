using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} ml")]
    public readonly partial struct Millilitre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Millilitre>,
        IComparable,
        IComparable<Millilitre> {
        public const string Symbol = "ml";

        public Millilitre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Millilitre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Millilitre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millilitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millilitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} ml", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millilitre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} ml";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Millilitre(Value);

        public static bool operator ==(Millilitre self, Millilitre other) => self.Equals(other);
        public static bool operator !=(Millilitre self, Millilitre other) => !self.Equals(other);

        public static bool operator <(Millilitre self, Millilitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Millilitre self, Millilitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millilitre self, Millilitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millilitre self, Millilitre other) => self.CompareTo(other) >= 0;

        public static Millilitre operator +(Millilitre self, Millilitre other) => new Millilitre(self.Value + other.Value);
        public static Millilitre operator -(Millilitre self, Millilitre other) => new Millilitre(self.Value - other.Value);

        public static Millilitre operator *(Millilitre self, double other) => new Millilitre(self.Value * other);
        public static Millilitre operator *(double self, Millilitre other) => new Millilitre(self * other.Value);

        public static Millilitre operator /(Millilitre self, double other) => new Millilitre(self.Value / other);

        public static explicit operator double(Millilitre self) => self.Value;
        public static explicit operator Millilitre(double self) => new Millilitre(self);
    }
}