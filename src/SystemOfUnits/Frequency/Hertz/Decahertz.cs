using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    /// <summary>
    /// Represents a Decahertz (symbol daHz).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} daHz")]
    public readonly partial struct Decahertz : IUnit, IEquatable<Decahertz>, IComparable<Decahertz> {
        private readonly double _value;

        public const string Symbol = "daHz";

        public Decahertz(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decahertz Ceiling() => new Decahertz(Math.Ceiling(_value));

        public Decahertz Round() => new Decahertz(Math.Round(_value));
        public Decahertz Round(int digits) => new Decahertz(Math.Round(_value, digits));
        public Decahertz Round(MidpointRounding mode) => new Decahertz(Math.Round(_value, mode));

        public Decahertz Floor() => new Decahertz(Math.Floor(_value));

        public Decahertz Truncate() => new Decahertz(Math.Truncate(_value));

        public Decahertz Abs() => new Decahertz(Math.Abs(_value));

        public bool Equals(Decahertz other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decahertz other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decahertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decahertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} daHz", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decahertz other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} daHz";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decahertz self, Decahertz other) => self.Equals(other);
        public static bool operator !=(Decahertz self, Decahertz other) => !self.Equals(other);

        public static bool operator <(Decahertz self, Decahertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Decahertz self, Decahertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decahertz self, Decahertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decahertz self, Decahertz other) => self.CompareTo(other) >= 0;

        public static Decahertz operator +(Decahertz self, Decahertz other) => new Decahertz(self._value + other._value);
        public static Decahertz operator -(Decahertz self, Decahertz other) => new Decahertz(self._value - other._value);

        public static Decahertz operator *(Decahertz self, double other) => new Decahertz(self._value * other);
        public static Decahertz operator *(double self, Decahertz other) => new Decahertz(self * other._value);

        public static Decahertz operator /(Decahertz self, double other) => new Decahertz(self._value / other);

        public static explicit operator double(Decahertz self) => self._value;
        public static explicit operator Decahertz(double self) => new Decahertz(self);
    }
}