using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dl")]
    public readonly partial struct Decilitre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decilitre>,
        IComparable,
        IComparable<Decilitre> {
        public const string Symbol = "dl";

        public Decilitre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decilitre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decilitre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decilitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decilitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dl", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decilitre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dl";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decilitre(Value);

        public static bool operator ==(Decilitre self, Decilitre other) => self.Equals(other);
        public static bool operator !=(Decilitre self, Decilitre other) => !self.Equals(other);

        public static bool operator <(Decilitre self, Decilitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Decilitre self, Decilitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decilitre self, Decilitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decilitre self, Decilitre other) => self.CompareTo(other) >= 0;

        public static Decilitre operator +(Decilitre self, Decilitre other) => new Decilitre(self.Value + other.Value);
        public static Decilitre operator -(Decilitre self, Decilitre other) => new Decilitre(self.Value - other.Value);

        public static Decilitre operator *(Decilitre self, double other) => new Decilitre(self.Value * other);
        public static Decilitre operator *(double self, Decilitre other) => new Decilitre(self * other.Value);

        public static Decilitre operator /(Decilitre self, double other) => new Decilitre(self.Value / other);

        public static explicit operator double(Decilitre self) => self.Value;
        public static explicit operator Decilitre(double self) => new Decilitre(self);
    }
}