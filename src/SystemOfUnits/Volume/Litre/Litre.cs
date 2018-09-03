using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    /// <summary>
    /// Represents a Litre (symbol l).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} l")]
    public readonly partial struct Litre : IUnit, IEquatable<Litre>, IComparable<Litre> {
        private readonly double _value;

        public const string Symbol = "l";

        public Litre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Litre Ceiling() => new Litre(Math.Ceiling(_value));

        public Litre Round() => new Litre(Math.Round(_value));
        public Litre Round(int digits) => new Litre(Math.Round(_value, digits));
        public Litre Round(MidpointRounding mode) => new Litre(Math.Round(_value, mode));

        public Litre Floor() => new Litre(Math.Floor(_value));

        public Litre Truncate() => new Litre(Math.Truncate(_value));

        public Litre Abs() => new Litre(Math.Abs(_value));

        public bool Equals(Litre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Litre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Litre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Litre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} l", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Litre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} l";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Litre self, Litre other) => self.Equals(other);
        public static bool operator !=(Litre self, Litre other) => !self.Equals(other);

        public static bool operator <(Litre self, Litre other) => self.CompareTo(other) < 0;
        public static bool operator >(Litre self, Litre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Litre self, Litre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Litre self, Litre other) => self.CompareTo(other) >= 0;

        public static Litre operator +(Litre self, Litre other) => new Litre(self._value + other._value);
        public static Litre operator -(Litre self, Litre other) => new Litre(self._value - other._value);

        public static Litre operator *(Litre self, double other) => new Litre(self._value * other);
        public static Litre operator *(double self, Litre other) => new Litre(self * other._value);

        public static Litre operator /(Litre self, double other) => new Litre(self._value / other);

        public static explicit operator double(Litre self) => self._value;
        public static explicit operator Litre(double self) => new Litre(self);
    }
}