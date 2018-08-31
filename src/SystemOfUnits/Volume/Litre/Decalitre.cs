using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dal")]
    public readonly partial struct Decalitre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Decalitre>,
        IComparable,
        IComparable<Decalitre> {
        public const string Symbol = "dal";

        public Decalitre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Decalitre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Decalitre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decalitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decalitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dal", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decalitre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dal";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Decalitre(Value);

        public static bool operator ==(Decalitre self, Decalitre other) => self.Equals(other);
        public static bool operator !=(Decalitre self, Decalitre other) => !self.Equals(other);

        public static bool operator <(Decalitre self, Decalitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Decalitre self, Decalitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decalitre self, Decalitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decalitre self, Decalitre other) => self.CompareTo(other) >= 0;

        public static Decalitre operator +(Decalitre self, Decalitre other) => new Decalitre(self.Value + other.Value);
        public static Decalitre operator -(Decalitre self, Decalitre other) => new Decalitre(self.Value - other.Value);

        public static Decalitre operator *(Decalitre self, double other) => new Decalitre(self.Value * other);
        public static Decalitre operator *(double self, Decalitre other) => new Decalitre(self * other.Value);

        public static Decalitre operator /(Decalitre self, double other) => new Decalitre(self.Value / other);

        public static explicit operator double(Decalitre self) => self.Value;
        public static explicit operator Decalitre(double self) => new Decalitre(self);
    }
}