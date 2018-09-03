using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic Millimetre (symbol mm³).
    /// It is a multiple of the unit <c>Cubic Metre</c>, where:
    /// - 1,000 Cubic Millimetre = 1 Cubic Centimetre
    /// - 1 Cubic Millimetre = 10^-9 Cubic Metre
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mm³")]
    public readonly partial struct CubicMillimetre : IUnit, IEquatable<CubicMillimetre>, IComparable<CubicMillimetre> {
        private readonly double _value;

        public const string Symbol = "mm³";

        public CubicMillimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public CubicMillimetre Ceiling() => new CubicMillimetre(Math.Ceiling(_value));

        public CubicMillimetre Round() => new CubicMillimetre(Math.Round(_value));
        public CubicMillimetre Round(int digits) => new CubicMillimetre(Math.Round(_value, digits));
        public CubicMillimetre Round(MidpointRounding mode) => new CubicMillimetre(Math.Round(_value, mode));

        public CubicMillimetre Floor() => new CubicMillimetre(Math.Floor(_value));

        public CubicMillimetre Truncate() => new CubicMillimetre(Math.Truncate(_value));

        public CubicMillimetre Abs() => new CubicMillimetre(Math.Abs(_value));

        public bool Equals(CubicMillimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(CubicMillimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CubicMillimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CubicMillimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mm³", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicMillimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mm³";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(CubicMillimetre self, CubicMillimetre other) => self.Equals(other);
        public static bool operator !=(CubicMillimetre self, CubicMillimetre other) => !self.Equals(other);

        public static bool operator <(CubicMillimetre self, CubicMillimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicMillimetre self, CubicMillimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicMillimetre self, CubicMillimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicMillimetre self, CubicMillimetre other) => self.CompareTo(other) >= 0;

        public static CubicMillimetre operator +(CubicMillimetre self, CubicMillimetre other) => new CubicMillimetre(self._value + other._value);
        public static CubicMillimetre operator -(CubicMillimetre self, CubicMillimetre other) => new CubicMillimetre(self._value - other._value);

        public static CubicMillimetre operator *(CubicMillimetre self, double other) => new CubicMillimetre(self._value * other);
        public static CubicMillimetre operator *(double self, CubicMillimetre other) => new CubicMillimetre(self * other._value);

        public static CubicMillimetre operator /(CubicMillimetre self, double other) => new CubicMillimetre(self._value / other);

        public static explicit operator double(CubicMillimetre self) => self._value;
        public static explicit operator CubicMillimetre(double self) => new CubicMillimetre(self);
    }
}