using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Bit (symbol b).
    /// Where:
    /// - 8 bits = 1 byte
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} b")]
    public readonly partial struct Bit : IUnit, IEquatable<Bit>, IComparable<Bit> {
        private readonly double _value;

        public const string Symbol = "b";

        public Bit(double value) {
            _value = value;
        }

        public double Value => _value;

        public Bit Ceiling() => new Bit(Math.Ceiling(_value));

        public Bit Round() => new Bit(Math.Round(_value));
        public Bit Round(int digits) => new Bit(Math.Round(_value, digits));
        public Bit Round(MidpointRounding mode) => new Bit(Math.Round(_value, mode));

        public Bit Floor() => new Bit(Math.Floor(_value));

        public Bit Truncate() => new Bit(Math.Truncate(_value));

        public Bit Abs() => new Bit(Math.Abs(_value));

        public bool Equals(Bit other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Bit other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Bit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Bit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} b", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Bit other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} b";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Bit self, Bit other) => self.Equals(other);
        public static bool operator !=(Bit self, Bit other) => !self.Equals(other);

        public static bool operator <(Bit self, Bit other) => self.CompareTo(other) < 0;
        public static bool operator >(Bit self, Bit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Bit self, Bit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Bit self, Bit other) => self.CompareTo(other) >= 0;

        public static Bit operator +(Bit self, Bit other) => new Bit(self._value + other._value);
        public static Bit operator -(Bit self, Bit other) => new Bit(self._value - other._value);

        public static Bit operator *(Bit self, double other) => new Bit(self._value * other);
        public static Bit operator *(double self, Bit other) => new Bit(self * other._value);

        public static Bit operator /(Bit self, double other) => new Bit(self._value / other);

        public static explicit operator double(Bit self) => self._value;
        public static explicit operator Bit(double self) => new Bit(self);
    }
}