using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Temperature {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} °F")]
    public readonly partial struct Fahrenheit : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Fahrenheit>,
        IComparable,
        IComparable<Fahrenheit> {
        public const string Symbol = "°F";

        public Fahrenheit(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Fahrenheit other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Fahrenheit other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Fahrenheit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Fahrenheit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} °F", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Fahrenheit other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} °F";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Fahrenheit(Value);

        public static bool operator ==(Fahrenheit self, Fahrenheit other) => self.Equals(other);
        public static bool operator !=(Fahrenheit self, Fahrenheit other) => !self.Equals(other);

        public static bool operator <(Fahrenheit self, Fahrenheit other) => self.CompareTo(other) < 0;
        public static bool operator >(Fahrenheit self, Fahrenheit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Fahrenheit self, Fahrenheit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Fahrenheit self, Fahrenheit other) => self.CompareTo(other) >= 0;

        public static Fahrenheit operator +(Fahrenheit self, Fahrenheit other) => new Fahrenheit(self.Value + other.Value);
        public static Fahrenheit operator -(Fahrenheit self, Fahrenheit other) => new Fahrenheit(self.Value - other.Value);

        public static Fahrenheit operator *(Fahrenheit self, double other) => new Fahrenheit(self.Value * other);
        public static Fahrenheit operator *(double self, Fahrenheit other) => new Fahrenheit(self * other.Value);

        public static Fahrenheit operator /(Fahrenheit self, double other) => new Fahrenheit(self.Value / other);

        public static explicit operator double(Fahrenheit self) => self.Value;
        public static explicit operator Fahrenheit(double self) => new Fahrenheit(self);
    }
}