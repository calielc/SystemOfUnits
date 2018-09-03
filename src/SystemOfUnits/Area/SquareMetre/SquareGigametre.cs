using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square gigametre (symbol Gm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Gm²")]
    public readonly partial struct SquareGigametre : IUnit, IEquatable<SquareGigametre>, IComparable<SquareGigametre> {
        private readonly double _value;

        public const string Symbol = "Gm²";

        public SquareGigametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareGigametre Ceiling() => new SquareGigametre(Math.Ceiling(_value));

        public SquareGigametre Round() => new SquareGigametre(Math.Round(_value));
        public SquareGigametre Round(int digits) => new SquareGigametre(Math.Round(_value, digits));
        public SquareGigametre Round(MidpointRounding mode) => new SquareGigametre(Math.Round(_value, mode));

        public SquareGigametre Floor() => new SquareGigametre(Math.Floor(_value));

        public SquareGigametre Truncate() => new SquareGigametre(Math.Truncate(_value));

        public SquareGigametre Abs() => new SquareGigametre(Math.Abs(_value));

        public bool Equals(SquareGigametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareGigametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareGigametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareGigametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Gm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareGigametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Gm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareGigametre self, SquareGigametre other) => self.Equals(other);
        public static bool operator !=(SquareGigametre self, SquareGigametre other) => !self.Equals(other);

        public static bool operator <(SquareGigametre self, SquareGigametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareGigametre self, SquareGigametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareGigametre self, SquareGigametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareGigametre self, SquareGigametre other) => self.CompareTo(other) >= 0;

        public static SquareGigametre operator +(SquareGigametre self, SquareGigametre other) => new SquareGigametre(self._value + other._value);
        public static SquareGigametre operator -(SquareGigametre self, SquareGigametre other) => new SquareGigametre(self._value - other._value);

        public static SquareGigametre operator *(SquareGigametre self, double other) => new SquareGigametre(self._value * other);
        public static SquareGigametre operator *(double self, SquareGigametre other) => new SquareGigametre(self * other._value);

        public static SquareGigametre operator /(SquareGigametre self, double other) => new SquareGigametre(self._value / other);

        public static explicit operator double(SquareGigametre self) => self._value;
        public static explicit operator SquareGigametre(double self) => new SquareGigametre(self);
    }
}