using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Femtometre (symbol fm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} fm")]
    public readonly partial struct Femtometre : IUnit, IEquatable<Femtometre>, IComparable<Femtometre> {
        private readonly double _value;

        public const string Symbol = "fm";

        public Femtometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Femtometre Ceiling() => new Femtometre(Math.Ceiling(_value));

        public Femtometre Round() => new Femtometre(Math.Round(_value));
        public Femtometre Round(int digits) => new Femtometre(Math.Round(_value, digits));
        public Femtometre Round(MidpointRounding mode) => new Femtometre(Math.Round(_value, mode));

        public Femtometre Floor() => new Femtometre(Math.Floor(_value));

        public Femtometre Truncate() => new Femtometre(Math.Truncate(_value));

        public Femtometre Abs() => new Femtometre(Math.Abs(_value));

        public bool Equals(Femtometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Femtometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Femtometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Femtometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} fm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Femtometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} fm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Femtometre self, Femtometre other) => self.Equals(other);
        public static bool operator !=(Femtometre self, Femtometre other) => !self.Equals(other);

        public static bool operator <(Femtometre self, Femtometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Femtometre self, Femtometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Femtometre self, Femtometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Femtometre self, Femtometre other) => self.CompareTo(other) >= 0;

        public static Femtometre operator +(Femtometre self, Femtometre other) => new Femtometre(self._value + other._value);
        public static Femtometre operator -(Femtometre self, Femtometre other) => new Femtometre(self._value - other._value);

        public static Femtometre operator *(Femtometre self, double other) => new Femtometre(self._value * other);
        public static Femtometre operator *(double self, Femtometre other) => new Femtometre(self * other._value);

        public static Femtometre operator /(Femtometre self, double other) => new Femtometre(self._value / other);

        public static explicit operator double(Femtometre self) => self._value;
        public static explicit operator Femtometre(double self) => new Femtometre(self);
    }
}