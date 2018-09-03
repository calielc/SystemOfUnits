using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Gigabit (symbol Gb).
    /// It is a multiple of the unit <c>Bit</c>, where:
    /// - 1 Gigabit = 1,000 Megabit
    /// - 1 Gigabit = 10^9 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Gb")]
    public readonly partial struct Gigabit : IUnit, IEquatable<Gigabit>, IComparable<Gigabit> {
        private readonly double _value;

        public const string Symbol = "Gb";

        public Gigabit(double value) {
            _value = value;
        }

        public double Value => _value;

        public Gigabit Ceiling() => new Gigabit(Math.Ceiling(_value));

        public Gigabit Round() => new Gigabit(Math.Round(_value));
        public Gigabit Round(int digits) => new Gigabit(Math.Round(_value, digits));
        public Gigabit Round(MidpointRounding mode) => new Gigabit(Math.Round(_value, mode));

        public Gigabit Floor() => new Gigabit(Math.Floor(_value));

        public Gigabit Truncate() => new Gigabit(Math.Truncate(_value));

        public Gigabit Abs() => new Gigabit(Math.Abs(_value));

        public bool Equals(Gigabit other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Gigabit other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Gigabit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Gigabit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Gb", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Gigabit other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Gb";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Gigabit self, Gigabit other) => self.Equals(other);
        public static bool operator !=(Gigabit self, Gigabit other) => !self.Equals(other);

        public static bool operator <(Gigabit self, Gigabit other) => self.CompareTo(other) < 0;
        public static bool operator >(Gigabit self, Gigabit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Gigabit self, Gigabit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Gigabit self, Gigabit other) => self.CompareTo(other) >= 0;

        public static Gigabit operator +(Gigabit self, Gigabit other) => new Gigabit(self._value + other._value);
        public static Gigabit operator -(Gigabit self, Gigabit other) => new Gigabit(self._value - other._value);

        public static Gigabit operator *(Gigabit self, double other) => new Gigabit(self._value * other);
        public static Gigabit operator *(double self, Gigabit other) => new Gigabit(self * other._value);

        public static Gigabit operator /(Gigabit self, double other) => new Gigabit(self._value / other);

        public static explicit operator double(Gigabit self) => self._value;
        public static explicit operator Gigabit(double self) => new Gigabit(self);
    }
}