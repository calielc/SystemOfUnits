using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    /// <summary>
    /// Represents a Minute (symbol minutes).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} minutes")]
    public readonly partial struct Minute : IUnit, IEquatable<Minute>, IComparable<Minute> {
        private readonly double _value;

        public const string Symbol = "minutes";

        public Minute(double value) {
            _value = value;
        }

        public double Value => _value;

        public Minute Ceiling() => new Minute(Math.Ceiling(_value));

        public Minute Round() => new Minute(Math.Round(_value));
        public Minute Round(int digits) => new Minute(Math.Round(_value, digits));
        public Minute Round(MidpointRounding mode) => new Minute(Math.Round(_value, mode));

        public Minute Floor() => new Minute(Math.Floor(_value));

        public Minute Truncate() => new Minute(Math.Truncate(_value));

        public Minute Abs() => new Minute(Math.Abs(_value));

        public bool Equals(Minute other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Minute other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Minute other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Minute)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} minutes", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Minute other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} minutes";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Minute self, Minute other) => self.Equals(other);
        public static bool operator !=(Minute self, Minute other) => !self.Equals(other);

        public static bool operator <(Minute self, Minute other) => self.CompareTo(other) < 0;
        public static bool operator >(Minute self, Minute other) => self.CompareTo(other) > 0;
        public static bool operator <=(Minute self, Minute other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Minute self, Minute other) => self.CompareTo(other) >= 0;

        public static Minute operator +(Minute self, Minute other) => new Minute(self._value + other._value);
        public static Minute operator -(Minute self, Minute other) => new Minute(self._value - other._value);

        public static Minute operator *(Minute self, double other) => new Minute(self._value * other);
        public static Minute operator *(double self, Minute other) => new Minute(self * other._value);

        public static Minute operator /(Minute self, double other) => new Minute(self._value / other);

        public static explicit operator double(Minute self) => self._value;
        public static explicit operator Minute(double self) => new Minute(self);
    }
}