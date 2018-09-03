using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Power.Watt {
    /// <summary>
    /// Represents a Hectowatt (symbol hW).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hW")]
    public readonly partial struct Hectowatt : IUnit, IEquatable<Hectowatt>, IComparable<Hectowatt> {
        private readonly double _value;

        public const string Symbol = "hW";

        public Hectowatt(double value) {
            _value = value;
        }

        public double Value => _value;

        public Hectowatt Ceiling() => new Hectowatt(Math.Ceiling(_value));

        public Hectowatt Round() => new Hectowatt(Math.Round(_value));
        public Hectowatt Round(int digits) => new Hectowatt(Math.Round(_value, digits));
        public Hectowatt Round(MidpointRounding mode) => new Hectowatt(Math.Round(_value, mode));

        public Hectowatt Floor() => new Hectowatt(Math.Floor(_value));

        public Hectowatt Truncate() => new Hectowatt(Math.Truncate(_value));

        public Hectowatt Abs() => new Hectowatt(Math.Abs(_value));

        public bool Equals(Hectowatt other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Hectowatt other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectowatt other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectowatt)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hW", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectowatt other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hW";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Hectowatt self, Hectowatt other) => self.Equals(other);
        public static bool operator !=(Hectowatt self, Hectowatt other) => !self.Equals(other);

        public static bool operator <(Hectowatt self, Hectowatt other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectowatt self, Hectowatt other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectowatt self, Hectowatt other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectowatt self, Hectowatt other) => self.CompareTo(other) >= 0;

        public static Hectowatt operator +(Hectowatt self, Hectowatt other) => new Hectowatt(self._value + other._value);
        public static Hectowatt operator -(Hectowatt self, Hectowatt other) => new Hectowatt(self._value - other._value);

        public static Hectowatt operator *(Hectowatt self, double other) => new Hectowatt(self._value * other);
        public static Hectowatt operator *(double self, Hectowatt other) => new Hectowatt(self * other._value);

        public static Hectowatt operator /(Hectowatt self, double other) => new Hectowatt(self._value / other);

        public static explicit operator double(Hectowatt self) => self._value;
        public static explicit operator Hectowatt(double self) => new Hectowatt(self);
    }
}