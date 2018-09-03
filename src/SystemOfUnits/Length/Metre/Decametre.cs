using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Decametre (symbol dam).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dam")]
    public readonly partial struct Decametre : IUnit, IEquatable<Decametre>, IComparable<Decametre> {
        private readonly double _value;

        public const string Symbol = "dam";

        public Decametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decametre Ceiling() => new Decametre(Math.Ceiling(_value));

        public Decametre Round() => new Decametre(Math.Round(_value));
        public Decametre Round(int digits) => new Decametre(Math.Round(_value, digits));
        public Decametre Round(MidpointRounding mode) => new Decametre(Math.Round(_value, mode));

        public Decametre Floor() => new Decametre(Math.Floor(_value));

        public Decametre Truncate() => new Decametre(Math.Truncate(_value));

        public Decametre Abs() => new Decametre(Math.Abs(_value));

        public bool Equals(Decametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dam", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dam";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decametre self, Decametre other) => self.Equals(other);
        public static bool operator !=(Decametre self, Decametre other) => !self.Equals(other);

        public static bool operator <(Decametre self, Decametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Decametre self, Decametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decametre self, Decametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decametre self, Decametre other) => self.CompareTo(other) >= 0;

        public static Decametre operator +(Decametre self, Decametre other) => new Decametre(self._value + other._value);
        public static Decametre operator -(Decametre self, Decametre other) => new Decametre(self._value - other._value);

        public static Decametre operator *(Decametre self, double other) => new Decametre(self._value * other);
        public static Decametre operator *(double self, Decametre other) => new Decametre(self * other._value);

        public static Decametre operator /(Decametre self, double other) => new Decametre(self._value / other);

        public static explicit operator double(Decametre self) => self._value;
        public static explicit operator Decametre(double self) => new Decametre(self);
    }
}