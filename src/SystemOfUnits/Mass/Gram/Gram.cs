using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    /// <summary>
    /// Represents a Gram (symbol g).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} g")]
    public readonly partial struct Gram : IUnit, IEquatable<Gram>, IComparable<Gram> {
        private readonly double _value;

        public const string Symbol = "g";

        public Gram(double value) {
            _value = value;
        }

        public double Value => _value;

        public Gram Ceiling() => new Gram(Math.Ceiling(_value));

        public Gram Round() => new Gram(Math.Round(_value));
        public Gram Round(int digits) => new Gram(Math.Round(_value, digits));
        public Gram Round(MidpointRounding mode) => new Gram(Math.Round(_value, mode));

        public Gram Floor() => new Gram(Math.Floor(_value));

        public Gram Truncate() => new Gram(Math.Truncate(_value));

        public Gram Abs() => new Gram(Math.Abs(_value));

        public bool Equals(Gram other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Gram other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} g", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gram other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} g";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Gram self, Gram other) => self.Equals(other);
        public static bool operator !=(Gram self, Gram other) => !self.Equals(other);

        public static bool operator <(Gram self, Gram other) => self.CompareTo(other) < 0;
        public static bool operator >(Gram self, Gram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gram self, Gram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gram self, Gram other) => self.CompareTo(other) >= 0;

        public static Gram operator +(Gram self, Gram other) => new Gram(self._value + other._value);
        public static Gram operator -(Gram self, Gram other) => new Gram(self._value - other._value);

        public static Gram operator *(Gram self, double other) => new Gram(self._value * other);
        public static Gram operator *(double self, Gram other) => new Gram(self * other._value);

        public static Gram operator /(Gram self, double other) => new Gram(self._value / other);

        public static explicit operator double(Gram self) => self._value;
        public static explicit operator Gram(double self) => new Gram(self);
    }
}