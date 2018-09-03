using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    /// <summary>
    /// Represents a Decawatt (symbol daW).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} daW")]
    public readonly partial struct Decawatt : IUnit, IEquatable<Decawatt>, IComparable<Decawatt> {
        private readonly double _value;

        public const string Symbol = "daW";

        public Decawatt(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decawatt Ceiling() => new Decawatt(Math.Ceiling(_value));

        public Decawatt Round() => new Decawatt(Math.Round(_value));
        public Decawatt Round(int digits) => new Decawatt(Math.Round(_value, digits));
        public Decawatt Round(MidpointRounding mode) => new Decawatt(Math.Round(_value, mode));

        public Decawatt Floor() => new Decawatt(Math.Floor(_value));

        public Decawatt Truncate() => new Decawatt(Math.Truncate(_value));

        public Decawatt Abs() => new Decawatt(Math.Abs(_value));

        public bool Equals(Decawatt other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decawatt other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decawatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decawatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} daW", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decawatt other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} daW";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decawatt self, Decawatt other) => self.Equals(other);
        public static bool operator !=(Decawatt self, Decawatt other) => !self.Equals(other);

        public static bool operator <(Decawatt self, Decawatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Decawatt self, Decawatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decawatt self, Decawatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decawatt self, Decawatt other) => self.CompareTo(other) >= 0;

        public static Decawatt operator +(Decawatt self, Decawatt other) => new Decawatt(self._value + other._value);
        public static Decawatt operator -(Decawatt self, Decawatt other) => new Decawatt(self._value - other._value);

        public static Decawatt operator *(Decawatt self, double other) => new Decawatt(self._value * other);
        public static Decawatt operator *(double self, Decawatt other) => new Decawatt(self * other._value);

        public static Decawatt operator /(Decawatt self, double other) => new Decawatt(self._value / other);

        public static explicit operator double(Decawatt self) => self._value;
        public static explicit operator Decawatt(double self) => new Decawatt(self);
    }
}