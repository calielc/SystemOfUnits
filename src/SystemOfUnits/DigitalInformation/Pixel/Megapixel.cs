using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Pixel {
    /// <summary>
    /// Represents a Megapixel (symbol MP).
    /// It is a multiple of the unit <c>Pixel</c>, where:
    /// - 1 Megapixel = 1,000,000 Pixels
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} MP")]
    public readonly partial struct Megapixel : IUnit, IEquatable<Megapixel>, IComparable<Megapixel> {
        private readonly double _value;

        public const string Symbol = "MP";

        public Megapixel(double value) {
            _value = value;
        }

        public double Value => _value;

        public Megapixel Ceiling() => new Megapixel(Math.Ceiling(_value));

        public Megapixel Round() => new Megapixel(Math.Round(_value));
        public Megapixel Round(int digits) => new Megapixel(Math.Round(_value, digits));
        public Megapixel Round(MidpointRounding mode) => new Megapixel(Math.Round(_value, mode));

        public Megapixel Floor() => new Megapixel(Math.Floor(_value));

        public Megapixel Truncate() => new Megapixel(Math.Truncate(_value));

        public Megapixel Abs() => new Megapixel(Math.Abs(_value));

        public bool Equals(Megapixel other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Megapixel other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Megapixel other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Megapixel)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} MP", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Megapixel other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} MP";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Megapixel self, Megapixel other) => self.Equals(other);
        public static bool operator !=(Megapixel self, Megapixel other) => !self.Equals(other);

        public static bool operator <(Megapixel self, Megapixel other) => self.CompareTo(other) < 0;
        public static bool operator >(Megapixel self, Megapixel other) => self.CompareTo(other) > 0;
        public static bool operator <=(Megapixel self, Megapixel other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Megapixel self, Megapixel other) => self.CompareTo(other) >= 0;

        public static Megapixel operator +(Megapixel self, Megapixel other) => new Megapixel(self._value + other._value);
        public static Megapixel operator -(Megapixel self, Megapixel other) => new Megapixel(self._value - other._value);

        public static Megapixel operator *(Megapixel self, double other) => new Megapixel(self._value * other);
        public static Megapixel operator *(double self, Megapixel other) => new Megapixel(self * other._value);

        public static Megapixel operator /(Megapixel self, double other) => new Megapixel(self._value / other);

        public static explicit operator double(Megapixel self) => self._value;
        public static explicit operator Megapixel(double self) => new Megapixel(self);
    }
}