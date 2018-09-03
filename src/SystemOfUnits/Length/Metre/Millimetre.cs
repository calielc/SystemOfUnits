using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Millimetre (symbol mm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mm")]
    public readonly partial struct Millimetre : IUnit, IEquatable<Millimetre>, IComparable<Millimetre> {
        private readonly double _value;

        public const string Symbol = "mm";

        public Millimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Millimetre Ceiling() => new Millimetre(Math.Ceiling(_value));

        public Millimetre Round() => new Millimetre(Math.Round(_value));
        public Millimetre Round(int digits) => new Millimetre(Math.Round(_value, digits));
        public Millimetre Round(MidpointRounding mode) => new Millimetre(Math.Round(_value, mode));

        public Millimetre Floor() => new Millimetre(Math.Floor(_value));

        public Millimetre Truncate() => new Millimetre(Math.Truncate(_value));

        public Millimetre Abs() => new Millimetre(Math.Abs(_value));

        public bool Equals(Millimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Millimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Millimetre self, Millimetre other) => self.Equals(other);
        public static bool operator !=(Millimetre self, Millimetre other) => !self.Equals(other);

        public static bool operator <(Millimetre self, Millimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(Millimetre self, Millimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millimetre self, Millimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millimetre self, Millimetre other) => self.CompareTo(other) >= 0;

        public static Millimetre operator +(Millimetre self, Millimetre other) => new Millimetre(self._value + other._value);
        public static Millimetre operator -(Millimetre self, Millimetre other) => new Millimetre(self._value - other._value);

        public static Millimetre operator *(Millimetre self, double other) => new Millimetre(self._value * other);
        public static Millimetre operator *(double self, Millimetre other) => new Millimetre(self * other._value);

        public static Millimetre operator /(Millimetre self, double other) => new Millimetre(self._value / other);

        public static explicit operator double(Millimetre self) => self._value;
        public static explicit operator Millimetre(double self) => new Millimetre(self);
    }
}