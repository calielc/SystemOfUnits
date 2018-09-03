using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Terametre (symbol Tm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Tm")]
    public readonly partial struct Terametre : IUnit, IEquatable<Terametre>, IComparable<Terametre> {
        private readonly double _value;

        public const string Symbol = "Tm";

        public Terametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Terametre Ceiling() => new Terametre(Math.Ceiling(_value));

        public Terametre Round() => new Terametre(Math.Round(_value));
        public Terametre Round(int digits) => new Terametre(Math.Round(_value, digits));
        public Terametre Round(MidpointRounding mode) => new Terametre(Math.Round(_value, mode));

        public Terametre Floor() => new Terametre(Math.Floor(_value));

        public Terametre Truncate() => new Terametre(Math.Truncate(_value));

        public Terametre Abs() => new Terametre(Math.Abs(_value));

        public bool Equals(Terametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Terametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Terametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Terametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Tm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Terametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Tm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Terametre self, Terametre other) => self.Equals(other);
        public static bool operator !=(Terametre self, Terametre other) => !self.Equals(other);

        public static bool operator <(Terametre self, Terametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Terametre self, Terametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Terametre self, Terametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Terametre self, Terametre other) => self.CompareTo(other) >= 0;

        public static Terametre operator +(Terametre self, Terametre other) => new Terametre(self._value + other._value);
        public static Terametre operator -(Terametre self, Terametre other) => new Terametre(self._value - other._value);

        public static Terametre operator *(Terametre self, double other) => new Terametre(self._value * other);
        public static Terametre operator *(double self, Terametre other) => new Terametre(self * other._value);

        public static Terametre operator /(Terametre self, double other) => new Terametre(self._value / other);

        public static explicit operator double(Terametre self) => self._value;
        public static explicit operator Terametre(double self) => new Terametre(self);
    }
}