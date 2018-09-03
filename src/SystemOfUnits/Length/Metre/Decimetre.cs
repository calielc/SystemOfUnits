using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Decimetre (symbol dm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dm")]
    public readonly partial struct Decimetre : IUnit, IEquatable<Decimetre>, IComparable<Decimetre> {
        private readonly double _value;

        public const string Symbol = "dm";

        public Decimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decimetre Ceiling() => new Decimetre(Math.Ceiling(_value));

        public Decimetre Round() => new Decimetre(Math.Round(_value));
        public Decimetre Round(int digits) => new Decimetre(Math.Round(_value, digits));
        public Decimetre Round(MidpointRounding mode) => new Decimetre(Math.Round(_value, mode));

        public Decimetre Floor() => new Decimetre(Math.Floor(_value));

        public Decimetre Truncate() => new Decimetre(Math.Truncate(_value));

        public Decimetre Abs() => new Decimetre(Math.Abs(_value));

        public bool Equals(Decimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decimetre self, Decimetre other) => self.Equals(other);
        public static bool operator !=(Decimetre self, Decimetre other) => !self.Equals(other);

        public static bool operator <(Decimetre self, Decimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(Decimetre self, Decimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decimetre self, Decimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decimetre self, Decimetre other) => self.CompareTo(other) >= 0;

        public static Decimetre operator +(Decimetre self, Decimetre other) => new Decimetre(self._value + other._value);
        public static Decimetre operator -(Decimetre self, Decimetre other) => new Decimetre(self._value - other._value);

        public static Decimetre operator *(Decimetre self, double other) => new Decimetre(self._value * other);
        public static Decimetre operator *(double self, Decimetre other) => new Decimetre(self * other._value);

        public static Decimetre operator /(Decimetre self, double other) => new Decimetre(self._value / other);

        public static explicit operator double(Decimetre self) => self._value;
        public static explicit operator Decimetre(double self) => new Decimetre(self);
    }
}