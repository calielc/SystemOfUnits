using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Temperature {
    /// <summary>
    /// Represents a Celsius (symbol °C).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} °C")]
    public readonly partial struct Celsius : IUnit, IEquatable<Celsius>, IComparable<Celsius> {
        private readonly double _value;

        public const string Symbol = "°C";

        public Celsius(double value) {
            _value = value;
        }

        public double Value => _value;

        public Celsius Ceiling() => new Celsius(Math.Ceiling(_value));

        public Celsius Round() => new Celsius(Math.Round(_value));
        public Celsius Round(int digits) => new Celsius(Math.Round(_value, digits));
        public Celsius Round(MidpointRounding mode) => new Celsius(Math.Round(_value, mode));

        public Celsius Floor() => new Celsius(Math.Floor(_value));

        public Celsius Truncate() => new Celsius(Math.Truncate(_value));

        public Celsius Abs() => new Celsius(Math.Abs(_value));

        public bool Equals(Celsius other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Celsius other) => this._value.CompareTo(other._value);

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
            => string.Format(format ?? "{0} °C", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Celsius other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} °C";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Celsius self, Celsius other) => self.Equals(other);
        public static bool operator !=(Celsius self, Celsius other) => !self.Equals(other);

        public static bool operator <(Celsius self, Celsius other) => self.CompareTo(other) < 0;
        public static bool operator >(Celsius self, Celsius other) => self.CompareTo(other) > 0;
        public static bool operator <=(Celsius self, Celsius other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Celsius self, Celsius other) => self.CompareTo(other) >= 0;

        public static Celsius operator +(Celsius self, Celsius other) => new Celsius(self._value + other._value);
        public static Celsius operator -(Celsius self, Celsius other) => new Celsius(self._value - other._value);

        public static Celsius operator *(Celsius self, double other) => new Celsius(self._value * other);
        public static Celsius operator *(double self, Celsius other) => new Celsius(self * other._value);

        public static Celsius operator /(Celsius self, double other) => new Celsius(self._value / other);

        public static explicit operator double(Celsius self) => self._value;
        public static explicit operator Celsius(double self) => new Celsius(self);
    }
}