using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Megabit (symbol Mb).
    /// It is a multiple of the unit <c>Bit</c>, where:
    /// - 1 Megabit = 1,000 Kilobit
    /// - 1 Megabit = 10^6 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Mb")]
    public readonly partial struct Megabit : IUnit, IEquatable<Megabit>, IComparable<Megabit> {
        private readonly double _value;

        public const string Symbol = "Mb";

        public Megabit(double value) {
            _value = value;
        }

        public double Value => _value;

        public Megabit Ceiling() => new Megabit(Math.Ceiling(_value));

        public Megabit Round() => new Megabit(Math.Round(_value));
        public Megabit Round(int digits) => new Megabit(Math.Round(_value, digits));
        public Megabit Round(MidpointRounding mode) => new Megabit(Math.Round(_value, mode));

        public Megabit Floor() => new Megabit(Math.Floor(_value));

        public Megabit Truncate() => new Megabit(Math.Truncate(_value));

        public Megabit Abs() => new Megabit(Math.Abs(_value));

        public bool Equals(Megabit other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Megabit other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Megabit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Megabit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Mb", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Megabit other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Mb";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Megabit self, Megabit other) => self.Equals(other);
        public static bool operator !=(Megabit self, Megabit other) => !self.Equals(other);

        public static bool operator <(Megabit self, Megabit other) => self.CompareTo(other) < 0;
        public static bool operator >(Megabit self, Megabit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Megabit self, Megabit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Megabit self, Megabit other) => self.CompareTo(other) >= 0;

        public static Megabit operator +(Megabit self, Megabit other) => new Megabit(self._value + other._value);
        public static Megabit operator -(Megabit self, Megabit other) => new Megabit(self._value - other._value);

        public static Megabit operator *(Megabit self, double other) => new Megabit(self._value * other);
        public static Megabit operator *(double self, Megabit other) => new Megabit(self * other._value);

        public static Megabit operator /(Megabit self, double other) => new Megabit(self._value / other);

        public static explicit operator double(Megabit self) => self._value;
        public static explicit operator Megabit(double self) => new Megabit(self);
    }
}