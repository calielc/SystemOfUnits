using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Temperature {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} °C")]
    public readonly partial struct Celsius : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Celsius>,
        IComparable,
        IComparable<Celsius> {
        public const string Symbol = "°C";

        public Celsius(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Celsius other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Celsius other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Celsius other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Celsius)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} °C", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Celsius other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} °C";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Celsius(Value);

        public static bool operator ==(Celsius self, Celsius other) => self.Equals(other);
        public static bool operator !=(Celsius self, Celsius other) => !self.Equals(other);

        public static bool operator <(Celsius self, Celsius other) => self.CompareTo(other) < 0;
        public static bool operator >(Celsius self, Celsius other) => self.CompareTo(other) > 0;
        public static bool operator <=(Celsius self, Celsius other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Celsius self, Celsius other) => self.CompareTo(other) >= 0;

        public static Celsius operator +(Celsius self, Celsius other) => new Celsius(self.Value + other.Value);
        public static Celsius operator -(Celsius self, Celsius other) => new Celsius(self.Value - other.Value);

        public static Celsius operator *(Celsius self, double other) => new Celsius(self.Value * other);
        public static Celsius operator *(double self, Celsius other) => new Celsius(self * other.Value);

        public static Celsius operator /(Celsius self, double other) => new Celsius(self.Value / other);

        public static explicit operator double(Celsius self) => self.Value;
        public static explicit operator Celsius(double self) => new Celsius(self);
    }
}