using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    /// <summary>
    /// Represents a Centiwatt (symbol cW).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cW")]
    public readonly partial struct Centiwatt : IUnit, IEquatable<Centiwatt>, IComparable<Centiwatt> {
        private readonly double _value;

        public const string Symbol = "cW";

        public Centiwatt(double value) {
            _value = value;
        }

        public double Value => _value;

        public Centiwatt Ceiling() => new Centiwatt(Math.Ceiling(_value));

        public Centiwatt Round() => new Centiwatt(Math.Round(_value));
        public Centiwatt Round(int digits) => new Centiwatt(Math.Round(_value, digits));
        public Centiwatt Round(MidpointRounding mode) => new Centiwatt(Math.Round(_value, mode));

        public Centiwatt Floor() => new Centiwatt(Math.Floor(_value));

        public Centiwatt Truncate() => new Centiwatt(Math.Truncate(_value));

        public Centiwatt Abs() => new Centiwatt(Math.Abs(_value));

        public bool Equals(Centiwatt other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Centiwatt other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centiwatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centiwatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cW", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centiwatt other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} cW";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Centiwatt self, Centiwatt other) => self.Equals(other);
        public static bool operator !=(Centiwatt self, Centiwatt other) => !self.Equals(other);

        public static bool operator <(Centiwatt self, Centiwatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Centiwatt self, Centiwatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centiwatt self, Centiwatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centiwatt self, Centiwatt other) => self.CompareTo(other) >= 0;

        public static Centiwatt operator +(Centiwatt self, Centiwatt other) => new Centiwatt(self._value + other._value);
        public static Centiwatt operator -(Centiwatt self, Centiwatt other) => new Centiwatt(self._value - other._value);

        public static Centiwatt operator *(Centiwatt self, double other) => new Centiwatt(self._value * other);
        public static Centiwatt operator *(double self, Centiwatt other) => new Centiwatt(self * other._value);

        public static Centiwatt operator /(Centiwatt self, double other) => new Centiwatt(self._value / other);

        public static explicit operator double(Centiwatt self) => self._value;
        public static explicit operator Centiwatt(double self) => new Centiwatt(self);
    }
}