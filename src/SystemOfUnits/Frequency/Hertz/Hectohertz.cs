using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Frequency.Hertz {
    /// <summary>
    /// Represents a Hectohertz (symbol hHz).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hHz")]
    public readonly partial struct Hectohertz : IUnit, IEquatable<Hectohertz>, IComparable<Hectohertz> {
        private readonly double _value;

        public const string Symbol = "hHz";

        public Hectohertz(double value) {
            _value = value;
        }

        public double Value => _value;

        public Hectohertz Ceiling() => new Hectohertz(Math.Ceiling(_value));

        public Hectohertz Round() => new Hectohertz(Math.Round(_value));
        public Hectohertz Round(int digits) => new Hectohertz(Math.Round(_value, digits));
        public Hectohertz Round(MidpointRounding mode) => new Hectohertz(Math.Round(_value, mode));

        public Hectohertz Floor() => new Hectohertz(Math.Floor(_value));

        public Hectohertz Truncate() => new Hectohertz(Math.Truncate(_value));

        public Hectohertz Abs() => new Hectohertz(Math.Abs(_value));

        public bool Equals(Hectohertz other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Hectohertz other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectohertz other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectohertz)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hHz", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectohertz other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hHz";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Hectohertz self, Hectohertz other) => self.Equals(other);
        public static bool operator !=(Hectohertz self, Hectohertz other) => !self.Equals(other);

        public static bool operator <(Hectohertz self, Hectohertz other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectohertz self, Hectohertz other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectohertz self, Hectohertz other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectohertz self, Hectohertz other) => self.CompareTo(other) >= 0;

        public static Hectohertz operator +(Hectohertz self, Hectohertz other) => new Hectohertz(self._value + other._value);
        public static Hectohertz operator -(Hectohertz self, Hectohertz other) => new Hectohertz(self._value - other._value);

        public static Hectohertz operator *(Hectohertz self, double other) => new Hectohertz(self._value * other);
        public static Hectohertz operator *(double self, Hectohertz other) => new Hectohertz(self * other._value);

        public static Hectohertz operator /(Hectohertz self, double other) => new Hectohertz(self._value / other);

        public static explicit operator double(Hectohertz self) => self._value;
        public static explicit operator Hectohertz(double self) => new Hectohertz(self);
    }
}