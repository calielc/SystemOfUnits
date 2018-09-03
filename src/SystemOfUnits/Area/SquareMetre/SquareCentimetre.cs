using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square centimetre (symbol cm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cm²")]
    public readonly partial struct SquareCentimetre : IUnit, IEquatable<SquareCentimetre>, IComparable<SquareCentimetre> {
        private readonly double _value;

        public const string Symbol = "cm²";

        public SquareCentimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareCentimetre Ceiling() => new SquareCentimetre(Math.Ceiling(_value));

        public SquareCentimetre Round() => new SquareCentimetre(Math.Round(_value));
        public SquareCentimetre Round(int digits) => new SquareCentimetre(Math.Round(_value, digits));
        public SquareCentimetre Round(MidpointRounding mode) => new SquareCentimetre(Math.Round(_value, mode));

        public SquareCentimetre Floor() => new SquareCentimetre(Math.Floor(_value));

        public SquareCentimetre Truncate() => new SquareCentimetre(Math.Truncate(_value));

        public SquareCentimetre Abs() => new SquareCentimetre(Math.Abs(_value));

        public bool Equals(SquareCentimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareCentimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareCentimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareCentimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareCentimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} cm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareCentimetre self, SquareCentimetre other) => self.Equals(other);
        public static bool operator !=(SquareCentimetre self, SquareCentimetre other) => !self.Equals(other);

        public static bool operator <(SquareCentimetre self, SquareCentimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareCentimetre self, SquareCentimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareCentimetre self, SquareCentimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareCentimetre self, SquareCentimetre other) => self.CompareTo(other) >= 0;

        public static SquareCentimetre operator +(SquareCentimetre self, SquareCentimetre other) => new SquareCentimetre(self._value + other._value);
        public static SquareCentimetre operator -(SquareCentimetre self, SquareCentimetre other) => new SquareCentimetre(self._value - other._value);

        public static SquareCentimetre operator *(SquareCentimetre self, double other) => new SquareCentimetre(self._value * other);
        public static SquareCentimetre operator *(double self, SquareCentimetre other) => new SquareCentimetre(self * other._value);

        public static SquareCentimetre operator /(SquareCentimetre self, double other) => new SquareCentimetre(self._value / other);

        public static explicit operator double(SquareCentimetre self) => self._value;
        public static explicit operator SquareCentimetre(double self) => new SquareCentimetre(self);
    }
}