using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Kibibyte (symbol KiB).
    /// It is a multiple of the unit <c>Byte</c>, where:
    /// - 1 Kibibyte = 1,024 bytes
    /// - 1 Kibibyte = 1024^1 or 2^10 Bytes
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} KiB")]
    public readonly partial struct Kibibyte : IUnit, IEquatable<Kibibyte>, IComparable<Kibibyte> {
        private readonly double _value;

        public const string Symbol = "KiB";

        public Kibibyte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kibibyte Ceiling() => new Kibibyte(Math.Ceiling(_value));

        public Kibibyte Round() => new Kibibyte(Math.Round(_value));
        public Kibibyte Round(int digits) => new Kibibyte(Math.Round(_value, digits));
        public Kibibyte Round(MidpointRounding mode) => new Kibibyte(Math.Round(_value, mode));

        public Kibibyte Floor() => new Kibibyte(Math.Floor(_value));

        public Kibibyte Truncate() => new Kibibyte(Math.Truncate(_value));

        public Kibibyte Abs() => new Kibibyte(Math.Abs(_value));

        public bool Equals(Kibibyte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kibibyte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kibibyte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kibibyte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} KiB", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kibibyte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} KiB";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kibibyte self, Kibibyte other) => self.Equals(other);
        public static bool operator !=(Kibibyte self, Kibibyte other) => !self.Equals(other);

        public static bool operator <(Kibibyte self, Kibibyte other) => self.CompareTo(other) < 0;
        public static bool operator >(Kibibyte self, Kibibyte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kibibyte self, Kibibyte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kibibyte self, Kibibyte other) => self.CompareTo(other) >= 0;

        public static Kibibyte operator +(Kibibyte self, Kibibyte other) => new Kibibyte(self._value + other._value);
        public static Kibibyte operator -(Kibibyte self, Kibibyte other) => new Kibibyte(self._value - other._value);

        public static Kibibyte operator *(Kibibyte self, double other) => new Kibibyte(self._value * other);
        public static Kibibyte operator *(double self, Kibibyte other) => new Kibibyte(self * other._value);

        public static Kibibyte operator /(Kibibyte self, double other) => new Kibibyte(self._value / other);

        public static explicit operator double(Kibibyte self) => self._value;
        public static explicit operator Kibibyte(double self) => new Kibibyte(self);
    }
}