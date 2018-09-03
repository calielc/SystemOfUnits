using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    /// <summary>
    /// Represents a Kilohertz (symbol kHz).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kHz")]
    public readonly partial struct Kilohertz : IUnit, IEquatable<Kilohertz>, IComparable<Kilohertz> {
        private readonly double _value;

        public const string Symbol = "kHz";

        public Kilohertz(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kilohertz Ceiling() => new Kilohertz(Math.Ceiling(_value));

        public Kilohertz Round() => new Kilohertz(Math.Round(_value));
        public Kilohertz Round(int digits) => new Kilohertz(Math.Round(_value, digits));
        public Kilohertz Round(MidpointRounding mode) => new Kilohertz(Math.Round(_value, mode));

        public Kilohertz Floor() => new Kilohertz(Math.Floor(_value));

        public Kilohertz Truncate() => new Kilohertz(Math.Truncate(_value));

        public Kilohertz Abs() => new Kilohertz(Math.Abs(_value));

        public bool Equals(Kilohertz other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kilohertz other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilohertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilohertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kHz", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilohertz other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} kHz";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kilohertz self, Kilohertz other) => self.Equals(other);
        public static bool operator !=(Kilohertz self, Kilohertz other) => !self.Equals(other);

        public static bool operator <(Kilohertz self, Kilohertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilohertz self, Kilohertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilohertz self, Kilohertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilohertz self, Kilohertz other) => self.CompareTo(other) >= 0;

        public static Kilohertz operator +(Kilohertz self, Kilohertz other) => new Kilohertz(self._value + other._value);
        public static Kilohertz operator -(Kilohertz self, Kilohertz other) => new Kilohertz(self._value - other._value);

        public static Kilohertz operator *(Kilohertz self, double other) => new Kilohertz(self._value * other);
        public static Kilohertz operator *(double self, Kilohertz other) => new Kilohertz(self * other._value);

        public static Kilohertz operator /(Kilohertz self, double other) => new Kilohertz(self._value / other);

        public static explicit operator double(Kilohertz self) => self._value;
        public static explicit operator Kilohertz(double self) => new Kilohertz(self);
    }
}