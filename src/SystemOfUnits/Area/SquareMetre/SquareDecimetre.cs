using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square decimetre (symbol dm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dm²")]
    public readonly partial struct SquareDecimetre : IUnit, IEquatable<SquareDecimetre>, IComparable<SquareDecimetre> {
        private readonly double _value;

        public const string Symbol = "dm²";

        public SquareDecimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareDecimetre Ceiling() => new SquareDecimetre(Math.Ceiling(_value));

        public SquareDecimetre Round() => new SquareDecimetre(Math.Round(_value));
        public SquareDecimetre Round(int digits) => new SquareDecimetre(Math.Round(_value, digits));
        public SquareDecimetre Round(MidpointRounding mode) => new SquareDecimetre(Math.Round(_value, mode));

        public SquareDecimetre Floor() => new SquareDecimetre(Math.Floor(_value));

        public SquareDecimetre Truncate() => new SquareDecimetre(Math.Truncate(_value));

        public SquareDecimetre Abs() => new SquareDecimetre(Math.Abs(_value));

        public bool Equals(SquareDecimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareDecimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareDecimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareDecimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareDecimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareDecimetre self, SquareDecimetre other) => self.Equals(other);
        public static bool operator !=(SquareDecimetre self, SquareDecimetre other) => !self.Equals(other);

        public static bool operator <(SquareDecimetre self, SquareDecimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareDecimetre self, SquareDecimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareDecimetre self, SquareDecimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareDecimetre self, SquareDecimetre other) => self.CompareTo(other) >= 0;

        public static SquareDecimetre operator +(SquareDecimetre self, SquareDecimetre other) => new SquareDecimetre(self._value + other._value);
        public static SquareDecimetre operator -(SquareDecimetre self, SquareDecimetre other) => new SquareDecimetre(self._value - other._value);

        public static SquareDecimetre operator *(SquareDecimetre self, double other) => new SquareDecimetre(self._value * other);
        public static SquareDecimetre operator *(double self, SquareDecimetre other) => new SquareDecimetre(self * other._value);

        public static SquareDecimetre operator /(SquareDecimetre self, double other) => new SquareDecimetre(self._value / other);

        public static explicit operator double(SquareDecimetre self) => self._value;
        public static explicit operator SquareDecimetre(double self) => new SquareDecimetre(self);
    }
}