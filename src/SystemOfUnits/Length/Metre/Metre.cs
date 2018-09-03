using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Metre (symbol m).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} m")]
    public readonly partial struct Metre : IUnit, IEquatable<Metre>, IComparable<Metre> {
        private readonly double _value;

        public const string Symbol = "m";

        public Metre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Metre Ceiling() => new Metre(Math.Ceiling(_value));

        public Metre Round() => new Metre(Math.Round(_value));
        public Metre Round(int digits) => new Metre(Math.Round(_value, digits));
        public Metre Round(MidpointRounding mode) => new Metre(Math.Round(_value, mode));

        public Metre Floor() => new Metre(Math.Floor(_value));

        public Metre Truncate() => new Metre(Math.Truncate(_value));

        public Metre Abs() => new Metre(Math.Abs(_value));

        public bool Equals(Metre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Metre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Metre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Metre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} m", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Metre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} m";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Metre self, Metre other) => self.Equals(other);
        public static bool operator !=(Metre self, Metre other) => !self.Equals(other);

        public static bool operator <(Metre self, Metre other) => self.CompareTo(other) < 0;
        public static bool operator >(Metre self, Metre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Metre self, Metre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Metre self, Metre other) => self.CompareTo(other) >= 0;

        public static Metre operator +(Metre self, Metre other) => new Metre(self._value + other._value);
        public static Metre operator -(Metre self, Metre other) => new Metre(self._value - other._value);

        public static Metre operator *(Metre self, double other) => new Metre(self._value * other);
        public static Metre operator *(double self, Metre other) => new Metre(self * other._value);

        public static Metre operator /(Metre self, double other) => new Metre(self._value / other);

        public static explicit operator double(Metre self) => self._value;
        public static explicit operator Metre(double self) => new Metre(self);
    }
}