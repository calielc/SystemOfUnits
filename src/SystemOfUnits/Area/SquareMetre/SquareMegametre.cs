using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square megametre (symbol Mm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Mm²")]
    public readonly partial struct SquareMegametre : IUnit, IEquatable<SquareMegametre>, IComparable<SquareMegametre> {
        private readonly double _value;

        public const string Symbol = "Mm²";

        public SquareMegametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareMegametre Ceiling() => new SquareMegametre(Math.Ceiling(_value));

        public SquareMegametre Round() => new SquareMegametre(Math.Round(_value));
        public SquareMegametre Round(int digits) => new SquareMegametre(Math.Round(_value, digits));
        public SquareMegametre Round(MidpointRounding mode) => new SquareMegametre(Math.Round(_value, mode));

        public SquareMegametre Floor() => new SquareMegametre(Math.Floor(_value));

        public SquareMegametre Truncate() => new SquareMegametre(Math.Truncate(_value));

        public SquareMegametre Abs() => new SquareMegametre(Math.Abs(_value));

        public bool Equals(SquareMegametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareMegametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareMegametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareMegametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Mm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareMegametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Mm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareMegametre self, SquareMegametre other) => self.Equals(other);
        public static bool operator !=(SquareMegametre self, SquareMegametre other) => !self.Equals(other);

        public static bool operator <(SquareMegametre self, SquareMegametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareMegametre self, SquareMegametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareMegametre self, SquareMegametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareMegametre self, SquareMegametre other) => self.CompareTo(other) >= 0;

        public static SquareMegametre operator +(SquareMegametre self, SquareMegametre other) => new SquareMegametre(self._value + other._value);
        public static SquareMegametre operator -(SquareMegametre self, SquareMegametre other) => new SquareMegametre(self._value - other._value);

        public static SquareMegametre operator *(SquareMegametre self, double other) => new SquareMegametre(self._value * other);
        public static SquareMegametre operator *(double self, SquareMegametre other) => new SquareMegametre(self * other._value);

        public static SquareMegametre operator /(SquareMegametre self, double other) => new SquareMegametre(self._value / other);

        public static explicit operator double(SquareMegametre self) => self._value;
        public static explicit operator SquareMegametre(double self) => new SquareMegametre(self);
    }
}