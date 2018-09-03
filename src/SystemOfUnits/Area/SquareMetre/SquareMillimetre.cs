using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square millimetre (symbol mm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mm²")]
    public readonly partial struct SquareMillimetre : IUnit, IEquatable<SquareMillimetre>, IComparable<SquareMillimetre> {
        private readonly double _value;

        public const string Symbol = "mm²";

        public SquareMillimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareMillimetre Ceiling() => new SquareMillimetre(Math.Ceiling(_value));

        public SquareMillimetre Round() => new SquareMillimetre(Math.Round(_value));
        public SquareMillimetre Round(int digits) => new SquareMillimetre(Math.Round(_value, digits));
        public SquareMillimetre Round(MidpointRounding mode) => new SquareMillimetre(Math.Round(_value, mode));

        public SquareMillimetre Floor() => new SquareMillimetre(Math.Floor(_value));

        public SquareMillimetre Truncate() => new SquareMillimetre(Math.Truncate(_value));

        public SquareMillimetre Abs() => new SquareMillimetre(Math.Abs(_value));

        public bool Equals(SquareMillimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareMillimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareMillimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareMillimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareMillimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareMillimetre self, SquareMillimetre other) => self.Equals(other);
        public static bool operator !=(SquareMillimetre self, SquareMillimetre other) => !self.Equals(other);

        public static bool operator <(SquareMillimetre self, SquareMillimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareMillimetre self, SquareMillimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareMillimetre self, SquareMillimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareMillimetre self, SquareMillimetre other) => self.CompareTo(other) >= 0;

        public static SquareMillimetre operator +(SquareMillimetre self, SquareMillimetre other) => new SquareMillimetre(self._value + other._value);
        public static SquareMillimetre operator -(SquareMillimetre self, SquareMillimetre other) => new SquareMillimetre(self._value - other._value);

        public static SquareMillimetre operator *(SquareMillimetre self, double other) => new SquareMillimetre(self._value * other);
        public static SquareMillimetre operator *(double self, SquareMillimetre other) => new SquareMillimetre(self * other._value);

        public static SquareMillimetre operator /(SquareMillimetre self, double other) => new SquareMillimetre(self._value / other);

        public static explicit operator double(SquareMillimetre self) => self._value;
        public static explicit operator SquareMillimetre(double self) => new SquareMillimetre(self);
    }
}