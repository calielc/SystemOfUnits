using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    /// <summary>
    /// Represents a Centihertz (symbol cHz).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cHz")]
    public readonly partial struct Centihertz : IUnit, IEquatable<Centihertz>, IComparable<Centihertz> {
        private readonly double _value;

        public const string Symbol = "cHz";

        public Centihertz(double value) {
            _value = value;
        }

        public double Value => _value;

        public Centihertz Ceiling() => new Centihertz(Math.Ceiling(_value));

        public Centihertz Round() => new Centihertz(Math.Round(_value));
        public Centihertz Round(int digits) => new Centihertz(Math.Round(_value, digits));
        public Centihertz Round(MidpointRounding mode) => new Centihertz(Math.Round(_value, mode));

        public Centihertz Floor() => new Centihertz(Math.Floor(_value));

        public Centihertz Truncate() => new Centihertz(Math.Truncate(_value));

        public Centihertz Abs() => new Centihertz(Math.Abs(_value));

        public bool Equals(Centihertz other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Centihertz other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centihertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centihertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cHz", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centihertz other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} cHz";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Centihertz self, Centihertz other) => self.Equals(other);
        public static bool operator !=(Centihertz self, Centihertz other) => !self.Equals(other);

        public static bool operator <(Centihertz self, Centihertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Centihertz self, Centihertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centihertz self, Centihertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centihertz self, Centihertz other) => self.CompareTo(other) >= 0;

        public static Centihertz operator +(Centihertz self, Centihertz other) => new Centihertz(self._value + other._value);
        public static Centihertz operator -(Centihertz self, Centihertz other) => new Centihertz(self._value - other._value);

        public static Centihertz operator *(Centihertz self, double other) => new Centihertz(self._value * other);
        public static Centihertz operator *(double self, Centihertz other) => new Centihertz(self * other._value);

        public static Centihertz operator /(Centihertz self, double other) => new Centihertz(self._value / other);

        public static explicit operator double(Centihertz self) => self._value;
        public static explicit operator Centihertz(double self) => new Centihertz(self);
    }
}