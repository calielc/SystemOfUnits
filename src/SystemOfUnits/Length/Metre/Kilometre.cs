using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Kilometre (symbol km).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} km")]
    public readonly partial struct Kilometre : IUnit, IEquatable<Kilometre>, IComparable<Kilometre> {
        private readonly double _value;

        public const string Symbol = "km";

        public Kilometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kilometre Ceiling() => new Kilometre(Math.Ceiling(_value));

        public Kilometre Round() => new Kilometre(Math.Round(_value));
        public Kilometre Round(int digits) => new Kilometre(Math.Round(_value, digits));
        public Kilometre Round(MidpointRounding mode) => new Kilometre(Math.Round(_value, mode));

        public Kilometre Floor() => new Kilometre(Math.Floor(_value));

        public Kilometre Truncate() => new Kilometre(Math.Truncate(_value));

        public Kilometre Abs() => new Kilometre(Math.Abs(_value));

        public bool Equals(Kilometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kilometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} km", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} km";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kilometre self, Kilometre other) => self.Equals(other);
        public static bool operator !=(Kilometre self, Kilometre other) => !self.Equals(other);

        public static bool operator <(Kilometre self, Kilometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilometre self, Kilometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilometre self, Kilometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilometre self, Kilometre other) => self.CompareTo(other) >= 0;

        public static Kilometre operator +(Kilometre self, Kilometre other) => new Kilometre(self._value + other._value);
        public static Kilometre operator -(Kilometre self, Kilometre other) => new Kilometre(self._value - other._value);

        public static Kilometre operator *(Kilometre self, double other) => new Kilometre(self._value * other);
        public static Kilometre operator *(double self, Kilometre other) => new Kilometre(self * other._value);

        public static Kilometre operator /(Kilometre self, double other) => new Kilometre(self._value / other);

        public static explicit operator double(Kilometre self) => self._value;
        public static explicit operator Kilometre(double self) => new Kilometre(self);
    }
}