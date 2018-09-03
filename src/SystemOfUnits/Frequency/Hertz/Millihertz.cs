using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    /// <summary>
    /// Represents a Millihertz (symbol mHz).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mHz")]
    public readonly partial struct Millihertz : IUnit, IEquatable<Millihertz>, IComparable<Millihertz> {
        private readonly double _value;

        public const string Symbol = "mHz";

        public Millihertz(double value) {
            _value = value;
        }

        public double Value => _value;

        public Millihertz Ceiling() => new Millihertz(Math.Ceiling(_value));

        public Millihertz Round() => new Millihertz(Math.Round(_value));
        public Millihertz Round(int digits) => new Millihertz(Math.Round(_value, digits));
        public Millihertz Round(MidpointRounding mode) => new Millihertz(Math.Round(_value, mode));

        public Millihertz Floor() => new Millihertz(Math.Floor(_value));

        public Millihertz Truncate() => new Millihertz(Math.Truncate(_value));

        public Millihertz Abs() => new Millihertz(Math.Abs(_value));

        public bool Equals(Millihertz other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Millihertz other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millihertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millihertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mHz", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millihertz other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mHz";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Millihertz self, Millihertz other) => self.Equals(other);
        public static bool operator !=(Millihertz self, Millihertz other) => !self.Equals(other);

        public static bool operator <(Millihertz self, Millihertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Millihertz self, Millihertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millihertz self, Millihertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millihertz self, Millihertz other) => self.CompareTo(other) >= 0;

        public static Millihertz operator +(Millihertz self, Millihertz other) => new Millihertz(self._value + other._value);
        public static Millihertz operator -(Millihertz self, Millihertz other) => new Millihertz(self._value - other._value);

        public static Millihertz operator *(Millihertz self, double other) => new Millihertz(self._value * other);
        public static Millihertz operator *(double self, Millihertz other) => new Millihertz(self * other._value);

        public static Millihertz operator /(Millihertz self, double other) => new Millihertz(self._value / other);

        public static explicit operator double(Millihertz self) => self._value;
        public static explicit operator Millihertz(double self) => new Millihertz(self);
    }
}