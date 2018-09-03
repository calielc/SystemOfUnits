using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    /// <summary>
    /// Represents a Hectolitre (symbol hl).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hl")]
    public readonly partial struct Hectolitre : IUnit, IEquatable<Hectolitre>, IComparable<Hectolitre> {
        private readonly double _value;

        public const string Symbol = "hl";

        public Hectolitre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Hectolitre Ceiling() => new Hectolitre(Math.Ceiling(_value));

        public Hectolitre Round() => new Hectolitre(Math.Round(_value));
        public Hectolitre Round(int digits) => new Hectolitre(Math.Round(_value, digits));
        public Hectolitre Round(MidpointRounding mode) => new Hectolitre(Math.Round(_value, mode));

        public Hectolitre Floor() => new Hectolitre(Math.Floor(_value));

        public Hectolitre Truncate() => new Hectolitre(Math.Truncate(_value));

        public Hectolitre Abs() => new Hectolitre(Math.Abs(_value));

        public bool Equals(Hectolitre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Hectolitre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Hectolitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Hectolitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hl", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Hectolitre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hl";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Hectolitre self, Hectolitre other) => self.Equals(other);
        public static bool operator !=(Hectolitre self, Hectolitre other) => !self.Equals(other);

        public static bool operator <(Hectolitre self, Hectolitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Hectolitre self, Hectolitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Hectolitre self, Hectolitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Hectolitre self, Hectolitre other) => self.CompareTo(other) >= 0;

        public static Hectolitre operator +(Hectolitre self, Hectolitre other) => new Hectolitre(self._value + other._value);
        public static Hectolitre operator -(Hectolitre self, Hectolitre other) => new Hectolitre(self._value - other._value);

        public static Hectolitre operator *(Hectolitre self, double other) => new Hectolitre(self._value * other);
        public static Hectolitre operator *(double self, Hectolitre other) => new Hectolitre(self * other._value);

        public static Hectolitre operator /(Hectolitre self, double other) => new Hectolitre(self._value / other);

        public static explicit operator double(Hectolitre self) => self._value;
        public static explicit operator Hectolitre(double self) => new Hectolitre(self);
    }
}