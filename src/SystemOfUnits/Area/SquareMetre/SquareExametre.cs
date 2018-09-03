using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square exametre (symbol Em²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Em²")]
    public readonly partial struct SquareExametre : IUnit, IEquatable<SquareExametre>, IComparable<SquareExametre> {
        private readonly double _value;

        public const string Symbol = "Em²";

        public SquareExametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareExametre Ceiling() => new SquareExametre(Math.Ceiling(_value));

        public SquareExametre Round() => new SquareExametre(Math.Round(_value));
        public SquareExametre Round(int digits) => new SquareExametre(Math.Round(_value, digits));
        public SquareExametre Round(MidpointRounding mode) => new SquareExametre(Math.Round(_value, mode));

        public SquareExametre Floor() => new SquareExametre(Math.Floor(_value));

        public SquareExametre Truncate() => new SquareExametre(Math.Truncate(_value));

        public SquareExametre Abs() => new SquareExametre(Math.Abs(_value));

        public bool Equals(SquareExametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareExametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareExametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareExametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Em²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareExametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Em²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareExametre self, SquareExametre other) => self.Equals(other);
        public static bool operator !=(SquareExametre self, SquareExametre other) => !self.Equals(other);

        public static bool operator <(SquareExametre self, SquareExametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareExametre self, SquareExametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareExametre self, SquareExametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareExametre self, SquareExametre other) => self.CompareTo(other) >= 0;

        public static SquareExametre operator +(SquareExametre self, SquareExametre other) => new SquareExametre(self._value + other._value);
        public static SquareExametre operator -(SquareExametre self, SquareExametre other) => new SquareExametre(self._value - other._value);

        public static SquareExametre operator *(SquareExametre self, double other) => new SquareExametre(self._value * other);
        public static SquareExametre operator *(double self, SquareExametre other) => new SquareExametre(self * other._value);

        public static SquareExametre operator /(SquareExametre self, double other) => new SquareExametre(self._value / other);

        public static explicit operator double(SquareExametre self) => self._value;
        public static explicit operator SquareExametre(double self) => new SquareExametre(self);
    }
}