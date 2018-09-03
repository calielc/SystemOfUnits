using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Angle {
    /// <summary>
    /// Represents a Radian (symbol rad).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} rad")]
    public readonly partial struct Radian : IUnit, IEquatable<Radian>, IComparable<Radian> {
        private readonly double _value;

        public const string Symbol = "rad";

        public Radian(double value) {
            _value = value;
        }

        public double Value => _value;

        public Radian Ceiling() => new Radian(Math.Ceiling(_value));

        public Radian Round() => new Radian(Math.Round(_value));
        public Radian Round(int digits) => new Radian(Math.Round(_value, digits));
        public Radian Round(MidpointRounding mode) => new Radian(Math.Round(_value, mode));

        public Radian Floor() => new Radian(Math.Floor(_value));

        public Radian Truncate() => new Radian(Math.Truncate(_value));

        public Radian Abs() => new Radian(Math.Abs(_value));

        public bool Equals(Radian other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Radian other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Radian other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Radian)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} rad", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Radian other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} rad";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Radian self, Radian other) => self.Equals(other);
        public static bool operator !=(Radian self, Radian other) => !self.Equals(other);

        public static bool operator <(Radian self, Radian other) => self.CompareTo(other) < 0;
        public static bool operator >(Radian self, Radian other) => self.CompareTo(other) > 0;
        public static bool operator <=(Radian self, Radian other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Radian self, Radian other) => self.CompareTo(other) >= 0;

        public static Radian operator +(Radian self, Radian other) => new Radian(self._value + other._value);
        public static Radian operator -(Radian self, Radian other) => new Radian(self._value - other._value);

        public static Radian operator *(Radian self, double other) => new Radian(self._value * other);
        public static Radian operator *(double self, Radian other) => new Radian(self * other._value);

        public static Radian operator /(Radian self, double other) => new Radian(self._value / other);

        public static explicit operator double(Radian self) => self._value;
        public static explicit operator Radian(double self) => new Radian(self);
    }
}