using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Kilobit (symbol Kb).
    /// It is a multiple of the unit <c>Bit</c>, where:
    /// - 1 Kilobit = 1,000 Bits
    /// - 1 Kilobit = 10^3 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Kb")]
    public readonly partial struct Kilobit : IUnit, IEquatable<Kilobit>, IComparable<Kilobit> {
        private readonly double _value;

        public const string Symbol = "Kb";

        public Kilobit(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kilobit Ceiling() => new Kilobit(Math.Ceiling(_value));

        public Kilobit Round() => new Kilobit(Math.Round(_value));
        public Kilobit Round(int digits) => new Kilobit(Math.Round(_value, digits));
        public Kilobit Round(MidpointRounding mode) => new Kilobit(Math.Round(_value, mode));

        public Kilobit Floor() => new Kilobit(Math.Floor(_value));

        public Kilobit Truncate() => new Kilobit(Math.Truncate(_value));

        public Kilobit Abs() => new Kilobit(Math.Abs(_value));

        public bool Equals(Kilobit other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kilobit other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kilobit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kilobit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Kb", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kilobit other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Kb";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kilobit self, Kilobit other) => self.Equals(other);
        public static bool operator !=(Kilobit self, Kilobit other) => !self.Equals(other);

        public static bool operator <(Kilobit self, Kilobit other) => self.CompareTo(other) < 0;
        public static bool operator >(Kilobit self, Kilobit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kilobit self, Kilobit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kilobit self, Kilobit other) => self.CompareTo(other) >= 0;

        public static Kilobit operator +(Kilobit self, Kilobit other) => new Kilobit(self._value + other._value);
        public static Kilobit operator -(Kilobit self, Kilobit other) => new Kilobit(self._value - other._value);

        public static Kilobit operator *(Kilobit self, double other) => new Kilobit(self._value * other);
        public static Kilobit operator *(double self, Kilobit other) => new Kilobit(self * other._value);

        public static Kilobit operator /(Kilobit self, double other) => new Kilobit(self._value / other);

        public static explicit operator double(Kilobit self) => self._value;
        public static explicit operator Kilobit(double self) => new Kilobit(self);
    }
}