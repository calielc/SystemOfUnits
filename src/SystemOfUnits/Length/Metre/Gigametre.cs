using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Gigametre (symbol Gm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Gm")]
    public readonly partial struct Gigametre : IUnit, IEquatable<Gigametre>, IComparable<Gigametre> {
        private readonly double _value;

        public const string Symbol = "Gm";

        public Gigametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Gigametre Ceiling() => new Gigametre(Math.Ceiling(_value));

        public Gigametre Round() => new Gigametre(Math.Round(_value));
        public Gigametre Round(int digits) => new Gigametre(Math.Round(_value, digits));
        public Gigametre Round(MidpointRounding mode) => new Gigametre(Math.Round(_value, mode));

        public Gigametre Floor() => new Gigametre(Math.Floor(_value));

        public Gigametre Truncate() => new Gigametre(Math.Truncate(_value));

        public Gigametre Abs() => new Gigametre(Math.Abs(_value));

        public bool Equals(Gigametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Gigametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gigametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gigametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Gm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gigametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Gm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Gigametre self, Gigametre other) => self.Equals(other);
        public static bool operator !=(Gigametre self, Gigametre other) => !self.Equals(other);

        public static bool operator <(Gigametre self, Gigametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Gigametre self, Gigametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gigametre self, Gigametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gigametre self, Gigametre other) => self.CompareTo(other) >= 0;

        public static Gigametre operator +(Gigametre self, Gigametre other) => new Gigametre(self._value + other._value);
        public static Gigametre operator -(Gigametre self, Gigametre other) => new Gigametre(self._value - other._value);

        public static Gigametre operator *(Gigametre self, double other) => new Gigametre(self._value * other);
        public static Gigametre operator *(double self, Gigametre other) => new Gigametre(self * other._value);

        public static Gigametre operator /(Gigametre self, double other) => new Gigametre(self._value / other);

        public static explicit operator double(Gigametre self) => self._value;
        public static explicit operator Gigametre(double self) => new Gigametre(self);
    }
}