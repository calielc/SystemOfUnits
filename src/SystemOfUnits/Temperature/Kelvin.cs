using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Temperature {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} K")]
    public readonly partial struct Kelvin : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Kelvin>,
        IComparable,
        IComparable<Kelvin> {
        public const string Symbol = "K";

        public Kelvin(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Kelvin other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Kelvin other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kelvin other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kelvin)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} K", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kelvin other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} K";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Kelvin(Value);

        public static bool operator ==(Kelvin self, Kelvin other) => self.Equals(other);
        public static bool operator !=(Kelvin self, Kelvin other) => !self.Equals(other);

        public static bool operator <(Kelvin self, Kelvin other) => self.CompareTo(other) < 0;
        public static bool operator >(Kelvin self, Kelvin other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kelvin self, Kelvin other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kelvin self, Kelvin other) => self.CompareTo(other) >= 0;

        public static Kelvin operator +(Kelvin self, Kelvin other) => new Kelvin(self.Value + other.Value);
        public static Kelvin operator -(Kelvin self, Kelvin other) => new Kelvin(self.Value - other.Value);

        public static Kelvin operator *(Kelvin self, double other) => new Kelvin(self.Value * other);
        public static Kelvin operator *(double self, Kelvin other) => new Kelvin(self * other.Value);

        public static Kelvin operator /(Kelvin self, double other) => new Kelvin(self.Value / other);

        public static explicit operator double(Kelvin self) => self.Value;
        public static explicit operator Kelvin(double self) => new Kelvin(self);
    }
}