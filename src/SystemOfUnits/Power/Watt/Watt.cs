using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    /// <summary>
    /// Represents a Watt (symbol W).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} W")]
    public readonly partial struct Watt : IUnit, IEquatable<Watt>, IComparable<Watt> {
        private readonly double _value;

        public const string Symbol = "W";

        public Watt(double value) {
            _value = value;
        }

        public double Value => _value;

        public Watt Ceiling() => new Watt(Math.Ceiling(_value));

        public Watt Round() => new Watt(Math.Round(_value));
        public Watt Round(int digits) => new Watt(Math.Round(_value, digits));
        public Watt Round(MidpointRounding mode) => new Watt(Math.Round(_value, mode));

        public Watt Floor() => new Watt(Math.Floor(_value));

        public Watt Truncate() => new Watt(Math.Truncate(_value));

        public Watt Abs() => new Watt(Math.Abs(_value));

        public bool Equals(Watt other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Watt other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Watt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Watt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} W", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Watt other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} W";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Watt self, Watt other) => self.Equals(other);
        public static bool operator !=(Watt self, Watt other) => !self.Equals(other);

        public static bool operator <(Watt self, Watt other) => self.CompareTo(other) < 0;
        public static bool operator >(Watt self, Watt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Watt self, Watt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Watt self, Watt other) => self.CompareTo(other) >= 0;

        public static Watt operator +(Watt self, Watt other) => new Watt(self._value + other._value);
        public static Watt operator -(Watt self, Watt other) => new Watt(self._value - other._value);

        public static Watt operator *(Watt self, double other) => new Watt(self._value * other);
        public static Watt operator *(double self, Watt other) => new Watt(self * other._value);

        public static Watt operator /(Watt self, double other) => new Watt(self._value / other);

        public static explicit operator double(Watt self) => self._value;
        public static explicit operator Watt(double self) => new Watt(self);
    }
}