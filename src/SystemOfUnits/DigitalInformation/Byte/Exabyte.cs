using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Exabyte (symbol EB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Exabyte = 1,000 Petabytes
    /// - 1 Exabyte = 10^18 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} EB")]
    public readonly partial struct Exabyte : IUnit, IEquatable<Exabyte>, IComparable<Exabyte> {
        private readonly double _value;

        public const string Symbol = "EB";

        public Exabyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Exabyte Ceiling() => new Exabyte(Math.Ceiling(_value));

        public Exabyte Round() => new Exabyte(Math.Round(_value));
        public Exabyte Round(int digits) => new Exabyte(Math.Round(_value, digits));
        public Exabyte Round(MidpointRounding mode) => new Exabyte(Math.Round(_value, mode));

        public Exabyte Floor() => new Exabyte(Math.Floor(_value));

        public Exabyte Truncate() => new Exabyte(Math.Truncate(_value));

        public Exabyte Abs() => new Exabyte(Math.Abs(_value));

        public bool Equals(Exabyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Exabyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Exabyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Exabyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} EB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Exabyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} EB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Exabyte self, Exabyte other) => self.Equals(other);
        public static bool operator !=(Exabyte self, Exabyte other) => !self.Equals(other);

        public static bool operator <(Exabyte self, Exabyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Exabyte self, Exabyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Exabyte self, Exabyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Exabyte self, Exabyte other) => self.CompareTo(other) >= 0;

        public static Exabyte operator +(Exabyte self, Exabyte other) => new Exabyte(self._value + other._value);
        public static Exabyte operator -(Exabyte self, Exabyte other) => new Exabyte(self._value - other._value);

        public static Exabyte operator *(Exabyte self, double other) => new Exabyte(self._value * other);
        public static Exabyte operator *(double self, Exabyte other) => new Exabyte(self * other._value);

        public static Exabyte operator /(Exabyte self, double other) => new Exabyte(self._value / other);

        public static explicit operator double(Exabyte self) => self._value;
        public static explicit operator Exabyte(double self) => new Exabyte(self);
    }
}