using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    /// <summary>
    /// Represents a Centilitre (symbol cl).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cl")]
    public readonly partial struct Centilitre : IUnit, IEquatable<Centilitre>, IComparable<Centilitre> {
        private readonly double _value;

        public const string Symbol = "cl";

        public Centilitre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Centilitre Ceiling() => new Centilitre(Math.Ceiling(_value));

        public Centilitre Round() => new Centilitre(Math.Round(_value));
        public Centilitre Round(int digits) => new Centilitre(Math.Round(_value, digits));
        public Centilitre Round(MidpointRounding mode) => new Centilitre(Math.Round(_value, mode));

        public Centilitre Floor() => new Centilitre(Math.Floor(_value));

        public Centilitre Truncate() => new Centilitre(Math.Truncate(_value));

        public Centilitre Abs() => new Centilitre(Math.Abs(_value));

        public bool Equals(Centilitre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Centilitre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Centilitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Centilitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cl", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Centilitre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} cl";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Centilitre self, Centilitre other) => self.Equals(other);
        public static bool operator !=(Centilitre self, Centilitre other) => !self.Equals(other);

        public static bool operator <(Centilitre self, Centilitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Centilitre self, Centilitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Centilitre self, Centilitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Centilitre self, Centilitre other) => self.CompareTo(other) >= 0;

        public static Centilitre operator +(Centilitre self, Centilitre other) => new Centilitre(self._value + other._value);
        public static Centilitre operator -(Centilitre self, Centilitre other) => new Centilitre(self._value - other._value);

        public static Centilitre operator *(Centilitre self, double other) => new Centilitre(self._value * other);
        public static Centilitre operator *(double self, Centilitre other) => new Centilitre(self * other._value);

        public static Centilitre operator /(Centilitre self, double other) => new Centilitre(self._value / other);

        public static explicit operator double(Centilitre self) => self._value;
        public static explicit operator Centilitre(double self) => new Centilitre(self);
    }
}