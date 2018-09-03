using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    /// <summary>
    /// Represents a Centijoule (symbol cJ).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cJ")]
    public readonly partial struct Centijoule : IUnit, IEquatable<Centijoule>, IComparable<Centijoule> {
        private readonly double _value;

        public const string Symbol = "cJ";

        public Centijoule(double value) {
            _value = value;
        }

        public double Value => _value;

        public Centijoule Ceiling() => new Centijoule(Math.Ceiling(_value));

        public Centijoule Round() => new Centijoule(Math.Round(_value));
        public Centijoule Round(int digits) => new Centijoule(Math.Round(_value, digits));
        public Centijoule Round(MidpointRounding mode) => new Centijoule(Math.Round(_value, mode));

        public Centijoule Floor() => new Centijoule(Math.Floor(_value));

        public Centijoule Truncate() => new Centijoule(Math.Truncate(_value));

        public Centijoule Abs() => new Centijoule(Math.Abs(_value));

        public bool Equals(Centijoule other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Centijoule other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centijoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centijoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cJ", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centijoule other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} cJ";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Centijoule self, Centijoule other) => self.Equals(other);
        public static bool operator !=(Centijoule self, Centijoule other) => !self.Equals(other);

        public static bool operator <(Centijoule self, Centijoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Centijoule self, Centijoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centijoule self, Centijoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centijoule self, Centijoule other) => self.CompareTo(other) >= 0;

        public static Centijoule operator +(Centijoule self, Centijoule other) => new Centijoule(self._value + other._value);
        public static Centijoule operator -(Centijoule self, Centijoule other) => new Centijoule(self._value - other._value);

        public static Centijoule operator *(Centijoule self, double other) => new Centijoule(self._value * other);
        public static Centijoule operator *(double self, Centijoule other) => new Centijoule(self * other._value);

        public static Centijoule operator /(Centijoule self, double other) => new Centijoule(self._value / other);

        public static explicit operator double(Centijoule self) => self._value;
        public static explicit operator Centijoule(double self) => new Centijoule(self);
    }
}