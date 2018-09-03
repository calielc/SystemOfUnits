using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Yobibyte (symbol YiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Yobibyte = 1,024 Zebibytes
    /// - 1 Yobibyte = 1024^8 or 2^80 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} YiB")]
    public readonly partial struct Yobibyte : IUnit, IEquatable<Yobibyte>, IComparable<Yobibyte> {
        private readonly double _value;

        public const string Symbol = "YiB";

        public Yobibyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Yobibyte Ceiling() => new Yobibyte(Math.Ceiling(_value));

        public Yobibyte Round() => new Yobibyte(Math.Round(_value));
        public Yobibyte Round(int digits) => new Yobibyte(Math.Round(_value, digits));
        public Yobibyte Round(MidpointRounding mode) => new Yobibyte(Math.Round(_value, mode));

        public Yobibyte Floor() => new Yobibyte(Math.Floor(_value));

        public Yobibyte Truncate() => new Yobibyte(Math.Truncate(_value));

        public Yobibyte Abs() => new Yobibyte(Math.Abs(_value));

        public bool Equals(Yobibyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Yobibyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Yobibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Yobibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} YiB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Yobibyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} YiB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Yobibyte self, Yobibyte other) => self.Equals(other);
        public static bool operator !=(Yobibyte self, Yobibyte other) => !self.Equals(other);

        public static bool operator <(Yobibyte self, Yobibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Yobibyte self, Yobibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Yobibyte self, Yobibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Yobibyte self, Yobibyte other) => self.CompareTo(other) >= 0;

        public static Yobibyte operator +(Yobibyte self, Yobibyte other) => new Yobibyte(self._value + other._value);
        public static Yobibyte operator -(Yobibyte self, Yobibyte other) => new Yobibyte(self._value - other._value);

        public static Yobibyte operator *(Yobibyte self, double other) => new Yobibyte(self._value * other);
        public static Yobibyte operator *(double self, Yobibyte other) => new Yobibyte(self * other._value);

        public static Yobibyte operator /(Yobibyte self, double other) => new Yobibyte(self._value / other);

        public static explicit operator double(Yobibyte self) => self._value;
        public static explicit operator Yobibyte(double self) => new Yobibyte(self);
    }
}