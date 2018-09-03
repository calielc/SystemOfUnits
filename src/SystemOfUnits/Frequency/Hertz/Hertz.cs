using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    /// <summary>
    /// Represents a Hertz (symbol Hz).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Hz")]
    public readonly partial struct Hertz : IUnit, IEquatable<Hertz>, IComparable<Hertz> {
        private readonly double _value;

        public const string Symbol = "Hz";

        public Hertz(double value) {
            _value = value;
        }

        public double Value => _value;

        public Hertz Ceiling() => new Hertz(Math.Ceiling(_value));

        public Hertz Round() => new Hertz(Math.Round(_value));
        public Hertz Round(int digits) => new Hertz(Math.Round(_value, digits));
        public Hertz Round(MidpointRounding mode) => new Hertz(Math.Round(_value, mode));

        public Hertz Floor() => new Hertz(Math.Floor(_value));

        public Hertz Truncate() => new Hertz(Math.Truncate(_value));

        public Hertz Abs() => new Hertz(Math.Abs(_value));

        public bool Equals(Hertz other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Hertz other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Hz", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hertz other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Hz";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Hertz self, Hertz other) => self.Equals(other);
        public static bool operator !=(Hertz self, Hertz other) => !self.Equals(other);

        public static bool operator <(Hertz self, Hertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Hertz self, Hertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hertz self, Hertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hertz self, Hertz other) => self.CompareTo(other) >= 0;

        public static Hertz operator +(Hertz self, Hertz other) => new Hertz(self._value + other._value);
        public static Hertz operator -(Hertz self, Hertz other) => new Hertz(self._value - other._value);

        public static Hertz operator *(Hertz self, double other) => new Hertz(self._value * other);
        public static Hertz operator *(double self, Hertz other) => new Hertz(self * other._value);

        public static Hertz operator /(Hertz self, double other) => new Hertz(self._value / other);

        public static explicit operator double(Hertz self) => self._value;
        public static explicit operator Hertz(double self) => new Hertz(self);
    }
}