using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hl")]
    public readonly partial struct Hectolitre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Hectolitre>,
        IComparable,
        IComparable<Hectolitre> {
        public const string Symbol = "hl";

        public Hectolitre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Hectolitre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Hectolitre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectolitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectolitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hl", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectolitre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hl";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Hectolitre(Value);

        public static bool operator ==(Hectolitre self, Hectolitre other) => self.Equals(other);
        public static bool operator !=(Hectolitre self, Hectolitre other) => !self.Equals(other);

        public static bool operator <(Hectolitre self, Hectolitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectolitre self, Hectolitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectolitre self, Hectolitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectolitre self, Hectolitre other) => self.CompareTo(other) >= 0;

        public static Hectolitre operator +(Hectolitre self, Hectolitre other) => new Hectolitre(self.Value + other.Value);
        public static Hectolitre operator -(Hectolitre self, Hectolitre other) => new Hectolitre(self.Value - other.Value);

        public static Hectolitre operator *(Hectolitre self, double other) => new Hectolitre(self.Value * other);
        public static Hectolitre operator *(double self, Hectolitre other) => new Hectolitre(self * other.Value);

        public static Hectolitre operator /(Hectolitre self, double other) => new Hectolitre(self.Value / other);

        public static explicit operator double(Hectolitre self) => self.Value;
        public static explicit operator Hectolitre(double self) => new Hectolitre(self);
    }
}