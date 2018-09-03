using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    /// <summary>
    /// Represents a Decihertz (symbol dHz).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dHz")]
    public readonly partial struct Decihertz : IUnit, IEquatable<Decihertz>, IComparable<Decihertz> {
        private readonly double _value;

        public const string Symbol = "dHz";

        public Decihertz(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decihertz Ceiling() => new Decihertz(Math.Ceiling(_value));

        public Decihertz Round() => new Decihertz(Math.Round(_value));
        public Decihertz Round(int digits) => new Decihertz(Math.Round(_value, digits));
        public Decihertz Round(MidpointRounding mode) => new Decihertz(Math.Round(_value, mode));

        public Decihertz Floor() => new Decihertz(Math.Floor(_value));

        public Decihertz Truncate() => new Decihertz(Math.Truncate(_value));

        public Decihertz Abs() => new Decihertz(Math.Abs(_value));

        public bool Equals(Decihertz other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decihertz other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decihertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decihertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dHz", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decihertz other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dHz";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decihertz self, Decihertz other) => self.Equals(other);
        public static bool operator !=(Decihertz self, Decihertz other) => !self.Equals(other);

        public static bool operator <(Decihertz self, Decihertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Decihertz self, Decihertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decihertz self, Decihertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decihertz self, Decihertz other) => self.CompareTo(other) >= 0;

        public static Decihertz operator +(Decihertz self, Decihertz other) => new Decihertz(self._value + other._value);
        public static Decihertz operator -(Decihertz self, Decihertz other) => new Decihertz(self._value - other._value);

        public static Decihertz operator *(Decihertz self, double other) => new Decihertz(self._value * other);
        public static Decihertz operator *(double self, Decihertz other) => new Decihertz(self * other._value);

        public static Decihertz operator /(Decihertz self, double other) => new Decihertz(self._value / other);

        public static explicit operator double(Decihertz self) => self._value;
        public static explicit operator Decihertz(double self) => new Decihertz(self);
    }
}