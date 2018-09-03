using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    /// <summary>
    /// Represents a Decajoule (symbol daJ).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} daJ")]
    public readonly partial struct Decajoule : IUnit, IEquatable<Decajoule>, IComparable<Decajoule> {
        private readonly double _value;

        public const string Symbol = "daJ";

        public Decajoule(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decajoule Ceiling() => new Decajoule(Math.Ceiling(_value));

        public Decajoule Round() => new Decajoule(Math.Round(_value));
        public Decajoule Round(int digits) => new Decajoule(Math.Round(_value, digits));
        public Decajoule Round(MidpointRounding mode) => new Decajoule(Math.Round(_value, mode));

        public Decajoule Floor() => new Decajoule(Math.Floor(_value));

        public Decajoule Truncate() => new Decajoule(Math.Truncate(_value));

        public Decajoule Abs() => new Decajoule(Math.Abs(_value));

        public bool Equals(Decajoule other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decajoule other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decajoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decajoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} daJ", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decajoule other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} daJ";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decajoule self, Decajoule other) => self.Equals(other);
        public static bool operator !=(Decajoule self, Decajoule other) => !self.Equals(other);

        public static bool operator <(Decajoule self, Decajoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Decajoule self, Decajoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decajoule self, Decajoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decajoule self, Decajoule other) => self.CompareTo(other) >= 0;

        public static Decajoule operator +(Decajoule self, Decajoule other) => new Decajoule(self._value + other._value);
        public static Decajoule operator -(Decajoule self, Decajoule other) => new Decajoule(self._value - other._value);

        public static Decajoule operator *(Decajoule self, double other) => new Decajoule(self._value * other);
        public static Decajoule operator *(double self, Decajoule other) => new Decajoule(self * other._value);

        public static Decajoule operator /(Decajoule self, double other) => new Decajoule(self._value / other);

        public static explicit operator double(Decajoule self) => self._value;
        public static explicit operator Decajoule(double self) => new Decajoule(self);
    }
}