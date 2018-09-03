using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    /// <summary>
    /// Represents a Milliwatt (symbol mW).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mW")]
    public readonly partial struct Milliwatt : IUnit, IEquatable<Milliwatt>, IComparable<Milliwatt> {
        private readonly double _value;

        public const string Symbol = "mW";

        public Milliwatt(double value) {
            _value = value;
        }

        public double Value => _value;

        public Milliwatt Ceiling() => new Milliwatt(Math.Ceiling(_value));

        public Milliwatt Round() => new Milliwatt(Math.Round(_value));
        public Milliwatt Round(int digits) => new Milliwatt(Math.Round(_value, digits));
        public Milliwatt Round(MidpointRounding mode) => new Milliwatt(Math.Round(_value, mode));

        public Milliwatt Floor() => new Milliwatt(Math.Floor(_value));

        public Milliwatt Truncate() => new Milliwatt(Math.Truncate(_value));

        public Milliwatt Abs() => new Milliwatt(Math.Abs(_value));

        public bool Equals(Milliwatt other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Milliwatt other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Milliwatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Milliwatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mW", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Milliwatt other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mW";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Milliwatt self, Milliwatt other) => self.Equals(other);
        public static bool operator !=(Milliwatt self, Milliwatt other) => !self.Equals(other);

        public static bool operator <(Milliwatt self, Milliwatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Milliwatt self, Milliwatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Milliwatt self, Milliwatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Milliwatt self, Milliwatt other) => self.CompareTo(other) >= 0;

        public static Milliwatt operator +(Milliwatt self, Milliwatt other) => new Milliwatt(self._value + other._value);
        public static Milliwatt operator -(Milliwatt self, Milliwatt other) => new Milliwatt(self._value - other._value);

        public static Milliwatt operator *(Milliwatt self, double other) => new Milliwatt(self._value * other);
        public static Milliwatt operator *(double self, Milliwatt other) => new Milliwatt(self * other._value);

        public static Milliwatt operator /(Milliwatt self, double other) => new Milliwatt(self._value / other);

        public static explicit operator double(Milliwatt self) => self._value;
        public static explicit operator Milliwatt(double self) => new Milliwatt(self);
    }
}