using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square terametre (symbol Tm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Tm²")]
    public readonly partial struct SquareTerametre : IUnit, IEquatable<SquareTerametre>, IComparable<SquareTerametre> {
        private readonly double _value;

        public const string Symbol = "Tm²";

        public SquareTerametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareTerametre Ceiling() => new SquareTerametre(Math.Ceiling(_value));

        public SquareTerametre Round() => new SquareTerametre(Math.Round(_value));
        public SquareTerametre Round(int digits) => new SquareTerametre(Math.Round(_value, digits));
        public SquareTerametre Round(MidpointRounding mode) => new SquareTerametre(Math.Round(_value, mode));

        public SquareTerametre Floor() => new SquareTerametre(Math.Floor(_value));

        public SquareTerametre Truncate() => new SquareTerametre(Math.Truncate(_value));

        public SquareTerametre Abs() => new SquareTerametre(Math.Abs(_value));

        public bool Equals(SquareTerametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareTerametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareTerametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareTerametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Tm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareTerametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Tm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareTerametre self, SquareTerametre other) => self.Equals(other);
        public static bool operator !=(SquareTerametre self, SquareTerametre other) => !self.Equals(other);

        public static bool operator <(SquareTerametre self, SquareTerametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareTerametre self, SquareTerametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareTerametre self, SquareTerametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareTerametre self, SquareTerametre other) => self.CompareTo(other) >= 0;

        public static SquareTerametre operator +(SquareTerametre self, SquareTerametre other) => new SquareTerametre(self._value + other._value);
        public static SquareTerametre operator -(SquareTerametre self, SquareTerametre other) => new SquareTerametre(self._value - other._value);

        public static SquareTerametre operator *(SquareTerametre self, double other) => new SquareTerametre(self._value * other);
        public static SquareTerametre operator *(double self, SquareTerametre other) => new SquareTerametre(self * other._value);

        public static SquareTerametre operator /(SquareTerametre self, double other) => new SquareTerametre(self._value / other);

        public static explicit operator double(SquareTerametre self) => self._value;
        public static explicit operator SquareTerametre(double self) => new SquareTerametre(self);
    }
}