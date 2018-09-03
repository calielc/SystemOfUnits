using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    /// <summary>
    /// Represents a Joule (symbol J).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} J")]
    public readonly partial struct Joule : IUnit, IEquatable<Joule>, IComparable<Joule> {
        private readonly double _value;

        public const string Symbol = "J";

        public Joule(double value) {
            _value = value;
        }

        public double Value => _value;

        public Joule Ceiling() => new Joule(Math.Ceiling(_value));

        public Joule Round() => new Joule(Math.Round(_value));
        public Joule Round(int digits) => new Joule(Math.Round(_value, digits));
        public Joule Round(MidpointRounding mode) => new Joule(Math.Round(_value, mode));

        public Joule Floor() => new Joule(Math.Floor(_value));

        public Joule Truncate() => new Joule(Math.Truncate(_value));

        public Joule Abs() => new Joule(Math.Abs(_value));

        public bool Equals(Joule other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Joule other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Joule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Joule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} J", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Joule other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} J";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Joule self, Joule other) => self.Equals(other);
        public static bool operator !=(Joule self, Joule other) => !self.Equals(other);

        public static bool operator <(Joule self, Joule other) => self.CompareTo(other) < 0;
        public static bool operator >(Joule self, Joule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Joule self, Joule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Joule self, Joule other) => self.CompareTo(other) >= 0;

        public static Joule operator +(Joule self, Joule other) => new Joule(self._value + other._value);
        public static Joule operator -(Joule self, Joule other) => new Joule(self._value - other._value);

        public static Joule operator *(Joule self, double other) => new Joule(self._value * other);
        public static Joule operator *(double self, Joule other) => new Joule(self * other._value);

        public static Joule operator /(Joule self, double other) => new Joule(self._value / other);

        public static explicit operator double(Joule self) => self._value;
        public static explicit operator Joule(double self) => new Joule(self);
    }
}