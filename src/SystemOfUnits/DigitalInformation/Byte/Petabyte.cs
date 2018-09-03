using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Petabyte (symbol PB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Petabyte = 1,000 Terabytes
    /// - 1 Petabyte = 10^15 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} PB")]
    public readonly partial struct Petabyte : IUnit, IEquatable<Petabyte>, IComparable<Petabyte> {
        private readonly double _value;

        public const string Symbol = "PB";

        public Petabyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Petabyte Ceiling() => new Petabyte(Math.Ceiling(_value));

        public Petabyte Round() => new Petabyte(Math.Round(_value));
        public Petabyte Round(int digits) => new Petabyte(Math.Round(_value, digits));
        public Petabyte Round(MidpointRounding mode) => new Petabyte(Math.Round(_value, mode));

        public Petabyte Floor() => new Petabyte(Math.Floor(_value));

        public Petabyte Truncate() => new Petabyte(Math.Truncate(_value));

        public Petabyte Abs() => new Petabyte(Math.Abs(_value));

        public bool Equals(Petabyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Petabyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Petabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Petabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} PB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Petabyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} PB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Petabyte self, Petabyte other) => self.Equals(other);
        public static bool operator !=(Petabyte self, Petabyte other) => !self.Equals(other);

        public static bool operator <(Petabyte self, Petabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Petabyte self, Petabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Petabyte self, Petabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Petabyte self, Petabyte other) => self.CompareTo(other) >= 0;

        public static Petabyte operator +(Petabyte self, Petabyte other) => new Petabyte(self._value + other._value);
        public static Petabyte operator -(Petabyte self, Petabyte other) => new Petabyte(self._value - other._value);

        public static Petabyte operator *(Petabyte self, double other) => new Petabyte(self._value * other);
        public static Petabyte operator *(double self, Petabyte other) => new Petabyte(self * other._value);

        public static Petabyte operator /(Petabyte self, double other) => new Petabyte(self._value / other);

        public static explicit operator double(Petabyte self) => self._value;
        public static explicit operator Petabyte(double self) => new Petabyte(self);
    }
}