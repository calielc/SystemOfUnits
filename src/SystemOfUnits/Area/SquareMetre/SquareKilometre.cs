using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square kilometre (symbol km²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} km²")]
    public readonly partial struct SquareKilometre : IUnit, IEquatable<SquareKilometre>, IComparable<SquareKilometre> {
        private readonly double _value;

        public const string Symbol = "km²";

        public SquareKilometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareKilometre Ceiling() => new SquareKilometre(Math.Ceiling(_value));

        public SquareKilometre Round() => new SquareKilometre(Math.Round(_value));
        public SquareKilometre Round(int digits) => new SquareKilometre(Math.Round(_value, digits));
        public SquareKilometre Round(MidpointRounding mode) => new SquareKilometre(Math.Round(_value, mode));

        public SquareKilometre Floor() => new SquareKilometre(Math.Floor(_value));

        public SquareKilometre Truncate() => new SquareKilometre(Math.Truncate(_value));

        public SquareKilometre Abs() => new SquareKilometre(Math.Abs(_value));

        public bool Equals(SquareKilometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareKilometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareKilometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareKilometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} km²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareKilometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} km²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareKilometre self, SquareKilometre other) => self.Equals(other);
        public static bool operator !=(SquareKilometre self, SquareKilometre other) => !self.Equals(other);

        public static bool operator <(SquareKilometre self, SquareKilometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareKilometre self, SquareKilometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareKilometre self, SquareKilometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareKilometre self, SquareKilometre other) => self.CompareTo(other) >= 0;

        public static SquareKilometre operator +(SquareKilometre self, SquareKilometre other) => new SquareKilometre(self._value + other._value);
        public static SquareKilometre operator -(SquareKilometre self, SquareKilometre other) => new SquareKilometre(self._value - other._value);

        public static SquareKilometre operator *(SquareKilometre self, double other) => new SquareKilometre(self._value * other);
        public static SquareKilometre operator *(double self, SquareKilometre other) => new SquareKilometre(self * other._value);

        public static SquareKilometre operator /(SquareKilometre self, double other) => new SquareKilometre(self._value / other);

        public static explicit operator double(SquareKilometre self) => self._value;
        public static explicit operator SquareKilometre(double self) => new SquareKilometre(self);
    }
}