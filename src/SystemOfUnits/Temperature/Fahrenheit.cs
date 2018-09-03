using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Temperature {
    /// <summary>
    /// Represents a Fahrenheit (symbol °F).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} °F")]
    public readonly partial struct Fahrenheit : IUnit, IEquatable<Fahrenheit>, IComparable<Fahrenheit> {
        private readonly double _value;

        public const string Symbol = "°F";

        public Fahrenheit(double value) {
            _value = value;
        }

        public double Value => _value;

        public Fahrenheit Ceiling() => new Fahrenheit(Math.Ceiling(_value));

        public Fahrenheit Round() => new Fahrenheit(Math.Round(_value));
        public Fahrenheit Round(int digits) => new Fahrenheit(Math.Round(_value, digits));
        public Fahrenheit Round(MidpointRounding mode) => new Fahrenheit(Math.Round(_value, mode));

        public Fahrenheit Floor() => new Fahrenheit(Math.Floor(_value));

        public Fahrenheit Truncate() => new Fahrenheit(Math.Truncate(_value));

        public Fahrenheit Abs() => new Fahrenheit(Math.Abs(_value));

        public bool Equals(Fahrenheit other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Fahrenheit other) => this._value.CompareTo(other._value);

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
            => string.Format(format ?? "{0} °F", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Fahrenheit other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} °F";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Fahrenheit self, Fahrenheit other) => self.Equals(other);
        public static bool operator !=(Fahrenheit self, Fahrenheit other) => !self.Equals(other);

        public static bool operator <(Fahrenheit self, Fahrenheit other) => self.CompareTo(other) < 0;
        public static bool operator >(Fahrenheit self, Fahrenheit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Fahrenheit self, Fahrenheit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Fahrenheit self, Fahrenheit other) => self.CompareTo(other) >= 0;

        public static Fahrenheit operator +(Fahrenheit self, Fahrenheit other) => new Fahrenheit(self._value + other._value);
        public static Fahrenheit operator -(Fahrenheit self, Fahrenheit other) => new Fahrenheit(self._value - other._value);

        public static Fahrenheit operator *(Fahrenheit self, double other) => new Fahrenheit(self._value * other);
        public static Fahrenheit operator *(double self, Fahrenheit other) => new Fahrenheit(self * other._value);

        public static Fahrenheit operator /(Fahrenheit self, double other) => new Fahrenheit(self._value / other);

        public static explicit operator double(Fahrenheit self) => self._value;
        public static explicit operator Fahrenheit(double self) => new Fahrenheit(self);
    }
}