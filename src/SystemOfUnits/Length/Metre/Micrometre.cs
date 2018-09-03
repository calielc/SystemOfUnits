using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Micrometre (symbol μm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} μm")]
    public readonly partial struct Micrometre : IUnit, IEquatable<Micrometre>, IComparable<Micrometre> {
        private readonly double _value;

        public const string Symbol = "μm";

        public Micrometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Micrometre Ceiling() => new Micrometre(Math.Ceiling(_value));

        public Micrometre Round() => new Micrometre(Math.Round(_value));
        public Micrometre Round(int digits) => new Micrometre(Math.Round(_value, digits));
        public Micrometre Round(MidpointRounding mode) => new Micrometre(Math.Round(_value, mode));

        public Micrometre Floor() => new Micrometre(Math.Floor(_value));

        public Micrometre Truncate() => new Micrometre(Math.Truncate(_value));

        public Micrometre Abs() => new Micrometre(Math.Abs(_value));

        public bool Equals(Micrometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Micrometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Micrometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Micrometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} μm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Micrometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} μm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Micrometre self, Micrometre other) => self.Equals(other);
        public static bool operator !=(Micrometre self, Micrometre other) => !self.Equals(other);

        public static bool operator <(Micrometre self, Micrometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Micrometre self, Micrometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Micrometre self, Micrometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Micrometre self, Micrometre other) => self.CompareTo(other) >= 0;

        public static Micrometre operator +(Micrometre self, Micrometre other) => new Micrometre(self._value + other._value);
        public static Micrometre operator -(Micrometre self, Micrometre other) => new Micrometre(self._value - other._value);

        public static Micrometre operator *(Micrometre self, double other) => new Micrometre(self._value * other);
        public static Micrometre operator *(double self, Micrometre other) => new Micrometre(self * other._value);

        public static Micrometre operator /(Micrometre self, double other) => new Micrometre(self._value / other);

        public static explicit operator double(Micrometre self) => self._value;
        public static explicit operator Micrometre(double self) => new Micrometre(self);
    }
}