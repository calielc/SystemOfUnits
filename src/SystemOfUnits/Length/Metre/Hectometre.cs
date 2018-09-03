using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Hectometre (symbol hm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hm")]
    public readonly partial struct Hectometre : IUnit, IEquatable<Hectometre>, IComparable<Hectometre> {
        private readonly double _value;

        public const string Symbol = "hm";

        public Hectometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Hectometre Ceiling() => new Hectometre(Math.Ceiling(_value));

        public Hectometre Round() => new Hectometre(Math.Round(_value));
        public Hectometre Round(int digits) => new Hectometre(Math.Round(_value, digits));
        public Hectometre Round(MidpointRounding mode) => new Hectometre(Math.Round(_value, mode));

        public Hectometre Floor() => new Hectometre(Math.Floor(_value));

        public Hectometre Truncate() => new Hectometre(Math.Truncate(_value));

        public Hectometre Abs() => new Hectometre(Math.Abs(_value));

        public bool Equals(Hectometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Hectometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Hectometre self, Hectometre other) => self.Equals(other);
        public static bool operator !=(Hectometre self, Hectometre other) => !self.Equals(other);

        public static bool operator <(Hectometre self, Hectometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectometre self, Hectometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectometre self, Hectometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectometre self, Hectometre other) => self.CompareTo(other) >= 0;

        public static Hectometre operator +(Hectometre self, Hectometre other) => new Hectometre(self._value + other._value);
        public static Hectometre operator -(Hectometre self, Hectometre other) => new Hectometre(self._value - other._value);

        public static Hectometre operator *(Hectometre self, double other) => new Hectometre(self._value * other);
        public static Hectometre operator *(double self, Hectometre other) => new Hectometre(self * other._value);

        public static Hectometre operator /(Hectometre self, double other) => new Hectometre(self._value / other);

        public static explicit operator double(Hectometre self) => self._value;
        public static explicit operator Hectometre(double self) => new Hectometre(self);
    }
}