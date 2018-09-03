using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square petametre (symbol Pm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Pm²")]
    public readonly partial struct SquarePetametre : IUnit, IEquatable<SquarePetametre>, IComparable<SquarePetametre> {
        private readonly double _value;

        public const string Symbol = "Pm²";

        public SquarePetametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquarePetametre Ceiling() => new SquarePetametre(Math.Ceiling(_value));

        public SquarePetametre Round() => new SquarePetametre(Math.Round(_value));
        public SquarePetametre Round(int digits) => new SquarePetametre(Math.Round(_value, digits));
        public SquarePetametre Round(MidpointRounding mode) => new SquarePetametre(Math.Round(_value, mode));

        public SquarePetametre Floor() => new SquarePetametre(Math.Floor(_value));

        public SquarePetametre Truncate() => new SquarePetametre(Math.Truncate(_value));

        public SquarePetametre Abs() => new SquarePetametre(Math.Abs(_value));

        public bool Equals(SquarePetametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquarePetametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquarePetametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquarePetametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Pm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquarePetametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Pm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquarePetametre self, SquarePetametre other) => self.Equals(other);
        public static bool operator !=(SquarePetametre self, SquarePetametre other) => !self.Equals(other);

        public static bool operator <(SquarePetametre self, SquarePetametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquarePetametre self, SquarePetametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquarePetametre self, SquarePetametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquarePetametre self, SquarePetametre other) => self.CompareTo(other) >= 0;

        public static SquarePetametre operator +(SquarePetametre self, SquarePetametre other) => new SquarePetametre(self._value + other._value);
        public static SquarePetametre operator -(SquarePetametre self, SquarePetametre other) => new SquarePetametre(self._value - other._value);

        public static SquarePetametre operator *(SquarePetametre self, double other) => new SquarePetametre(self._value * other);
        public static SquarePetametre operator *(double self, SquarePetametre other) => new SquarePetametre(self * other._value);

        public static SquarePetametre operator /(SquarePetametre self, double other) => new SquarePetametre(self._value / other);

        public static explicit operator double(SquarePetametre self) => self._value;
        public static explicit operator SquarePetametre(double self) => new SquarePetametre(self);
    }
}