using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    /// <summary>
    /// Represents a Kilogram (symbol kg).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kg")]
    public readonly partial struct Kilogram : IUnit, IEquatable<Kilogram>, IComparable<Kilogram> {
        private readonly double _value;

        public const string Symbol = "kg";

        public Kilogram(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kilogram Ceiling() => new Kilogram(Math.Ceiling(_value));

        public Kilogram Round() => new Kilogram(Math.Round(_value));
        public Kilogram Round(int digits) => new Kilogram(Math.Round(_value, digits));
        public Kilogram Round(MidpointRounding mode) => new Kilogram(Math.Round(_value, mode));

        public Kilogram Floor() => new Kilogram(Math.Floor(_value));

        public Kilogram Truncate() => new Kilogram(Math.Truncate(_value));

        public Kilogram Abs() => new Kilogram(Math.Abs(_value));

        public bool Equals(Kilogram other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kilogram other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilogram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilogram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kg", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilogram other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} kg";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kilogram self, Kilogram other) => self.Equals(other);
        public static bool operator !=(Kilogram self, Kilogram other) => !self.Equals(other);

        public static bool operator <(Kilogram self, Kilogram other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilogram self, Kilogram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilogram self, Kilogram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilogram self, Kilogram other) => self.CompareTo(other) >= 0;

        public static Kilogram operator +(Kilogram self, Kilogram other) => new Kilogram(self._value + other._value);
        public static Kilogram operator -(Kilogram self, Kilogram other) => new Kilogram(self._value - other._value);

        public static Kilogram operator *(Kilogram self, double other) => new Kilogram(self._value * other);
        public static Kilogram operator *(double self, Kilogram other) => new Kilogram(self * other._value);

        public static Kilogram operator /(Kilogram self, double other) => new Kilogram(self._value / other);

        public static explicit operator double(Kilogram self) => self._value;
        public static explicit operator Kilogram(double self) => new Kilogram(self);
    }
}