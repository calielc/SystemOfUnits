using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Attometre (symbol am).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} am")]
    public readonly partial struct Attometre : IUnit, IEquatable<Attometre>, IComparable<Attometre> {
        private readonly double _value;

        public const string Symbol = "am";

        public Attometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Attometre Ceiling() => new Attometre(Math.Ceiling(_value));

        public Attometre Round() => new Attometre(Math.Round(_value));
        public Attometre Round(int digits) => new Attometre(Math.Round(_value, digits));
        public Attometre Round(MidpointRounding mode) => new Attometre(Math.Round(_value, mode));

        public Attometre Floor() => new Attometre(Math.Floor(_value));

        public Attometre Truncate() => new Attometre(Math.Truncate(_value));

        public Attometre Abs() => new Attometre(Math.Abs(_value));

        public bool Equals(Attometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Attometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Attometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Attometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} am", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Attometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} am";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Attometre self, Attometre other) => self.Equals(other);
        public static bool operator !=(Attometre self, Attometre other) => !self.Equals(other);

        public static bool operator <(Attometre self, Attometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Attometre self, Attometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Attometre self, Attometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Attometre self, Attometre other) => self.CompareTo(other) >= 0;

        public static Attometre operator +(Attometre self, Attometre other) => new Attometre(self._value + other._value);
        public static Attometre operator -(Attometre self, Attometre other) => new Attometre(self._value - other._value);

        public static Attometre operator *(Attometre self, double other) => new Attometre(self._value * other);
        public static Attometre operator *(double self, Attometre other) => new Attometre(self * other._value);

        public static Attometre operator /(Attometre self, double other) => new Attometre(self._value / other);

        public static explicit operator double(Attometre self) => self._value;
        public static explicit operator Attometre(double self) => new Attometre(self);
    }
}