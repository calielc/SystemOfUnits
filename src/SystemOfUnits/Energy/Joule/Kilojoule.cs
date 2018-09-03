using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    /// <summary>
    /// Represents a Kilojoule (symbol kJ).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kJ")]
    public readonly partial struct Kilojoule : IUnit, IEquatable<Kilojoule>, IComparable<Kilojoule> {
        private readonly double _value;

        public const string Symbol = "kJ";

        public Kilojoule(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kilojoule Ceiling() => new Kilojoule(Math.Ceiling(_value));

        public Kilojoule Round() => new Kilojoule(Math.Round(_value));
        public Kilojoule Round(int digits) => new Kilojoule(Math.Round(_value, digits));
        public Kilojoule Round(MidpointRounding mode) => new Kilojoule(Math.Round(_value, mode));

        public Kilojoule Floor() => new Kilojoule(Math.Floor(_value));

        public Kilojoule Truncate() => new Kilojoule(Math.Truncate(_value));

        public Kilojoule Abs() => new Kilojoule(Math.Abs(_value));

        public bool Equals(Kilojoule other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kilojoule other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilojoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilojoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kJ", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilojoule other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} kJ";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kilojoule self, Kilojoule other) => self.Equals(other);
        public static bool operator !=(Kilojoule self, Kilojoule other) => !self.Equals(other);

        public static bool operator <(Kilojoule self, Kilojoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilojoule self, Kilojoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilojoule self, Kilojoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilojoule self, Kilojoule other) => self.CompareTo(other) >= 0;

        public static Kilojoule operator +(Kilojoule self, Kilojoule other) => new Kilojoule(self._value + other._value);
        public static Kilojoule operator -(Kilojoule self, Kilojoule other) => new Kilojoule(self._value - other._value);

        public static Kilojoule operator *(Kilojoule self, double other) => new Kilojoule(self._value * other);
        public static Kilojoule operator *(double self, Kilojoule other) => new Kilojoule(self * other._value);

        public static Kilojoule operator /(Kilojoule self, double other) => new Kilojoule(self._value / other);

        public static explicit operator double(Kilojoule self) => self._value;
        public static explicit operator Kilojoule(double self) => new Kilojoule(self);
    }
}