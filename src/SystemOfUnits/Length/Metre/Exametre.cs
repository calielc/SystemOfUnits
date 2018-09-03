using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Exametre (symbol Em).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Em")]
    public readonly partial struct Exametre : IUnit, IEquatable<Exametre>, IComparable<Exametre> {
        private readonly double _value;

        public const string Symbol = "Em";

        public Exametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Exametre Ceiling() => new Exametre(Math.Ceiling(_value));

        public Exametre Round() => new Exametre(Math.Round(_value));
        public Exametre Round(int digits) => new Exametre(Math.Round(_value, digits));
        public Exametre Round(MidpointRounding mode) => new Exametre(Math.Round(_value, mode));

        public Exametre Floor() => new Exametre(Math.Floor(_value));

        public Exametre Truncate() => new Exametre(Math.Truncate(_value));

        public Exametre Abs() => new Exametre(Math.Abs(_value));

        public bool Equals(Exametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Exametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Exametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Exametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Em", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Exametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Em";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Exametre self, Exametre other) => self.Equals(other);
        public static bool operator !=(Exametre self, Exametre other) => !self.Equals(other);

        public static bool operator <(Exametre self, Exametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Exametre self, Exametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Exametre self, Exametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Exametre self, Exametre other) => self.CompareTo(other) >= 0;

        public static Exametre operator +(Exametre self, Exametre other) => new Exametre(self._value + other._value);
        public static Exametre operator -(Exametre self, Exametre other) => new Exametre(self._value - other._value);

        public static Exametre operator *(Exametre self, double other) => new Exametre(self._value * other);
        public static Exametre operator *(double self, Exametre other) => new Exametre(self * other._value);

        public static Exametre operator /(Exametre self, double other) => new Exametre(self._value / other);

        public static explicit operator double(Exametre self) => self._value;
        public static explicit operator Exametre(double self) => new Exametre(self);
    }
}