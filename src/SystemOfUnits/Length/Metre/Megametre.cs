using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Megametre (symbol Mm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Mm")]
    public readonly partial struct Megametre : IUnit, IEquatable<Megametre>, IComparable<Megametre> {
        private readonly double _value;

        public const string Symbol = "Mm";

        public Megametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Megametre Ceiling() => new Megametre(Math.Ceiling(_value));

        public Megametre Round() => new Megametre(Math.Round(_value));
        public Megametre Round(int digits) => new Megametre(Math.Round(_value, digits));
        public Megametre Round(MidpointRounding mode) => new Megametre(Math.Round(_value, mode));

        public Megametre Floor() => new Megametre(Math.Floor(_value));

        public Megametre Truncate() => new Megametre(Math.Truncate(_value));

        public Megametre Abs() => new Megametre(Math.Abs(_value));

        public bool Equals(Megametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Megametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Megametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Megametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Mm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Megametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Mm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Megametre self, Megametre other) => self.Equals(other);
        public static bool operator !=(Megametre self, Megametre other) => !self.Equals(other);

        public static bool operator <(Megametre self, Megametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Megametre self, Megametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Megametre self, Megametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Megametre self, Megametre other) => self.CompareTo(other) >= 0;

        public static Megametre operator +(Megametre self, Megametre other) => new Megametre(self._value + other._value);
        public static Megametre operator -(Megametre self, Megametre other) => new Megametre(self._value - other._value);

        public static Megametre operator *(Megametre self, double other) => new Megametre(self._value * other);
        public static Megametre operator *(double self, Megametre other) => new Megametre(self * other._value);

        public static Megametre operator /(Megametre self, double other) => new Megametre(self._value / other);

        public static explicit operator double(Megametre self) => self._value;
        public static explicit operator Megametre(double self) => new Megametre(self);
    }
}