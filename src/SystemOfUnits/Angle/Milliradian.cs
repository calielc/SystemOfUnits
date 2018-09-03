using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Angle {
    /// <summary>
    /// Represents a Milliradian (symbol mrad).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mrad")]
    public readonly partial struct Milliradian : IUnit, IEquatable<Milliradian>, IComparable<Milliradian> {
        private readonly double _value;

        public const string Symbol = "mrad";

        public Milliradian(double value) {
            _value = value;
        }

        public double Value => _value;

        public Milliradian Ceiling() => new Milliradian(Math.Ceiling(_value));

        public Milliradian Round() => new Milliradian(Math.Round(_value));
        public Milliradian Round(int digits) => new Milliradian(Math.Round(_value, digits));
        public Milliradian Round(MidpointRounding mode) => new Milliradian(Math.Round(_value, mode));

        public Milliradian Floor() => new Milliradian(Math.Floor(_value));

        public Milliradian Truncate() => new Milliradian(Math.Truncate(_value));

        public Milliradian Abs() => new Milliradian(Math.Abs(_value));

        public bool Equals(Milliradian other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Milliradian other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Milliradian other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Milliradian)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mrad", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Milliradian other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mrad";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Milliradian self, Milliradian other) => self.Equals(other);
        public static bool operator !=(Milliradian self, Milliradian other) => !self.Equals(other);

        public static bool operator <(Milliradian self, Milliradian other) => self.CompareTo(other) < 0;
        public static bool operator >(Milliradian self, Milliradian other) => self.CompareTo(other) > 0;
        public static bool operator <=(Milliradian self, Milliradian other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Milliradian self, Milliradian other) => self.CompareTo(other) >= 0;

        public static Milliradian operator +(Milliradian self, Milliradian other) => new Milliradian(self._value + other._value);
        public static Milliradian operator -(Milliradian self, Milliradian other) => new Milliradian(self._value - other._value);

        public static Milliradian operator *(Milliradian self, double other) => new Milliradian(self._value * other);
        public static Milliradian operator *(double self, Milliradian other) => new Milliradian(self * other._value);

        public static Milliradian operator /(Milliradian self, double other) => new Milliradian(self._value / other);

        public static explicit operator double(Milliradian self) => self._value;
        public static explicit operator Milliradian(double self) => new Milliradian(self);
    }
}