using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Byte {
    /// <summary>
    /// Represents a Byte (symbol B).
    /// Where:
    /// - 1 Byte = 8 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} B")]
    public readonly partial struct Byte : IUnit, IEquatable<Byte>, IComparable<Byte> {
        private readonly double _value;

        public const string Symbol = "B";

        public Byte(double value) {
            _value = value;
        }

        public double Value => _value;

        public Byte Ceiling() => new Byte(Math.Ceiling(_value));

        public Byte Round() => new Byte(Math.Round(_value));
        public Byte Round(int digits) => new Byte(Math.Round(_value, digits));
        public Byte Round(MidpointRounding mode) => new Byte(Math.Round(_value, mode));

        public Byte Floor() => new Byte(Math.Floor(_value));

        public Byte Truncate() => new Byte(Math.Truncate(_value));

        public Byte Abs() => new Byte(Math.Abs(_value));

        public bool Equals(Byte other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Byte other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Byte other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Byte)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} B", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Byte other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} B";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Byte self, Byte other) => self.Equals(other);
        public static bool operator !=(Byte self, Byte other) => !self.Equals(other);

        public static bool operator <(Byte self, Byte other) => self.CompareTo(other) < 0;
        public static bool operator >(Byte self, Byte other) => self.CompareTo(other) > 0;
        public static bool operator <=(Byte self, Byte other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Byte self, Byte other) => self.CompareTo(other) >= 0;

        public static Byte operator +(Byte self, Byte other) => new Byte(self._value + other._value);
        public static Byte operator -(Byte self, Byte other) => new Byte(self._value - other._value);

        public static Byte operator *(Byte self, double other) => new Byte(self._value * other);
        public static Byte operator *(double self, Byte other) => new Byte(self * other._value);

        public static Byte operator /(Byte self, double other) => new Byte(self._value / other);

        public static explicit operator double(Byte self) => self._value;
        public static explicit operator Byte(double self) => new Byte(self);
    }
}