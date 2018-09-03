using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square metre (symbol m²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} m²")]
    public readonly partial struct SquareMetre : IUnit, IEquatable<SquareMetre>, IComparable<SquareMetre> {
        private readonly double _value;

        public const string Symbol = "m²";

        public SquareMetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareMetre Ceiling() => new SquareMetre(Math.Ceiling(_value));

        public SquareMetre Round() => new SquareMetre(Math.Round(_value));
        public SquareMetre Round(int digits) => new SquareMetre(Math.Round(_value, digits));
        public SquareMetre Round(MidpointRounding mode) => new SquareMetre(Math.Round(_value, mode));

        public SquareMetre Floor() => new SquareMetre(Math.Floor(_value));

        public SquareMetre Truncate() => new SquareMetre(Math.Truncate(_value));

        public SquareMetre Abs() => new SquareMetre(Math.Abs(_value));

        public bool Equals(SquareMetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareMetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareMetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareMetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} m²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareMetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} m²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareMetre self, SquareMetre other) => self.Equals(other);
        public static bool operator !=(SquareMetre self, SquareMetre other) => !self.Equals(other);

        public static bool operator <(SquareMetre self, SquareMetre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareMetre self, SquareMetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareMetre self, SquareMetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareMetre self, SquareMetre other) => self.CompareTo(other) >= 0;

        public static SquareMetre operator +(SquareMetre self, SquareMetre other) => new SquareMetre(self._value + other._value);
        public static SquareMetre operator -(SquareMetre self, SquareMetre other) => new SquareMetre(self._value - other._value);

        public static SquareMetre operator *(SquareMetre self, double other) => new SquareMetre(self._value * other);
        public static SquareMetre operator *(double self, SquareMetre other) => new SquareMetre(self * other._value);

        public static SquareMetre operator /(SquareMetre self, double other) => new SquareMetre(self._value / other);

        public static explicit operator double(SquareMetre self) => self._value;
        public static explicit operator SquareMetre(double self) => new SquareMetre(self);
    }
}