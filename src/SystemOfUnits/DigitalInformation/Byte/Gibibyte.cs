using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Gibibyte (symbol GiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Gibibyte = 1,024 Mebibytes
    /// - 1 Gibibyte = 1024^3 or 2^30 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} GiB")]
    public readonly partial struct Gibibyte : IUnit, IEquatable<Gibibyte>, IComparable<Gibibyte> {
        private readonly double _value;

        public const string Symbol = "GiB";

        public Gibibyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Gibibyte Ceiling() => new Gibibyte(Math.Ceiling(_value));

        public Gibibyte Round() => new Gibibyte(Math.Round(_value));
        public Gibibyte Round(int digits) => new Gibibyte(Math.Round(_value, digits));
        public Gibibyte Round(MidpointRounding mode) => new Gibibyte(Math.Round(_value, mode));

        public Gibibyte Floor() => new Gibibyte(Math.Floor(_value));

        public Gibibyte Truncate() => new Gibibyte(Math.Truncate(_value));

        public Gibibyte Abs() => new Gibibyte(Math.Abs(_value));

        public bool Equals(Gibibyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Gibibyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gibibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gibibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} GiB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gibibyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} GiB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Gibibyte self, Gibibyte other) => self.Equals(other);
        public static bool operator !=(Gibibyte self, Gibibyte other) => !self.Equals(other);

        public static bool operator <(Gibibyte self, Gibibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Gibibyte self, Gibibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gibibyte self, Gibibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gibibyte self, Gibibyte other) => self.CompareTo(other) >= 0;

        public static Gibibyte operator +(Gibibyte self, Gibibyte other) => new Gibibyte(self._value + other._value);
        public static Gibibyte operator -(Gibibyte self, Gibibyte other) => new Gibibyte(self._value - other._value);

        public static Gibibyte operator *(Gibibyte self, double other) => new Gibibyte(self._value * other);
        public static Gibibyte operator *(double self, Gibibyte other) => new Gibibyte(self * other._value);

        public static Gibibyte operator /(Gibibyte self, double other) => new Gibibyte(self._value / other);

        public static explicit operator double(Gibibyte self) => self._value;
        public static explicit operator Gibibyte(double self) => new Gibibyte(self);
    }
}