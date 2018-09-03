using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Terabyte (symbol TB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Terabyte = 1,000 Gigabytes
    /// - 1 Terabyte = 10^12 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} TB")]
    public readonly partial struct Terabyte : IUnit, IEquatable<Terabyte>, IComparable<Terabyte> {
        private readonly double _value;

        public const string Symbol = "TB";

        public Terabyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Terabyte Ceiling() => new Terabyte(Math.Ceiling(_value));

        public Terabyte Round() => new Terabyte(Math.Round(_value));
        public Terabyte Round(int digits) => new Terabyte(Math.Round(_value, digits));
        public Terabyte Round(MidpointRounding mode) => new Terabyte(Math.Round(_value, mode));

        public Terabyte Floor() => new Terabyte(Math.Floor(_value));

        public Terabyte Truncate() => new Terabyte(Math.Truncate(_value));

        public Terabyte Abs() => new Terabyte(Math.Abs(_value));

        public bool Equals(Terabyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Terabyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Terabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Terabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} TB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Terabyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} TB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Terabyte self, Terabyte other) => self.Equals(other);
        public static bool operator !=(Terabyte self, Terabyte other) => !self.Equals(other);

        public static bool operator <(Terabyte self, Terabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Terabyte self, Terabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Terabyte self, Terabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Terabyte self, Terabyte other) => self.CompareTo(other) >= 0;

        public static Terabyte operator +(Terabyte self, Terabyte other) => new Terabyte(self._value + other._value);
        public static Terabyte operator -(Terabyte self, Terabyte other) => new Terabyte(self._value - other._value);

        public static Terabyte operator *(Terabyte self, double other) => new Terabyte(self._value * other);
        public static Terabyte operator *(double self, Terabyte other) => new Terabyte(self * other._value);

        public static Terabyte operator /(Terabyte self, double other) => new Terabyte(self._value / other);

        public static explicit operator double(Terabyte self) => self._value;
        public static explicit operator Terabyte(double self) => new Terabyte(self);
    }
}