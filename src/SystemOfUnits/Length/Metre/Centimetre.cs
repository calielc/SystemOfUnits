using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Centimetre (symbol cm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cm")]
    public readonly partial struct Centimetre : IUnit, IEquatable<Centimetre>, IComparable<Centimetre> {
        private readonly double _value;

        public const string Symbol = "cm";

        public Centimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Centimetre Ceiling() => new Centimetre(Math.Ceiling(_value));

        public Centimetre Round() => new Centimetre(Math.Round(_value));
        public Centimetre Round(int digits) => new Centimetre(Math.Round(_value, digits));
        public Centimetre Round(MidpointRounding mode) => new Centimetre(Math.Round(_value, mode));

        public Centimetre Floor() => new Centimetre(Math.Floor(_value));

        public Centimetre Truncate() => new Centimetre(Math.Truncate(_value));

        public Centimetre Abs() => new Centimetre(Math.Abs(_value));

        public bool Equals(Centimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Centimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} cm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Centimetre self, Centimetre other) => self.Equals(other);
        public static bool operator !=(Centimetre self, Centimetre other) => !self.Equals(other);

        public static bool operator <(Centimetre self, Centimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(Centimetre self, Centimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centimetre self, Centimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centimetre self, Centimetre other) => self.CompareTo(other) >= 0;

        public static Centimetre operator +(Centimetre self, Centimetre other) => new Centimetre(self._value + other._value);
        public static Centimetre operator -(Centimetre self, Centimetre other) => new Centimetre(self._value - other._value);

        public static Centimetre operator *(Centimetre self, double other) => new Centimetre(self._value * other);
        public static Centimetre operator *(double self, Centimetre other) => new Centimetre(self * other._value);

        public static Centimetre operator /(Centimetre self, double other) => new Centimetre(self._value / other);

        public static explicit operator double(Centimetre self) => self._value;
        public static explicit operator Centimetre(double self) => new Centimetre(self);
    }
}