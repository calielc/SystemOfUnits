using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Pixel {
    /// <summary>
    /// Represents a Pixel (symbol px).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} px")]
    public readonly partial struct Pixel : IUnit, IEquatable<Pixel>, IComparable<Pixel> {
        private readonly double _value;

        public const string Symbol = "px";

        public Pixel(double value) {
            _value = value;
        }

        public double Value => _value;

        public Pixel Ceiling() => new Pixel(Math.Ceiling(_value));

        public Pixel Round() => new Pixel(Math.Round(_value));
        public Pixel Round(int digits) => new Pixel(Math.Round(_value, digits));
        public Pixel Round(MidpointRounding mode) => new Pixel(Math.Round(_value, mode));

        public Pixel Floor() => new Pixel(Math.Floor(_value));

        public Pixel Truncate() => new Pixel(Math.Truncate(_value));

        public Pixel Abs() => new Pixel(Math.Abs(_value));

        public bool Equals(Pixel other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Pixel other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Pixel other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Pixel)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} px", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Pixel other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} px";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Pixel self, Pixel other) => self.Equals(other);
        public static bool operator !=(Pixel self, Pixel other) => !self.Equals(other);

        public static bool operator <(Pixel self, Pixel other) => self.CompareTo(other) < 0;
        public static bool operator >(Pixel self, Pixel other) => self.CompareTo(other) > 0;
        public static bool operator <=(Pixel self, Pixel other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Pixel self, Pixel other) => self.CompareTo(other) >= 0;

        public static Pixel operator +(Pixel self, Pixel other) => new Pixel(self._value + other._value);
        public static Pixel operator -(Pixel self, Pixel other) => new Pixel(self._value - other._value);

        public static Pixel operator *(Pixel self, double other) => new Pixel(self._value * other);
        public static Pixel operator *(double self, Pixel other) => new Pixel(self * other._value);

        public static Pixel operator /(Pixel self, double other) => new Pixel(self._value / other);

        public static explicit operator double(Pixel self) => self._value;
        public static explicit operator Pixel(double self) => new Pixel(self);
    }
}