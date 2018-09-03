using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    /// <summary>
    /// Represents a Square femtometre (symbol fm²).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} fm²")]
    public readonly partial struct SquareFemtometre : IUnit, IEquatable<SquareFemtometre>, IComparable<SquareFemtometre> {
        private readonly double _value;

        public const string Symbol = "fm²";

        public SquareFemtometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public SquareFemtometre Ceiling() => new SquareFemtometre(Math.Ceiling(_value));

        public SquareFemtometre Round() => new SquareFemtometre(Math.Round(_value));
        public SquareFemtometre Round(int digits) => new SquareFemtometre(Math.Round(_value, digits));
        public SquareFemtometre Round(MidpointRounding mode) => new SquareFemtometre(Math.Round(_value, mode));

        public SquareFemtometre Floor() => new SquareFemtometre(Math.Floor(_value));

        public SquareFemtometre Truncate() => new SquareFemtometre(Math.Truncate(_value));

        public SquareFemtometre Abs() => new SquareFemtometre(Math.Abs(_value));

        public bool Equals(SquareFemtometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(SquareFemtometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareFemtometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareFemtometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} fm²", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareFemtometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} fm²";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(SquareFemtometre self, SquareFemtometre other) => self.Equals(other);
        public static bool operator !=(SquareFemtometre self, SquareFemtometre other) => !self.Equals(other);

        public static bool operator <(SquareFemtometre self, SquareFemtometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareFemtometre self, SquareFemtometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareFemtometre self, SquareFemtometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareFemtometre self, SquareFemtometre other) => self.CompareTo(other) >= 0;

        public static SquareFemtometre operator +(SquareFemtometre self, SquareFemtometre other) => new SquareFemtometre(self._value + other._value);
        public static SquareFemtometre operator -(SquareFemtometre self, SquareFemtometre other) => new SquareFemtometre(self._value - other._value);

        public static SquareFemtometre operator *(SquareFemtometre self, double other) => new SquareFemtometre(self._value * other);
        public static SquareFemtometre operator *(double self, SquareFemtometre other) => new SquareFemtometre(self * other._value);

        public static SquareFemtometre operator /(SquareFemtometre self, double other) => new SquareFemtometre(self._value / other);

        public static explicit operator double(SquareFemtometre self) => self._value;
        public static explicit operator SquareFemtometre(double self) => new SquareFemtometre(self);
    }
}