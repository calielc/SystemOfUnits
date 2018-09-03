using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square decametre (symbol dam²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dam²")]
    public readonly partial struct SquareDecametre : IUnit, IEquatable<SquareDecametre>, IComparable<SquareDecametre> {
        private readonly double _value;

        public const string Symbol = "dam²";

        public SquareDecametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareDecametre Ceiling() => new SquareDecametre(Math.Ceiling(_value));

        public SquareDecametre Round() => new SquareDecametre(Math.Round(_value));
        public SquareDecametre Round(int digits) => new SquareDecametre(Math.Round(_value, digits));
        public SquareDecametre Round(MidpointRounding mode) => new SquareDecametre(Math.Round(_value, mode));

        public SquareDecametre Floor() => new SquareDecametre(Math.Floor(_value));

        public SquareDecametre Truncate() => new SquareDecametre(Math.Truncate(_value));

        public SquareDecametre Abs() => new SquareDecametre(Math.Abs(_value));

        public bool Equals(SquareDecametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareDecametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareDecametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareDecametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dam²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareDecametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dam²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareDecametre self, SquareDecametre other) => self.Equals(other);
        public static bool operator !=(SquareDecametre self, SquareDecametre other) => !self.Equals(other);

        public static bool operator <(SquareDecametre self, SquareDecametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareDecametre self, SquareDecametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareDecametre self, SquareDecametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareDecametre self, SquareDecametre other) => self.CompareTo(other) >= 0;

        public static SquareDecametre operator +(SquareDecametre self, SquareDecametre other) => new SquareDecametre(self._value + other._value);
        public static SquareDecametre operator -(SquareDecametre self, SquareDecametre other) => new SquareDecametre(self._value - other._value);

        public static SquareDecametre operator *(SquareDecametre self, double other) => new SquareDecametre(self._value * other);
        public static SquareDecametre operator *(double self, SquareDecametre other) => new SquareDecametre(self * other._value);

        public static SquareDecametre operator /(SquareDecametre self, double other) => new SquareDecametre(self._value / other);

        public static explicit operator double(SquareDecametre self) => self._value;
        public static explicit operator SquareDecametre(double self) => new SquareDecametre(self);
    }
}