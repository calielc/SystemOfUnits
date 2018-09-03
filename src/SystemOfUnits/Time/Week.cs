using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    /// <summary>
    /// Represents a Week (symbol weeks).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} weeks")]
    public readonly partial struct Week : IUnit, IEquatable<Week>, IComparable<Week> {
        private readonly double _value;

        public const string Symbol = "weeks";

        public Week(double value) {
            _value = value;
        }

        public double Value => _value;

        public Week Ceiling() => new Week(Math.Ceiling(_value));

        public Week Round() => new Week(Math.Round(_value));
        public Week Round(int digits) => new Week(Math.Round(_value, digits));
        public Week Round(MidpointRounding mode) => new Week(Math.Round(_value, mode));

        public Week Floor() => new Week(Math.Floor(_value));

        public Week Truncate() => new Week(Math.Truncate(_value));

        public Week Abs() => new Week(Math.Abs(_value));

        public bool Equals(Week other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Week other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Week other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Week)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} weeks", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Week other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} weeks";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Week self, Week other) => self.Equals(other);
        public static bool operator !=(Week self, Week other) => !self.Equals(other);

        public static bool operator <(Week self, Week other) => self.CompareTo(other) < 0;
        public static bool operator >(Week self, Week other) => self.CompareTo(other) > 0;
        public static bool operator <=(Week self, Week other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Week self, Week other) => self.CompareTo(other) >= 0;

        public static Week operator +(Week self, Week other) => new Week(self._value + other._value);
        public static Week operator -(Week self, Week other) => new Week(self._value - other._value);

        public static Week operator *(Week self, double other) => new Week(self._value * other);
        public static Week operator *(double self, Week other) => new Week(self * other._value);

        public static Week operator /(Week self, double other) => new Week(self._value / other);

        public static explicit operator double(Week self) => self._value;
        public static explicit operator Week(double self) => new Week(self);
    }
}