using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    /// <summary>
    /// Represents a Kilowatt (symbol kW).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kW")]
    public readonly partial struct Kilowatt : IUnit, IEquatable<Kilowatt>, IComparable<Kilowatt> {
        private readonly double _value;

        public const string Symbol = "kW";

        public Kilowatt(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kilowatt Ceiling() => new Kilowatt(Math.Ceiling(_value));

        public Kilowatt Round() => new Kilowatt(Math.Round(_value));
        public Kilowatt Round(int digits) => new Kilowatt(Math.Round(_value, digits));
        public Kilowatt Round(MidpointRounding mode) => new Kilowatt(Math.Round(_value, mode));

        public Kilowatt Floor() => new Kilowatt(Math.Floor(_value));

        public Kilowatt Truncate() => new Kilowatt(Math.Truncate(_value));

        public Kilowatt Abs() => new Kilowatt(Math.Abs(_value));

        public bool Equals(Kilowatt other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kilowatt other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilowatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilowatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kW", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilowatt other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} kW";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kilowatt self, Kilowatt other) => self.Equals(other);
        public static bool operator !=(Kilowatt self, Kilowatt other) => !self.Equals(other);

        public static bool operator <(Kilowatt self, Kilowatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilowatt self, Kilowatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilowatt self, Kilowatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilowatt self, Kilowatt other) => self.CompareTo(other) >= 0;

        public static Kilowatt operator +(Kilowatt self, Kilowatt other) => new Kilowatt(self._value + other._value);
        public static Kilowatt operator -(Kilowatt self, Kilowatt other) => new Kilowatt(self._value - other._value);

        public static Kilowatt operator *(Kilowatt self, double other) => new Kilowatt(self._value * other);
        public static Kilowatt operator *(double self, Kilowatt other) => new Kilowatt(self * other._value);

        public static Kilowatt operator /(Kilowatt self, double other) => new Kilowatt(self._value / other);

        public static explicit operator double(Kilowatt self) => self._value;
        public static explicit operator Kilowatt(double self) => new Kilowatt(self);
    }
}