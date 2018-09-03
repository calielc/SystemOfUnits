using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    /// <summary>
    /// Represents a Hectogram (symbol hg).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hg")]
    public readonly partial struct Hectogram : IUnit, IEquatable<Hectogram>, IComparable<Hectogram> {
        private readonly double _value;

        public const string Symbol = "hg";

        public Hectogram(double value) {
            _value = value;
        }

        public double Value => _value;

        public Hectogram Ceiling() => new Hectogram(Math.Ceiling(_value));

        public Hectogram Round() => new Hectogram(Math.Round(_value));
        public Hectogram Round(int digits) => new Hectogram(Math.Round(_value, digits));
        public Hectogram Round(MidpointRounding mode) => new Hectogram(Math.Round(_value, mode));

        public Hectogram Floor() => new Hectogram(Math.Floor(_value));

        public Hectogram Truncate() => new Hectogram(Math.Truncate(_value));

        public Hectogram Abs() => new Hectogram(Math.Abs(_value));

        public bool Equals(Hectogram other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Hectogram other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectogram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectogram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hg", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectogram other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hg";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Hectogram self, Hectogram other) => self.Equals(other);
        public static bool operator !=(Hectogram self, Hectogram other) => !self.Equals(other);

        public static bool operator <(Hectogram self, Hectogram other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectogram self, Hectogram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectogram self, Hectogram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectogram self, Hectogram other) => self.CompareTo(other) >= 0;

        public static Hectogram operator +(Hectogram self, Hectogram other) => new Hectogram(self._value + other._value);
        public static Hectogram operator -(Hectogram self, Hectogram other) => new Hectogram(self._value - other._value);

        public static Hectogram operator *(Hectogram self, double other) => new Hectogram(self._value * other);
        public static Hectogram operator *(double self, Hectogram other) => new Hectogram(self * other._value);

        public static Hectogram operator /(Hectogram self, double other) => new Hectogram(self._value / other);

        public static explicit operator double(Hectogram self) => self._value;
        public static explicit operator Hectogram(double self) => new Hectogram(self);
    }
}