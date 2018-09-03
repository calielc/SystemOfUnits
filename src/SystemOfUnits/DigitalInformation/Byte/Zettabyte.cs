using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Zettabyte (symbol ZB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Zettabyte = 1,000 Exabytes
    /// - 1 Zettabyte = 10^21 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} ZB")]
    public readonly partial struct Zettabyte : IUnit, IEquatable<Zettabyte>, IComparable<Zettabyte> {
        private readonly double _value;

        public const string Symbol = "ZB";

        public Zettabyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Zettabyte Ceiling() => new Zettabyte(Math.Ceiling(_value));

        public Zettabyte Round() => new Zettabyte(Math.Round(_value));
        public Zettabyte Round(int digits) => new Zettabyte(Math.Round(_value, digits));
        public Zettabyte Round(MidpointRounding mode) => new Zettabyte(Math.Round(_value, mode));

        public Zettabyte Floor() => new Zettabyte(Math.Floor(_value));

        public Zettabyte Truncate() => new Zettabyte(Math.Truncate(_value));

        public Zettabyte Abs() => new Zettabyte(Math.Abs(_value));

        public bool Equals(Zettabyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Zettabyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Zettabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Zettabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} ZB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Zettabyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} ZB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Zettabyte self, Zettabyte other) => self.Equals(other);
        public static bool operator !=(Zettabyte self, Zettabyte other) => !self.Equals(other);

        public static bool operator <(Zettabyte self, Zettabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Zettabyte self, Zettabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Zettabyte self, Zettabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Zettabyte self, Zettabyte other) => self.CompareTo(other) >= 0;

        public static Zettabyte operator +(Zettabyte self, Zettabyte other) => new Zettabyte(self._value + other._value);
        public static Zettabyte operator -(Zettabyte self, Zettabyte other) => new Zettabyte(self._value - other._value);

        public static Zettabyte operator *(Zettabyte self, double other) => new Zettabyte(self._value * other);
        public static Zettabyte operator *(double self, Zettabyte other) => new Zettabyte(self * other._value);

        public static Zettabyte operator /(Zettabyte self, double other) => new Zettabyte(self._value / other);

        public static explicit operator double(Zettabyte self) => self._value;
        public static explicit operator Zettabyte(double self) => new Zettabyte(self);
    }
}