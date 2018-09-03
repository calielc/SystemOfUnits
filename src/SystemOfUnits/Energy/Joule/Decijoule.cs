using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    /// <summary>
    /// Represents a Decijoule (symbol dJ).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dJ")]
    public readonly partial struct Decijoule : IUnit, IEquatable<Decijoule>, IComparable<Decijoule> {
        private readonly double _value;

        public const string Symbol = "dJ";

        public Decijoule(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decijoule Ceiling() => new Decijoule(Math.Ceiling(_value));

        public Decijoule Round() => new Decijoule(Math.Round(_value));
        public Decijoule Round(int digits) => new Decijoule(Math.Round(_value, digits));
        public Decijoule Round(MidpointRounding mode) => new Decijoule(Math.Round(_value, mode));

        public Decijoule Floor() => new Decijoule(Math.Floor(_value));

        public Decijoule Truncate() => new Decijoule(Math.Truncate(_value));

        public Decijoule Abs() => new Decijoule(Math.Abs(_value));

        public bool Equals(Decijoule other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decijoule other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decijoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decijoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dJ", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decijoule other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dJ";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decijoule self, Decijoule other) => self.Equals(other);
        public static bool operator !=(Decijoule self, Decijoule other) => !self.Equals(other);

        public static bool operator <(Decijoule self, Decijoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Decijoule self, Decijoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decijoule self, Decijoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decijoule self, Decijoule other) => self.CompareTo(other) >= 0;

        public static Decijoule operator +(Decijoule self, Decijoule other) => new Decijoule(self._value + other._value);
        public static Decijoule operator -(Decijoule self, Decijoule other) => new Decijoule(self._value - other._value);

        public static Decijoule operator *(Decijoule self, double other) => new Decijoule(self._value * other);
        public static Decijoule operator *(double self, Decijoule other) => new Decijoule(self * other._value);

        public static Decijoule operator /(Decijoule self, double other) => new Decijoule(self._value / other);

        public static explicit operator double(Decijoule self) => self._value;
        public static explicit operator Decijoule(double self) => new Decijoule(self);
    }
}