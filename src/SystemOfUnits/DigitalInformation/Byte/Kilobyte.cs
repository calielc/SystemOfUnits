using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Kilobyte (symbol kB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Kilobyte = 1,000 Bytes
    /// -  1 Kilobyte = 10^3 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} kB")]
    public readonly partial struct Kilobyte : IUnit, IEquatable<Kilobyte>, IComparable<Kilobyte> {
        private readonly double _value;

        public const string Symbol = "kB";

        public Kilobyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kilobyte Ceiling() => new Kilobyte(Math.Ceiling(_value));

        public Kilobyte Round() => new Kilobyte(Math.Round(_value));
        public Kilobyte Round(int digits) => new Kilobyte(Math.Round(_value, digits));
        public Kilobyte Round(MidpointRounding mode) => new Kilobyte(Math.Round(_value, mode));

        public Kilobyte Floor() => new Kilobyte(Math.Floor(_value));

        public Kilobyte Truncate() => new Kilobyte(Math.Truncate(_value));

        public Kilobyte Abs() => new Kilobyte(Math.Abs(_value));

        public bool Equals(Kilobyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kilobyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilobyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilobyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} kB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilobyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} kB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kilobyte self, Kilobyte other) => self.Equals(other);
        public static bool operator !=(Kilobyte self, Kilobyte other) => !self.Equals(other);

        public static bool operator <(Kilobyte self, Kilobyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilobyte self, Kilobyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilobyte self, Kilobyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilobyte self, Kilobyte other) => self.CompareTo(other) >= 0;

        public static Kilobyte operator +(Kilobyte self, Kilobyte other) => new Kilobyte(self._value + other._value);
        public static Kilobyte operator -(Kilobyte self, Kilobyte other) => new Kilobyte(self._value - other._value);

        public static Kilobyte operator *(Kilobyte self, double other) => new Kilobyte(self._value * other);
        public static Kilobyte operator *(double self, Kilobyte other) => new Kilobyte(self * other._value);

        public static Kilobyte operator /(Kilobyte self, double other) => new Kilobyte(self._value / other);

        public static explicit operator double(Kilobyte self) => self._value;
        public static explicit operator Kilobyte(double self) => new Kilobyte(self);
    }
}