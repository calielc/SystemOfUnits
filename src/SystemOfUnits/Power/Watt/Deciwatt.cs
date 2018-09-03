using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    /// <summary>
    /// Represents a Deciwatt (symbol dW).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dW")]
    public readonly partial struct Deciwatt : IUnit, IEquatable<Deciwatt>, IComparable<Deciwatt> {
        private readonly double _value;

        public const string Symbol = "dW";

        public Deciwatt(double value) {
            _value = value;
        }

        public double Value => _value;

        public Deciwatt Ceiling() => new Deciwatt(Math.Ceiling(_value));

        public Deciwatt Round() => new Deciwatt(Math.Round(_value));
        public Deciwatt Round(int digits) => new Deciwatt(Math.Round(_value, digits));
        public Deciwatt Round(MidpointRounding mode) => new Deciwatt(Math.Round(_value, mode));

        public Deciwatt Floor() => new Deciwatt(Math.Floor(_value));

        public Deciwatt Truncate() => new Deciwatt(Math.Truncate(_value));

        public Deciwatt Abs() => new Deciwatt(Math.Abs(_value));

        public bool Equals(Deciwatt other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Deciwatt other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Deciwatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Deciwatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dW", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Deciwatt other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dW";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Deciwatt self, Deciwatt other) => self.Equals(other);
        public static bool operator !=(Deciwatt self, Deciwatt other) => !self.Equals(other);

        public static bool operator <(Deciwatt self, Deciwatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Deciwatt self, Deciwatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Deciwatt self, Deciwatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Deciwatt self, Deciwatt other) => self.CompareTo(other) >= 0;

        public static Deciwatt operator +(Deciwatt self, Deciwatt other) => new Deciwatt(self._value + other._value);
        public static Deciwatt operator -(Deciwatt self, Deciwatt other) => new Deciwatt(self._value - other._value);

        public static Deciwatt operator *(Deciwatt self, double other) => new Deciwatt(self._value * other);
        public static Deciwatt operator *(double self, Deciwatt other) => new Deciwatt(self * other._value);

        public static Deciwatt operator /(Deciwatt self, double other) => new Deciwatt(self._value / other);

        public static explicit operator double(Deciwatt self) => self._value;
        public static explicit operator Deciwatt(double self) => new Deciwatt(self);
    }
}