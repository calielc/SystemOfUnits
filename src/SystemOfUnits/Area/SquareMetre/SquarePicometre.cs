using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square picometre (symbol pm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} pm²")]
    public readonly partial struct SquarePicometre : IUnit, IEquatable<SquarePicometre>, IComparable<SquarePicometre> {
        private readonly double _value;

        public const string Symbol = "pm²";

        public SquarePicometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquarePicometre Ceiling() => new SquarePicometre(Math.Ceiling(_value));

        public SquarePicometre Round() => new SquarePicometre(Math.Round(_value));
        public SquarePicometre Round(int digits) => new SquarePicometre(Math.Round(_value, digits));
        public SquarePicometre Round(MidpointRounding mode) => new SquarePicometre(Math.Round(_value, mode));

        public SquarePicometre Floor() => new SquarePicometre(Math.Floor(_value));

        public SquarePicometre Truncate() => new SquarePicometre(Math.Truncate(_value));

        public SquarePicometre Abs() => new SquarePicometre(Math.Abs(_value));

        public bool Equals(SquarePicometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquarePicometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquarePicometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquarePicometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} pm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquarePicometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} pm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquarePicometre self, SquarePicometre other) => self.Equals(other);
        public static bool operator !=(SquarePicometre self, SquarePicometre other) => !self.Equals(other);

        public static bool operator <(SquarePicometre self, SquarePicometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquarePicometre self, SquarePicometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquarePicometre self, SquarePicometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquarePicometre self, SquarePicometre other) => self.CompareTo(other) >= 0;

        public static SquarePicometre operator +(SquarePicometre self, SquarePicometre other) => new SquarePicometre(self._value + other._value);
        public static SquarePicometre operator -(SquarePicometre self, SquarePicometre other) => new SquarePicometre(self._value - other._value);

        public static SquarePicometre operator *(SquarePicometre self, double other) => new SquarePicometre(self._value * other);
        public static SquarePicometre operator *(double self, SquarePicometre other) => new SquarePicometre(self * other._value);

        public static SquarePicometre operator /(SquarePicometre self, double other) => new SquarePicometre(self._value / other);

        public static explicit operator double(SquarePicometre self) => self._value;
        public static explicit operator SquarePicometre(double self) => new SquarePicometre(self);
    }
}