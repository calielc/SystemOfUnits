using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Pebibyte (symbol PiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Pebibyte = 1,024 Tebibytes
    /// - 1 Pebibyte = 1024^5 or 2^50 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} PiB")]
    public readonly partial struct Pebibyte : IUnit, IEquatable<Pebibyte>, IComparable<Pebibyte> {
        private readonly double _value;

        public const string Symbol = "PiB";

        public Pebibyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Pebibyte Ceiling() => new Pebibyte(Math.Ceiling(_value));

        public Pebibyte Round() => new Pebibyte(Math.Round(_value));
        public Pebibyte Round(int digits) => new Pebibyte(Math.Round(_value, digits));
        public Pebibyte Round(MidpointRounding mode) => new Pebibyte(Math.Round(_value, mode));

        public Pebibyte Floor() => new Pebibyte(Math.Floor(_value));

        public Pebibyte Truncate() => new Pebibyte(Math.Truncate(_value));

        public Pebibyte Abs() => new Pebibyte(Math.Abs(_value));

        public bool Equals(Pebibyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Pebibyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Pebibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Pebibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} PiB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Pebibyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} PiB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Pebibyte self, Pebibyte other) => self.Equals(other);
        public static bool operator !=(Pebibyte self, Pebibyte other) => !self.Equals(other);

        public static bool operator <(Pebibyte self, Pebibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Pebibyte self, Pebibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Pebibyte self, Pebibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Pebibyte self, Pebibyte other) => self.CompareTo(other) >= 0;

        public static Pebibyte operator +(Pebibyte self, Pebibyte other) => new Pebibyte(self._value + other._value);
        public static Pebibyte operator -(Pebibyte self, Pebibyte other) => new Pebibyte(self._value - other._value);

        public static Pebibyte operator *(Pebibyte self, double other) => new Pebibyte(self._value * other);
        public static Pebibyte operator *(double self, Pebibyte other) => new Pebibyte(self * other._value);

        public static Pebibyte operator /(Pebibyte self, double other) => new Pebibyte(self._value / other);

        public static explicit operator double(Pebibyte self) => self._value;
        public static explicit operator Pebibyte(double self) => new Pebibyte(self);
    }
}