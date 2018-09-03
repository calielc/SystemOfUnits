using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    /// <summary>
    /// Represents a Milligram (symbol mg).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mg")]
    public readonly partial struct Milligram : IUnit, IEquatable<Milligram>, IComparable<Milligram> {
        private readonly double _value;

        public const string Symbol = "mg";

        public Milligram(double value) {
            _value = value;
        }

        public double Value => _value;

        public Milligram Ceiling() => new Milligram(Math.Ceiling(_value));

        public Milligram Round() => new Milligram(Math.Round(_value));
        public Milligram Round(int digits) => new Milligram(Math.Round(_value, digits));
        public Milligram Round(MidpointRounding mode) => new Milligram(Math.Round(_value, mode));

        public Milligram Floor() => new Milligram(Math.Floor(_value));

        public Milligram Truncate() => new Milligram(Math.Truncate(_value));

        public Milligram Abs() => new Milligram(Math.Abs(_value));

        public bool Equals(Milligram other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Milligram other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Milligram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Milligram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mg", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Milligram other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mg";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Milligram self, Milligram other) => self.Equals(other);
        public static bool operator !=(Milligram self, Milligram other) => !self.Equals(other);

        public static bool operator <(Milligram self, Milligram other) => self.CompareTo(other) < 0;
        public static bool operator >(Milligram self, Milligram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Milligram self, Milligram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Milligram self, Milligram other) => self.CompareTo(other) >= 0;

        public static Milligram operator +(Milligram self, Milligram other) => new Milligram(self._value + other._value);
        public static Milligram operator -(Milligram self, Milligram other) => new Milligram(self._value - other._value);

        public static Milligram operator *(Milligram self, double other) => new Milligram(self._value * other);
        public static Milligram operator *(double self, Milligram other) => new Milligram(self * other._value);

        public static Milligram operator /(Milligram self, double other) => new Milligram(self._value / other);

        public static explicit operator double(Milligram self) => self._value;
        public static explicit operator Milligram(double self) => new Milligram(self);
    }
}