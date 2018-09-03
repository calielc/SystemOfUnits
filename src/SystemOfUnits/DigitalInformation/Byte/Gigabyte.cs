using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Gigabyte (symbol GB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Gigabyte = 1,000 Megabytes
    /// - 1 Gigabyte = 10^9 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} GB")]
    public readonly partial struct Gigabyte : IUnit, IEquatable<Gigabyte>, IComparable<Gigabyte> {
        private readonly double _value;

        public const string Symbol = "GB";

        public Gigabyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Gigabyte Ceiling() => new Gigabyte(Math.Ceiling(_value));

        public Gigabyte Round() => new Gigabyte(Math.Round(_value));
        public Gigabyte Round(int digits) => new Gigabyte(Math.Round(_value, digits));
        public Gigabyte Round(MidpointRounding mode) => new Gigabyte(Math.Round(_value, mode));

        public Gigabyte Floor() => new Gigabyte(Math.Floor(_value));

        public Gigabyte Truncate() => new Gigabyte(Math.Truncate(_value));

        public Gigabyte Abs() => new Gigabyte(Math.Abs(_value));

        public bool Equals(Gigabyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Gigabyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gigabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gigabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} GB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gigabyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} GB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Gigabyte self, Gigabyte other) => self.Equals(other);
        public static bool operator !=(Gigabyte self, Gigabyte other) => !self.Equals(other);

        public static bool operator <(Gigabyte self, Gigabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Gigabyte self, Gigabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gigabyte self, Gigabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gigabyte self, Gigabyte other) => self.CompareTo(other) >= 0;

        public static Gigabyte operator +(Gigabyte self, Gigabyte other) => new Gigabyte(self._value + other._value);
        public static Gigabyte operator -(Gigabyte self, Gigabyte other) => new Gigabyte(self._value - other._value);

        public static Gigabyte operator *(Gigabyte self, double other) => new Gigabyte(self._value * other);
        public static Gigabyte operator *(double self, Gigabyte other) => new Gigabyte(self * other._value);

        public static Gigabyte operator /(Gigabyte self, double other) => new Gigabyte(self._value / other);

        public static explicit operator double(Gigabyte self) => self._value;
        public static explicit operator Gigabyte(double self) => new Gigabyte(self);
    }
}