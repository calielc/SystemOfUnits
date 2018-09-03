using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic Decametre (symbol dam³).
    /// It is a multiple of the unit <c>Cubic Metre</c>, where:
    /// - 1 Cubic Decametre = 1,000 Cubic Metre
    /// - 1 Cubic Decametre = 10^3 Cubic Metre
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dam³")]
    public readonly partial struct CubicDecametre : IUnit, IEquatable<CubicDecametre>, IComparable<CubicDecametre> {
        private readonly double _value;

        public const string Symbol = "dam³";

        public CubicDecametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public CubicDecametre Ceiling() => new CubicDecametre(Math.Ceiling(_value));

        public CubicDecametre Round() => new CubicDecametre(Math.Round(_value));
        public CubicDecametre Round(int digits) => new CubicDecametre(Math.Round(_value, digits));
        public CubicDecametre Round(MidpointRounding mode) => new CubicDecametre(Math.Round(_value, mode));

        public CubicDecametre Floor() => new CubicDecametre(Math.Floor(_value));

        public CubicDecametre Truncate() => new CubicDecametre(Math.Truncate(_value));

        public CubicDecametre Abs() => new CubicDecametre(Math.Abs(_value));

        public bool Equals(CubicDecametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(CubicDecametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CubicDecametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CubicDecametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dam³", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicDecametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dam³";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(CubicDecametre self, CubicDecametre other) => self.Equals(other);
        public static bool operator !=(CubicDecametre self, CubicDecametre other) => !self.Equals(other);

        public static bool operator <(CubicDecametre self, CubicDecametre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicDecametre self, CubicDecametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicDecametre self, CubicDecametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicDecametre self, CubicDecametre other) => self.CompareTo(other) >= 0;

        public static CubicDecametre operator +(CubicDecametre self, CubicDecametre other) => new CubicDecametre(self._value + other._value);
        public static CubicDecametre operator -(CubicDecametre self, CubicDecametre other) => new CubicDecametre(self._value - other._value);

        public static CubicDecametre operator *(CubicDecametre self, double other) => new CubicDecametre(self._value * other);
        public static CubicDecametre operator *(double self, CubicDecametre other) => new CubicDecametre(self * other._value);

        public static CubicDecametre operator /(CubicDecametre self, double other) => new CubicDecametre(self._value / other);

        public static explicit operator double(CubicDecametre self) => self._value;
        public static explicit operator CubicDecametre(double self) => new CubicDecametre(self);
    }
}