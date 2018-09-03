using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square hectometre (symbol hm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hm²")]
    public readonly partial struct SquareHectometre : IUnit, IEquatable<SquareHectometre>, IComparable<SquareHectometre> {
        private readonly double _value;

        public const string Symbol = "hm²";

        public SquareHectometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareHectometre Ceiling() => new SquareHectometre(Math.Ceiling(_value));

        public SquareHectometre Round() => new SquareHectometre(Math.Round(_value));
        public SquareHectometre Round(int digits) => new SquareHectometre(Math.Round(_value, digits));
        public SquareHectometre Round(MidpointRounding mode) => new SquareHectometre(Math.Round(_value, mode));

        public SquareHectometre Floor() => new SquareHectometre(Math.Floor(_value));

        public SquareHectometre Truncate() => new SquareHectometre(Math.Truncate(_value));

        public SquareHectometre Abs() => new SquareHectometre(Math.Abs(_value));

        public bool Equals(SquareHectometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareHectometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareHectometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareHectometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareHectometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareHectometre self, SquareHectometre other) => self.Equals(other);
        public static bool operator !=(SquareHectometre self, SquareHectometre other) => !self.Equals(other);

        public static bool operator <(SquareHectometre self, SquareHectometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareHectometre self, SquareHectometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareHectometre self, SquareHectometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareHectometre self, SquareHectometre other) => self.CompareTo(other) >= 0;

        public static SquareHectometre operator +(SquareHectometre self, SquareHectometre other) => new SquareHectometre(self._value + other._value);
        public static SquareHectometre operator -(SquareHectometre self, SquareHectometre other) => new SquareHectometre(self._value - other._value);

        public static SquareHectometre operator *(SquareHectometre self, double other) => new SquareHectometre(self._value * other);
        public static SquareHectometre operator *(double self, SquareHectometre other) => new SquareHectometre(self * other._value);

        public static SquareHectometre operator /(SquareHectometre self, double other) => new SquareHectometre(self._value / other);

        public static explicit operator double(SquareHectometre self) => self._value;
        public static explicit operator SquareHectometre(double self) => new SquareHectometre(self);
    }
}