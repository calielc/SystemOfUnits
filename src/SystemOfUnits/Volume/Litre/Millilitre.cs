using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    /// <summary>
    /// Represents a Millilitre (symbol ml).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} ml")]
    public readonly partial struct Millilitre : IUnit, IEquatable<Millilitre>, IComparable<Millilitre> {
        private readonly double _value;

        public const string Symbol = "ml";

        public Millilitre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Millilitre Ceiling() => new Millilitre(Math.Ceiling(_value));

        public Millilitre Round() => new Millilitre(Math.Round(_value));
        public Millilitre Round(int digits) => new Millilitre(Math.Round(_value, digits));
        public Millilitre Round(MidpointRounding mode) => new Millilitre(Math.Round(_value, mode));

        public Millilitre Floor() => new Millilitre(Math.Floor(_value));

        public Millilitre Truncate() => new Millilitre(Math.Truncate(_value));

        public Millilitre Abs() => new Millilitre(Math.Abs(_value));

        public bool Equals(Millilitre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Millilitre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millilitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millilitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} ml", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millilitre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} ml";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Millilitre self, Millilitre other) => self.Equals(other);
        public static bool operator !=(Millilitre self, Millilitre other) => !self.Equals(other);

        public static bool operator <(Millilitre self, Millilitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Millilitre self, Millilitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millilitre self, Millilitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millilitre self, Millilitre other) => self.CompareTo(other) >= 0;

        public static Millilitre operator +(Millilitre self, Millilitre other) => new Millilitre(self._value + other._value);
        public static Millilitre operator -(Millilitre self, Millilitre other) => new Millilitre(self._value - other._value);

        public static Millilitre operator *(Millilitre self, double other) => new Millilitre(self._value * other);
        public static Millilitre operator *(double self, Millilitre other) => new Millilitre(self * other._value);

        public static Millilitre operator /(Millilitre self, double other) => new Millilitre(self._value / other);

        public static explicit operator double(Millilitre self) => self._value;
        public static explicit operator Millilitre(double self) => new Millilitre(self);
    }
}