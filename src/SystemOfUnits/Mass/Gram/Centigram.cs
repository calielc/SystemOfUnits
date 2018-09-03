using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    /// <summary>
    /// Represents a Centigram (symbol cg).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cg")]
    public readonly partial struct Centigram : IUnit, IEquatable<Centigram>, IComparable<Centigram> {
        private readonly double _value;

        public const string Symbol = "cg";

        public Centigram(double value) {
            _value = value;
        }

        public double Value => _value;

        public Centigram Ceiling() => new Centigram(Math.Ceiling(_value));

        public Centigram Round() => new Centigram(Math.Round(_value));
        public Centigram Round(int digits) => new Centigram(Math.Round(_value, digits));
        public Centigram Round(MidpointRounding mode) => new Centigram(Math.Round(_value, mode));

        public Centigram Floor() => new Centigram(Math.Floor(_value));

        public Centigram Truncate() => new Centigram(Math.Truncate(_value));

        public Centigram Abs() => new Centigram(Math.Abs(_value));

        public bool Equals(Centigram other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Centigram other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centigram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centigram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cg", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centigram other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} cg";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Centigram self, Centigram other) => self.Equals(other);
        public static bool operator !=(Centigram self, Centigram other) => !self.Equals(other);

        public static bool operator <(Centigram self, Centigram other) => self.CompareTo(other) < 0;
        public static bool operator >(Centigram self, Centigram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centigram self, Centigram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centigram self, Centigram other) => self.CompareTo(other) >= 0;

        public static Centigram operator +(Centigram self, Centigram other) => new Centigram(self._value + other._value);
        public static Centigram operator -(Centigram self, Centigram other) => new Centigram(self._value - other._value);

        public static Centigram operator *(Centigram self, double other) => new Centigram(self._value * other);
        public static Centigram operator *(double self, Centigram other) => new Centigram(self * other._value);

        public static Centigram operator /(Centigram self, double other) => new Centigram(self._value / other);

        public static explicit operator double(Centigram self) => self._value;
        public static explicit operator Centigram(double self) => new Centigram(self);
    }
}