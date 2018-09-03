using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Others {
    /// <summary>
    /// Represents a Percentage (symbol %).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} %")]
    public readonly partial struct Percentage : IUnit, IEquatable<Percentage>, IComparable<Percentage> {
        private readonly double _value;

        public const string Symbol = "%";

        public Percentage(double value) {
            _value = value;
        }

        public double Value => _value;

        public Percentage Ceiling() => new Percentage(Math.Ceiling(_value));

        public Percentage Round() => new Percentage(Math.Round(_value));
        public Percentage Round(int digits) => new Percentage(Math.Round(_value, digits));
        public Percentage Round(MidpointRounding mode) => new Percentage(Math.Round(_value, mode));

        public Percentage Floor() => new Percentage(Math.Floor(_value));

        public Percentage Truncate() => new Percentage(Math.Truncate(_value));

        public Percentage Abs() => new Percentage(Math.Abs(_value));

        public bool Equals(Percentage other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Percentage other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Percentage other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Percentage)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} %", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Percentage other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} %";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Percentage self, Percentage other) => self.Equals(other);
        public static bool operator !=(Percentage self, Percentage other) => !self.Equals(other);

        public static bool operator <(Percentage self, Percentage other) => self.CompareTo(other) < 0;
        public static bool operator >(Percentage self, Percentage other) => self.CompareTo(other) > 0;
        public static bool operator <=(Percentage self, Percentage other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Percentage self, Percentage other) => self.CompareTo(other) >= 0;

        public static Percentage operator +(Percentage self, Percentage other) => new Percentage(self._value + other._value);
        public static Percentage operator -(Percentage self, Percentage other) => new Percentage(self._value - other._value);

        public static Percentage operator *(Percentage self, double other) => new Percentage(self._value * other);
        public static Percentage operator *(double self, Percentage other) => new Percentage(self * other._value);

        public static Percentage operator /(Percentage self, double other) => new Percentage(self._value / other);

        public static explicit operator double(Percentage self) => self._value;
        public static explicit operator Percentage(double self) => new Percentage(self);
    }
}