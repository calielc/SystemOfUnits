using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Mebibyte (symbol MiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Mebibyte = 1,024 Kibibytes
    /// - 1 Mebibyte = 1024^2 or 2^20 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} MiB")]
    public readonly partial struct Mebibyte : IUnit, IEquatable<Mebibyte>, IComparable<Mebibyte> {
        private readonly double _value;

        public const string Symbol = "MiB";

        public Mebibyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Mebibyte Ceiling() => new Mebibyte(Math.Ceiling(_value));

        public Mebibyte Round() => new Mebibyte(Math.Round(_value));
        public Mebibyte Round(int digits) => new Mebibyte(Math.Round(_value, digits));
        public Mebibyte Round(MidpointRounding mode) => new Mebibyte(Math.Round(_value, mode));

        public Mebibyte Floor() => new Mebibyte(Math.Floor(_value));

        public Mebibyte Truncate() => new Mebibyte(Math.Truncate(_value));

        public Mebibyte Abs() => new Mebibyte(Math.Abs(_value));

        public bool Equals(Mebibyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Mebibyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Mebibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Mebibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} MiB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Mebibyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} MiB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Mebibyte self, Mebibyte other) => self.Equals(other);
        public static bool operator !=(Mebibyte self, Mebibyte other) => !self.Equals(other);

        public static bool operator <(Mebibyte self, Mebibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Mebibyte self, Mebibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Mebibyte self, Mebibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Mebibyte self, Mebibyte other) => self.CompareTo(other) >= 0;

        public static Mebibyte operator +(Mebibyte self, Mebibyte other) => new Mebibyte(self._value + other._value);
        public static Mebibyte operator -(Mebibyte self, Mebibyte other) => new Mebibyte(self._value - other._value);

        public static Mebibyte operator *(Mebibyte self, double other) => new Mebibyte(self._value * other);
        public static Mebibyte operator *(double self, Mebibyte other) => new Mebibyte(self * other._value);

        public static Mebibyte operator /(Mebibyte self, double other) => new Mebibyte(self._value / other);

        public static explicit operator double(Mebibyte self) => self._value;
        public static explicit operator Mebibyte(double self) => new Mebibyte(self);
    }
}