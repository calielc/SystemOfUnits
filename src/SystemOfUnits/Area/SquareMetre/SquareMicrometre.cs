using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square micrometre (symbol μm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} μm²")]
    public readonly partial struct SquareMicrometre : IUnit, IEquatable<SquareMicrometre>, IComparable<SquareMicrometre> {
        private readonly double _value;

        public const string Symbol = "μm²";

        public SquareMicrometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareMicrometre Ceiling() => new SquareMicrometre(Math.Ceiling(_value));

        public SquareMicrometre Round() => new SquareMicrometre(Math.Round(_value));
        public SquareMicrometre Round(int digits) => new SquareMicrometre(Math.Round(_value, digits));
        public SquareMicrometre Round(MidpointRounding mode) => new SquareMicrometre(Math.Round(_value, mode));

        public SquareMicrometre Floor() => new SquareMicrometre(Math.Floor(_value));

        public SquareMicrometre Truncate() => new SquareMicrometre(Math.Truncate(_value));

        public SquareMicrometre Abs() => new SquareMicrometre(Math.Abs(_value));

        public bool Equals(SquareMicrometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareMicrometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareMicrometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareMicrometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} μm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareMicrometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} μm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareMicrometre self, SquareMicrometre other) => self.Equals(other);
        public static bool operator !=(SquareMicrometre self, SquareMicrometre other) => !self.Equals(other);

        public static bool operator <(SquareMicrometre self, SquareMicrometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareMicrometre self, SquareMicrometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareMicrometre self, SquareMicrometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareMicrometre self, SquareMicrometre other) => self.CompareTo(other) >= 0;

        public static SquareMicrometre operator +(SquareMicrometre self, SquareMicrometre other) => new SquareMicrometre(self._value + other._value);
        public static SquareMicrometre operator -(SquareMicrometre self, SquareMicrometre other) => new SquareMicrometre(self._value - other._value);

        public static SquareMicrometre operator *(SquareMicrometre self, double other) => new SquareMicrometre(self._value * other);
        public static SquareMicrometre operator *(double self, SquareMicrometre other) => new SquareMicrometre(self * other._value);

        public static SquareMicrometre operator /(SquareMicrometre self, double other) => new SquareMicrometre(self._value / other);

        public static explicit operator double(SquareMicrometre self) => self._value;
        public static explicit operator SquareMicrometre(double self) => new SquareMicrometre(self);
    }
}