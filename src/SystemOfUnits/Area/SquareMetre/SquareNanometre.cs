using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square nanometre (symbol nm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} nm²")]
    public readonly partial struct SquareNanometre : IUnit, IEquatable<SquareNanometre>, IComparable<SquareNanometre> {
        private readonly double _value;

        public const string Symbol = "nm²";

        public SquareNanometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareNanometre Ceiling() => new SquareNanometre(Math.Ceiling(_value));

        public SquareNanometre Round() => new SquareNanometre(Math.Round(_value));
        public SquareNanometre Round(int digits) => new SquareNanometre(Math.Round(_value, digits));
        public SquareNanometre Round(MidpointRounding mode) => new SquareNanometre(Math.Round(_value, mode));

        public SquareNanometre Floor() => new SquareNanometre(Math.Floor(_value));

        public SquareNanometre Truncate() => new SquareNanometre(Math.Truncate(_value));

        public SquareNanometre Abs() => new SquareNanometre(Math.Abs(_value));

        public bool Equals(SquareNanometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareNanometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareNanometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareNanometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} nm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareNanometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} nm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareNanometre self, SquareNanometre other) => self.Equals(other);
        public static bool operator !=(SquareNanometre self, SquareNanometre other) => !self.Equals(other);

        public static bool operator <(SquareNanometre self, SquareNanometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareNanometre self, SquareNanometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareNanometre self, SquareNanometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareNanometre self, SquareNanometre other) => self.CompareTo(other) >= 0;

        public static SquareNanometre operator +(SquareNanometre self, SquareNanometre other) => new SquareNanometre(self._value + other._value);
        public static SquareNanometre operator -(SquareNanometre self, SquareNanometre other) => new SquareNanometre(self._value - other._value);

        public static SquareNanometre operator *(SquareNanometre self, double other) => new SquareNanometre(self._value * other);
        public static SquareNanometre operator *(double self, SquareNanometre other) => new SquareNanometre(self * other._value);

        public static SquareNanometre operator /(SquareNanometre self, double other) => new SquareNanometre(self._value / other);

        public static explicit operator double(SquareNanometre self) => self._value;
        public static explicit operator SquareNanometre(double self) => new SquareNanometre(self);
    }
}