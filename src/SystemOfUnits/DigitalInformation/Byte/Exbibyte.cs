using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Exbibyte (symbol EiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Exbibyte = 1,024 Pebibytes
    /// - 1 Exbibyte = 1024^6 or 2^60 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} EiB")]
    public readonly partial struct Exbibyte : IUnit, IEquatable<Exbibyte>, IComparable<Exbibyte> {
        private readonly double _value;

        public const string Symbol = "EiB";

        public Exbibyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Exbibyte Ceiling() => new Exbibyte(Math.Ceiling(_value));

        public Exbibyte Round() => new Exbibyte(Math.Round(_value));
        public Exbibyte Round(int digits) => new Exbibyte(Math.Round(_value, digits));
        public Exbibyte Round(MidpointRounding mode) => new Exbibyte(Math.Round(_value, mode));

        public Exbibyte Floor() => new Exbibyte(Math.Floor(_value));

        public Exbibyte Truncate() => new Exbibyte(Math.Truncate(_value));

        public Exbibyte Abs() => new Exbibyte(Math.Abs(_value));

        public bool Equals(Exbibyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Exbibyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Exbibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Exbibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} EiB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Exbibyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} EiB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Exbibyte self, Exbibyte other) => self.Equals(other);
        public static bool operator !=(Exbibyte self, Exbibyte other) => !self.Equals(other);

        public static bool operator <(Exbibyte self, Exbibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Exbibyte self, Exbibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Exbibyte self, Exbibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Exbibyte self, Exbibyte other) => self.CompareTo(other) >= 0;

        public static Exbibyte operator +(Exbibyte self, Exbibyte other) => new Exbibyte(self._value + other._value);
        public static Exbibyte operator -(Exbibyte self, Exbibyte other) => new Exbibyte(self._value - other._value);

        public static Exbibyte operator *(Exbibyte self, double other) => new Exbibyte(self._value * other);
        public static Exbibyte operator *(double self, Exbibyte other) => new Exbibyte(self * other._value);

        public static Exbibyte operator /(Exbibyte self, double other) => new Exbibyte(self._value / other);

        public static explicit operator double(Exbibyte self) => self._value;
        public static explicit operator Exbibyte(double self) => new Exbibyte(self);
    }
}