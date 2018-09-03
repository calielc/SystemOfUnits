using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.DigitalInformation.Bit {
    /// <summary>
    /// Represents a Terabit (symbol Tb).
    /// It is a multiple of the unit <c>Bit</c>, where:
    /// - 1 Terabit = 1,000 Gigabit
    /// - 1 Terabit = 10^12 Bits
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Tb")]
    public readonly partial struct Terabit : IUnit, IEquatable<Terabit>, IComparable<Terabit> {
        private readonly double _value;

        public const string Symbol = "Tb";

        public Terabit(double value) {
            _value = value;
        }

        public double Value => _value;

        public Terabit Ceiling() => new Terabit(Math.Ceiling(_value));

        public Terabit Round() => new Terabit(Math.Round(_value));
        public Terabit Round(int digits) => new Terabit(Math.Round(_value, digits));
        public Terabit Round(MidpointRounding mode) => new Terabit(Math.Round(_value, mode));

        public Terabit Floor() => new Terabit(Math.Floor(_value));

        public Terabit Truncate() => new Terabit(Math.Truncate(_value));

        public Terabit Abs() => new Terabit(Math.Abs(_value));

        public bool Equals(Terabit other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Terabit other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Terabit other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Terabit)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Tb", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Terabit other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Tb";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Terabit self, Terabit other) => self.Equals(other);
        public static bool operator !=(Terabit self, Terabit other) => !self.Equals(other);

        public static bool operator <(Terabit self, Terabit other) => self.CompareTo(other) < 0;
        public static bool operator >(Terabit self, Terabit other) => self.CompareTo(other) > 0;
        public static bool operator <=(Terabit self, Terabit other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Terabit self, Terabit other) => self.CompareTo(other) >= 0;

        public static Terabit operator +(Terabit self, Terabit other) => new Terabit(self._value + other._value);
        public static Terabit operator -(Terabit self, Terabit other) => new Terabit(self._value - other._value);

        public static Terabit operator *(Terabit self, double other) => new Terabit(self._value * other);
        public static Terabit operator *(double self, Terabit other) => new Terabit(self * other._value);

        public static Terabit operator /(Terabit self, double other) => new Terabit(self._value / other);

        public static explicit operator double(Terabit self) => self._value;
        public static explicit operator Terabit(double self) => new Terabit(self);
    }
}