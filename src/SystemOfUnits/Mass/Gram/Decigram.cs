using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    /// <summary>
    /// Represents a Decigram (symbol dg).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dg")]
    public readonly partial struct Decigram : IUnit, IEquatable<Decigram>, IComparable<Decigram> {
        private readonly double _value;

        public const string Symbol = "dg";

        public Decigram(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decigram Ceiling() => new Decigram(Math.Ceiling(_value));

        public Decigram Round() => new Decigram(Math.Round(_value));
        public Decigram Round(int digits) => new Decigram(Math.Round(_value, digits));
        public Decigram Round(MidpointRounding mode) => new Decigram(Math.Round(_value, mode));

        public Decigram Floor() => new Decigram(Math.Floor(_value));

        public Decigram Truncate() => new Decigram(Math.Truncate(_value));

        public Decigram Abs() => new Decigram(Math.Abs(_value));

        public bool Equals(Decigram other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decigram other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decigram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decigram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dg", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decigram other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dg";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decigram self, Decigram other) => self.Equals(other);
        public static bool operator !=(Decigram self, Decigram other) => !self.Equals(other);

        public static bool operator <(Decigram self, Decigram other) => self.CompareTo(other) < 0;
        public static bool operator >(Decigram self, Decigram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decigram self, Decigram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decigram self, Decigram other) => self.CompareTo(other) >= 0;

        public static Decigram operator +(Decigram self, Decigram other) => new Decigram(self._value + other._value);
        public static Decigram operator -(Decigram self, Decigram other) => new Decigram(self._value - other._value);

        public static Decigram operator *(Decigram self, double other) => new Decigram(self._value * other);
        public static Decigram operator *(double self, Decigram other) => new Decigram(self * other._value);

        public static Decigram operator /(Decigram self, double other) => new Decigram(self._value / other);

        public static explicit operator double(Decigram self) => self._value;
        public static explicit operator Decigram(double self) => new Decigram(self);
    }
}