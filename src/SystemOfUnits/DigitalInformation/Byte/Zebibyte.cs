using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Zebibyte (symbol ZiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Zebibyte = 1,024 Exbibytes
    /// - 1 Zebibyte = 1024^7 or 2^70 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} ZiB")]
    public readonly partial struct Zebibyte : IUnit, IEquatable<Zebibyte>, IComparable<Zebibyte> {
        private readonly double _value;

        public const string Symbol = "ZiB";

        public Zebibyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Zebibyte Ceiling() => new Zebibyte(Math.Ceiling(_value));

        public Zebibyte Round() => new Zebibyte(Math.Round(_value));
        public Zebibyte Round(int digits) => new Zebibyte(Math.Round(_value, digits));
        public Zebibyte Round(MidpointRounding mode) => new Zebibyte(Math.Round(_value, mode));

        public Zebibyte Floor() => new Zebibyte(Math.Floor(_value));

        public Zebibyte Truncate() => new Zebibyte(Math.Truncate(_value));

        public Zebibyte Abs() => new Zebibyte(Math.Abs(_value));

        public bool Equals(Zebibyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Zebibyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Zebibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Zebibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} ZiB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Zebibyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} ZiB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Zebibyte self, Zebibyte other) => self.Equals(other);
        public static bool operator !=(Zebibyte self, Zebibyte other) => !self.Equals(other);

        public static bool operator <(Zebibyte self, Zebibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Zebibyte self, Zebibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Zebibyte self, Zebibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Zebibyte self, Zebibyte other) => self.CompareTo(other) >= 0;

        public static Zebibyte operator +(Zebibyte self, Zebibyte other) => new Zebibyte(self._value + other._value);
        public static Zebibyte operator -(Zebibyte self, Zebibyte other) => new Zebibyte(self._value - other._value);

        public static Zebibyte operator *(Zebibyte self, double other) => new Zebibyte(self._value * other);
        public static Zebibyte operator *(double self, Zebibyte other) => new Zebibyte(self * other._value);

        public static Zebibyte operator /(Zebibyte self, double other) => new Zebibyte(self._value / other);

        public static explicit operator double(Zebibyte self) => self._value;
        public static explicit operator Zebibyte(double self) => new Zebibyte(self);
    }
}