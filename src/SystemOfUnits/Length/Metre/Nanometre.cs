using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Nanometre (symbol nm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} nm")]
    public readonly partial struct Nanometre : IUnit, IEquatable<Nanometre>, IComparable<Nanometre> {
        private readonly double _value;

        public const string Symbol = "nm";

        public Nanometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Nanometre Ceiling() => new Nanometre(Math.Ceiling(_value));

        public Nanometre Round() => new Nanometre(Math.Round(_value));
        public Nanometre Round(int digits) => new Nanometre(Math.Round(_value, digits));
        public Nanometre Round(MidpointRounding mode) => new Nanometre(Math.Round(_value, mode));

        public Nanometre Floor() => new Nanometre(Math.Floor(_value));

        public Nanometre Truncate() => new Nanometre(Math.Truncate(_value));

        public Nanometre Abs() => new Nanometre(Math.Abs(_value));

        public bool Equals(Nanometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Nanometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Nanometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Nanometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} nm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Nanometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} nm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Nanometre self, Nanometre other) => self.Equals(other);
        public static bool operator !=(Nanometre self, Nanometre other) => !self.Equals(other);

        public static bool operator <(Nanometre self, Nanometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Nanometre self, Nanometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Nanometre self, Nanometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Nanometre self, Nanometre other) => self.CompareTo(other) >= 0;

        public static Nanometre operator +(Nanometre self, Nanometre other) => new Nanometre(self._value + other._value);
        public static Nanometre operator -(Nanometre self, Nanometre other) => new Nanometre(self._value - other._value);

        public static Nanometre operator *(Nanometre self, double other) => new Nanometre(self._value * other);
        public static Nanometre operator *(double self, Nanometre other) => new Nanometre(self * other._value);

        public static Nanometre operator /(Nanometre self, double other) => new Nanometre(self._value / other);

        public static explicit operator double(Nanometre self) => self._value;
        public static explicit operator Nanometre(double self) => new Nanometre(self);
    }
}