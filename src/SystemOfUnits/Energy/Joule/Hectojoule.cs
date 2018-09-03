using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Energy.Joule {
    /// <summary>
    /// Represents a Hectojoule (symbol hJ).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hJ")]
    public readonly partial struct Hectojoule : IUnit, IEquatable<Hectojoule>, IComparable<Hectojoule> {
        private readonly double _value;

        public const string Symbol = "hJ";

        public Hectojoule(double value) {
            _value = value;
        }

        public double Value => _value;

        public Hectojoule Ceiling() => new Hectojoule(Math.Ceiling(_value));

        public Hectojoule Round() => new Hectojoule(Math.Round(_value));
        public Hectojoule Round(int digits) => new Hectojoule(Math.Round(_value, digits));
        public Hectojoule Round(MidpointRounding mode) => new Hectojoule(Math.Round(_value, mode));

        public Hectojoule Floor() => new Hectojoule(Math.Floor(_value));

        public Hectojoule Truncate() => new Hectojoule(Math.Truncate(_value));

        public Hectojoule Abs() => new Hectojoule(Math.Abs(_value));

        public bool Equals(Hectojoule other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Hectojoule other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectojoule other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectojoule)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hJ", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectojoule other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hJ";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Hectojoule self, Hectojoule other) => self.Equals(other);
        public static bool operator !=(Hectojoule self, Hectojoule other) => !self.Equals(other);

        public static bool operator <(Hectojoule self, Hectojoule other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectojoule self, Hectojoule other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectojoule self, Hectojoule other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectojoule self, Hectojoule other) => self.CompareTo(other) >= 0;

        public static Hectojoule operator +(Hectojoule self, Hectojoule other) => new Hectojoule(self._value + other._value);
        public static Hectojoule operator -(Hectojoule self, Hectojoule other) => new Hectojoule(self._value - other._value);

        public static Hectojoule operator *(Hectojoule self, double other) => new Hectojoule(self._value * other);
        public static Hectojoule operator *(double self, Hectojoule other) => new Hectojoule(self * other._value);

        public static Hectojoule operator /(Hectojoule self, double other) => new Hectojoule(self._value / other);

        public static explicit operator double(Hectojoule self) => self._value;
        public static explicit operator Hectojoule(double self) => new Hectojoule(self);
    }
}