using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} l")]
    public readonly partial struct Litre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Litre>,
        IComparable,
        IComparable<Litre> {
        public const string Symbol = "l";

        public Litre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Litre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Litre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Litre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Litre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} l", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Litre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} l";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Litre(Value);

        public static bool operator ==(Litre self, Litre other) => self.Equals(other);
        public static bool operator !=(Litre self, Litre other) => !self.Equals(other);

        public static bool operator <(Litre self, Litre other) => self.CompareTo(other) < 0;
        public static bool operator >(Litre self, Litre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Litre self, Litre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Litre self, Litre other) => self.CompareTo(other) >= 0;

        public static Litre operator +(Litre self, Litre other) => new Litre(self.Value + other.Value);
        public static Litre operator -(Litre self, Litre other) => new Litre(self.Value - other.Value);

        public static Litre operator *(Litre self, double other) => new Litre(self.Value * other);
        public static Litre operator *(double self, Litre other) => new Litre(self * other.Value);

        public static Litre operator /(Litre self, double other) => new Litre(self.Value / other);

        public static explicit operator double(Litre self) => self.Value;
        public static explicit operator Litre(double self) => new Litre(self);
    }
}