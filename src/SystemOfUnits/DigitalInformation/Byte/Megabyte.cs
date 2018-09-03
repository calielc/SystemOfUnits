using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Megabyte (symbol MB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Megabyte = 1,000 Kilobytes
    /// - 1 Megabyte = 10^6 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} MB")]
    public readonly partial struct Megabyte : IUnit, IEquatable<Megabyte>, IComparable<Megabyte> {
        private readonly double _value;

        public const string Symbol = "MB";

        public Megabyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Megabyte Ceiling() => new Megabyte(Math.Ceiling(_value));

        public Megabyte Round() => new Megabyte(Math.Round(_value));
        public Megabyte Round(int digits) => new Megabyte(Math.Round(_value, digits));
        public Megabyte Round(MidpointRounding mode) => new Megabyte(Math.Round(_value, mode));

        public Megabyte Floor() => new Megabyte(Math.Floor(_value));

        public Megabyte Truncate() => new Megabyte(Math.Truncate(_value));

        public Megabyte Abs() => new Megabyte(Math.Abs(_value));

        public bool Equals(Megabyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Megabyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Megabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Megabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} MB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Megabyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} MB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Megabyte self, Megabyte other) => self.Equals(other);
        public static bool operator !=(Megabyte self, Megabyte other) => !self.Equals(other);

        public static bool operator <(Megabyte self, Megabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Megabyte self, Megabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Megabyte self, Megabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Megabyte self, Megabyte other) => self.CompareTo(other) >= 0;

        public static Megabyte operator +(Megabyte self, Megabyte other) => new Megabyte(self._value + other._value);
        public static Megabyte operator -(Megabyte self, Megabyte other) => new Megabyte(self._value - other._value);

        public static Megabyte operator *(Megabyte self, double other) => new Megabyte(self._value * other);
        public static Megabyte operator *(double self, Megabyte other) => new Megabyte(self * other._value);

        public static Megabyte operator /(Megabyte self, double other) => new Megabyte(self._value / other);

        public static explicit operator double(Megabyte self) => self._value;
        public static explicit operator Megabyte(double self) => new Megabyte(self);
    }
}