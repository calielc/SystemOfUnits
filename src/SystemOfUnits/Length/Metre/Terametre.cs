using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Tm")]
    public readonly partial struct Terametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Terametre>,
        IComparable,
        IComparable<Terametre> {
        public const string Symbol = "Tm";

        public Terametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Terametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Terametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Terametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Terametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Tm", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Terametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Tm";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Terametre(Value);

        public static bool operator ==(Terametre self, Terametre other) => self.Equals(other);
        public static bool operator !=(Terametre self, Terametre other) => !self.Equals(other);

        public static bool operator <(Terametre self, Terametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Terametre self, Terametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Terametre self, Terametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Terametre self, Terametre other) => self.CompareTo(other) >= 0;

        public static Terametre operator +(Terametre self, Terametre other) => new Terametre(self.Value + other.Value);
        public static Terametre operator -(Terametre self, Terametre other) => new Terametre(self.Value - other.Value);

        public static Terametre operator *(Terametre self, double other) => new Terametre(self.Value * other);
        public static Terametre operator *(double self, Terametre other) => new Terametre(self * other.Value);

        public static Terametre operator /(Terametre self, double other) => new Terametre(self.Value / other);

        public static explicit operator double(Terametre self) => self.Value;
        public static explicit operator Terametre(double self) => new Terametre(self);
    }
}