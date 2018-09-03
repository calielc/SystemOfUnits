using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    /// <summary>
    /// Represents a Millijoule (symbol mJ).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mJ")]
    public readonly partial struct Millijoule : IUnit, IEquatable<Millijoule>, IComparable<Millijoule> {
        private readonly double _value;

        public const string Symbol = "mJ";

        public Millijoule(double value) {
            _value = value;
        }

        public double Value => _value;

        public Millijoule Ceiling() => new Millijoule(Math.Ceiling(_value));

        public Millijoule Round() => new Millijoule(Math.Round(_value));
        public Millijoule Round(int digits) => new Millijoule(Math.Round(_value, digits));
        public Millijoule Round(MidpointRounding mode) => new Millijoule(Math.Round(_value, mode));

        public Millijoule Floor() => new Millijoule(Math.Floor(_value));

        public Millijoule Truncate() => new Millijoule(Math.Truncate(_value));

        public Millijoule Abs() => new Millijoule(Math.Abs(_value));

        public bool Equals(Millijoule other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Millijoule other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millijoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millijoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mJ", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millijoule other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mJ";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Millijoule self, Millijoule other) => self.Equals(other);
        public static bool operator !=(Millijoule self, Millijoule other) => !self.Equals(other);

        public static bool operator <(Millijoule self, Millijoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Millijoule self, Millijoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millijoule self, Millijoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millijoule self, Millijoule other) => self.CompareTo(other) >= 0;

        public static Millijoule operator +(Millijoule self, Millijoule other) => new Millijoule(self._value + other._value);
        public static Millijoule operator -(Millijoule self, Millijoule other) => new Millijoule(self._value - other._value);

        public static Millijoule operator *(Millijoule self, double other) => new Millijoule(self._value * other);
        public static Millijoule operator *(double self, Millijoule other) => new Millijoule(self * other._value);

        public static Millijoule operator /(Millijoule self, double other) => new Millijoule(self._value / other);

        public static explicit operator double(Millijoule self) => self._value;
        public static explicit operator Millijoule(double self) => new Millijoule(self);
    }
}