using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square attometre (symbol am²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} am²")]
    public readonly partial struct SquareAttometre : IUnit, IEquatable<SquareAttometre>, IComparable<SquareAttometre> {
        private readonly double _value;

        public const string Symbol = "am²";

        public SquareAttometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareAttometre Ceiling() => new SquareAttometre(Math.Ceiling(_value));

        public SquareAttometre Round() => new SquareAttometre(Math.Round(_value));
        public SquareAttometre Round(int digits) => new SquareAttometre(Math.Round(_value, digits));
        public SquareAttometre Round(MidpointRounding mode) => new SquareAttometre(Math.Round(_value, mode));

        public SquareAttometre Floor() => new SquareAttometre(Math.Floor(_value));

        public SquareAttometre Truncate() => new SquareAttometre(Math.Truncate(_value));

        public SquareAttometre Abs() => new SquareAttometre(Math.Abs(_value));

        public bool Equals(SquareAttometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareAttometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareAttometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareAttometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} am²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareAttometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} am²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareAttometre self, SquareAttometre other) => self.Equals(other);
        public static bool operator !=(SquareAttometre self, SquareAttometre other) => !self.Equals(other);

        public static bool operator <(SquareAttometre self, SquareAttometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareAttometre self, SquareAttometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareAttometre self, SquareAttometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareAttometre self, SquareAttometre other) => self.CompareTo(other) >= 0;

        public static SquareAttometre operator +(SquareAttometre self, SquareAttometre other) => new SquareAttometre(self._value + other._value);
        public static SquareAttometre operator -(SquareAttometre self, SquareAttometre other) => new SquareAttometre(self._value - other._value);

        public static SquareAttometre operator *(SquareAttometre self, double other) => new SquareAttometre(self._value * other);
        public static SquareAttometre operator *(double self, SquareAttometre other) => new SquareAttometre(self * other._value);

        public static SquareAttometre operator /(SquareAttometre self, double other) => new SquareAttometre(self._value / other);

        public static explicit operator double(SquareAttometre self) => self._value;
        public static explicit operator SquareAttometre(double self) => new SquareAttometre(self);
    }
}