using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Yottabyte (symbol YB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Yottabyte = 1,000 Zettabytes
    /// - 1 Yottabyte = 10^24 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} YB")]
    public readonly partial struct Yottabyte : IUnit, IEquatable<Yottabyte>, IComparable<Yottabyte> {
        private readonly double _value;

        public const string Symbol = "YB";

        public Yottabyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Yottabyte Ceiling() => new Yottabyte(Math.Ceiling(_value));

        public Yottabyte Round() => new Yottabyte(Math.Round(_value));
        public Yottabyte Round(int digits) => new Yottabyte(Math.Round(_value, digits));
        public Yottabyte Round(MidpointRounding mode) => new Yottabyte(Math.Round(_value, mode));

        public Yottabyte Floor() => new Yottabyte(Math.Floor(_value));

        public Yottabyte Truncate() => new Yottabyte(Math.Truncate(_value));

        public Yottabyte Abs() => new Yottabyte(Math.Abs(_value));

        public bool Equals(Yottabyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Yottabyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Yottabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Yottabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} YB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Yottabyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} YB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Yottabyte self, Yottabyte other) => self.Equals(other);
        public static bool operator !=(Yottabyte self, Yottabyte other) => !self.Equals(other);

        public static bool operator <(Yottabyte self, Yottabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Yottabyte self, Yottabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Yottabyte self, Yottabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Yottabyte self, Yottabyte other) => self.CompareTo(other) >= 0;

        public static Yottabyte operator +(Yottabyte self, Yottabyte other) => new Yottabyte(self._value + other._value);
        public static Yottabyte operator -(Yottabyte self, Yottabyte other) => new Yottabyte(self._value - other._value);

        public static Yottabyte operator *(Yottabyte self, double other) => new Yottabyte(self._value * other);
        public static Yottabyte operator *(double self, Yottabyte other) => new Yottabyte(self * other._value);

        public static Yottabyte operator /(Yottabyte self, double other) => new Yottabyte(self._value / other);

        public static explicit operator double(Yottabyte self) => self._value;
        public static explicit operator Yottabyte(double self) => new Yottabyte(self);
    }
}