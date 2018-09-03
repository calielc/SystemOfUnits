using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    /// <summary>
    /// Represents a Decilitre (symbol dl).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dl")]
    public readonly partial struct Decilitre : IUnit, IEquatable<Decilitre>, IComparable<Decilitre> {
        private readonly double _value;

        public const string Symbol = "dl";

        public Decilitre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decilitre Ceiling() => new Decilitre(Math.Ceiling(_value));

        public Decilitre Round() => new Decilitre(Math.Round(_value));
        public Decilitre Round(int digits) => new Decilitre(Math.Round(_value, digits));
        public Decilitre Round(MidpointRounding mode) => new Decilitre(Math.Round(_value, mode));

        public Decilitre Floor() => new Decilitre(Math.Floor(_value));

        public Decilitre Truncate() => new Decilitre(Math.Truncate(_value));

        public Decilitre Abs() => new Decilitre(Math.Abs(_value));

        public bool Equals(Decilitre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decilitre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decilitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decilitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dl", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decilitre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dl";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decilitre self, Decilitre other) => self.Equals(other);
        public static bool operator !=(Decilitre self, Decilitre other) => !self.Equals(other);

        public static bool operator <(Decilitre self, Decilitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Decilitre self, Decilitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decilitre self, Decilitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decilitre self, Decilitre other) => self.CompareTo(other) >= 0;

        public static Decilitre operator +(Decilitre self, Decilitre other) => new Decilitre(self._value + other._value);
        public static Decilitre operator -(Decilitre self, Decilitre other) => new Decilitre(self._value - other._value);

        public static Decilitre operator *(Decilitre self, double other) => new Decilitre(self._value * other);
        public static Decilitre operator *(double self, Decilitre other) => new Decilitre(self * other._value);

        public static Decilitre operator /(Decilitre self, double other) => new Decilitre(self._value / other);

        public static explicit operator double(Decilitre self) => self._value;
        public static explicit operator Decilitre(double self) => new Decilitre(self);
    }
}