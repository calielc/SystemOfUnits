using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Tebibyte (symbol TiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Tebibyte = 1,024 Gibibytes
    /// - 1 Tebibyte = 1024^4 or 2^40 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} TiB")]
    public readonly partial struct Tebibyte : IUnit, IEquatable<Tebibyte>, IComparable<Tebibyte> {
        private readonly double _value;

        public const string Symbol = "TiB";

        public Tebibyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Tebibyte Ceiling() => new Tebibyte(Math.Ceiling(_value));

        public Tebibyte Round() => new Tebibyte(Math.Round(_value));
        public Tebibyte Round(int digits) => new Tebibyte(Math.Round(_value, digits));
        public Tebibyte Round(MidpointRounding mode) => new Tebibyte(Math.Round(_value, mode));

        public Tebibyte Floor() => new Tebibyte(Math.Floor(_value));

        public Tebibyte Truncate() => new Tebibyte(Math.Truncate(_value));

        public Tebibyte Abs() => new Tebibyte(Math.Abs(_value));

        public bool Equals(Tebibyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Tebibyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Tebibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Tebibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} TiB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Tebibyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} TiB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Tebibyte self, Tebibyte other) => self.Equals(other);
        public static bool operator !=(Tebibyte self, Tebibyte other) => !self.Equals(other);

        public static bool operator <(Tebibyte self, Tebibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Tebibyte self, Tebibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Tebibyte self, Tebibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Tebibyte self, Tebibyte other) => self.CompareTo(other) >= 0;

        public static Tebibyte operator +(Tebibyte self, Tebibyte other) => new Tebibyte(self._value + other._value);
        public static Tebibyte operator -(Tebibyte self, Tebibyte other) => new Tebibyte(self._value - other._value);

        public static Tebibyte operator *(Tebibyte self, double other) => new Tebibyte(self._value * other);
        public static Tebibyte operator *(double self, Tebibyte other) => new Tebibyte(self * other._value);

        public static Tebibyte operator /(Tebibyte self, double other) => new Tebibyte(self._value / other);

        public static explicit operator double(Tebibyte self) => self._value;
        public static explicit operator Tebibyte(double self) => new Tebibyte(self);
    }
}