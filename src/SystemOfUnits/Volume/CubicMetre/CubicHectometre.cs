using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic Hectometre (symbol hm³).
    /// It is a multiple of the unit <c>Cubic Metre</c>, where:
    /// - 1 Cubic Hectometre = 1,000 Cubic Decametre
    /// - 1 Cubic Hectometre = 10^6 Cubic Metre
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hm³")]
    public readonly partial struct CubicHectometre : IUnit, IEquatable<CubicHectometre>, IComparable<CubicHectometre> {
        private readonly double _value;

        public const string Symbol = "hm³";

        public CubicHectometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public CubicHectometre Ceiling() => new CubicHectometre(Math.Ceiling(_value));

        public CubicHectometre Round() => new CubicHectometre(Math.Round(_value));
        public CubicHectometre Round(int digits) => new CubicHectometre(Math.Round(_value, digits));
        public CubicHectometre Round(MidpointRounding mode) => new CubicHectometre(Math.Round(_value, mode));

        public CubicHectometre Floor() => new CubicHectometre(Math.Floor(_value));

        public CubicHectometre Truncate() => new CubicHectometre(Math.Truncate(_value));

        public CubicHectometre Abs() => new CubicHectometre(Math.Abs(_value));

        public bool Equals(CubicHectometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(CubicHectometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CubicHectometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CubicHectometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hm³", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicHectometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} hm³";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(CubicHectometre self, CubicHectometre other) => self.Equals(other);
        public static bool operator !=(CubicHectometre self, CubicHectometre other) => !self.Equals(other);

        public static bool operator <(CubicHectometre self, CubicHectometre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicHectometre self, CubicHectometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicHectometre self, CubicHectometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicHectometre self, CubicHectometre other) => self.CompareTo(other) >= 0;

        public static CubicHectometre operator +(CubicHectometre self, CubicHectometre other) => new CubicHectometre(self._value + other._value);
        public static CubicHectometre operator -(CubicHectometre self, CubicHectometre other) => new CubicHectometre(self._value - other._value);

        public static CubicHectometre operator *(CubicHectometre self, double other) => new CubicHectometre(self._value * other);
        public static CubicHectometre operator *(double self, CubicHectometre other) => new CubicHectometre(self * other._value);

        public static CubicHectometre operator /(CubicHectometre self, double other) => new CubicHectometre(self._value / other);

        public static explicit operator double(CubicHectometre self) => self._value;
        public static explicit operator CubicHectometre(double self) => new CubicHectometre(self);
    }
}