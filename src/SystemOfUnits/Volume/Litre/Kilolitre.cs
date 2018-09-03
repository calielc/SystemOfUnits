using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    /// <summary>
    /// Represents a Kilolitre (symbol kl).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kl")]
    public readonly partial struct Kilolitre : IUnit, IEquatable<Kilolitre>, IComparable<Kilolitre> {
        private readonly double _value;

        public const string Symbol = "kl";

        public Kilolitre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kilolitre Ceiling() => new Kilolitre(Math.Ceiling(_value));

        public Kilolitre Round() => new Kilolitre(Math.Round(_value));
        public Kilolitre Round(int digits) => new Kilolitre(Math.Round(_value, digits));
        public Kilolitre Round(MidpointRounding mode) => new Kilolitre(Math.Round(_value, mode));

        public Kilolitre Floor() => new Kilolitre(Math.Floor(_value));

        public Kilolitre Truncate() => new Kilolitre(Math.Truncate(_value));

        public Kilolitre Abs() => new Kilolitre(Math.Abs(_value));

        public bool Equals(Kilolitre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kilolitre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilolitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilolitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kl", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilolitre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} kl";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kilolitre self, Kilolitre other) => self.Equals(other);
        public static bool operator !=(Kilolitre self, Kilolitre other) => !self.Equals(other);

        public static bool operator <(Kilolitre self, Kilolitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilolitre self, Kilolitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilolitre self, Kilolitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilolitre self, Kilolitre other) => self.CompareTo(other) >= 0;

        public static Kilolitre operator +(Kilolitre self, Kilolitre other) => new Kilolitre(self._value + other._value);
        public static Kilolitre operator -(Kilolitre self, Kilolitre other) => new Kilolitre(self._value - other._value);

        public static Kilolitre operator *(Kilolitre self, double other) => new Kilolitre(self._value * other);
        public static Kilolitre operator *(double self, Kilolitre other) => new Kilolitre(self * other._value);

        public static Kilolitre operator /(Kilolitre self, double other) => new Kilolitre(self._value / other);

        public static explicit operator double(Kilolitre self) => self._value;
        public static explicit operator Kilolitre(double self) => new Kilolitre(self);
    }
}