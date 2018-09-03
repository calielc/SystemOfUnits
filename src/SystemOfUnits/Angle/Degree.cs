using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Angle {
    /// <summary>
    /// Represents a Degree (symbol °).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} °")]
    public readonly partial struct Degree : IUnit, IEquatable<Degree>, IComparable<Degree> {
        private readonly double _value;

        public const string Symbol = "°";

        public Degree(double value) {
            _value = value;
        }

        public double Value => _value;

        public Degree Ceiling() => new Degree(Math.Ceiling(_value));

        public Degree Round() => new Degree(Math.Round(_value));
        public Degree Round(int digits) => new Degree(Math.Round(_value, digits));
        public Degree Round(MidpointRounding mode) => new Degree(Math.Round(_value, mode));

        public Degree Floor() => new Degree(Math.Floor(_value));

        public Degree Truncate() => new Degree(Math.Truncate(_value));

        public Degree Abs() => new Degree(Math.Abs(_value));

        public bool Equals(Degree other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Degree other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Degree other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Degree)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} °", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Degree other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} °";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Degree self, Degree other) => self.Equals(other);
        public static bool operator !=(Degree self, Degree other) => !self.Equals(other);

        public static bool operator <(Degree self, Degree other) => self.CompareTo(other) < 0;
        public static bool operator >(Degree self, Degree other) => self.CompareTo(other) > 0;
        public static bool operator <=(Degree self, Degree other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Degree self, Degree other) => self.CompareTo(other) >= 0;

        public static Degree operator +(Degree self, Degree other) => new Degree(self._value + other._value);
        public static Degree operator -(Degree self, Degree other) => new Degree(self._value - other._value);

        public static Degree operator *(Degree self, double other) => new Degree(self._value * other);
        public static Degree operator *(double self, Degree other) => new Degree(self * other._value);

        public static Degree operator /(Degree self, double other) => new Degree(self._value / other);

        public static explicit operator double(Degree self) => self._value;
        public static explicit operator Degree(double self) => new Degree(self);
    }
}