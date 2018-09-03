using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic Kilometre (symbol km³).
    /// It is a multiple of the unit <c>Cubic Metre</c>, where:
    /// - 1 Cubic Kilometre = 1,000 Cubic Hectometre
    /// - 1 Cubic Kilometre = 10^9 Cubic Metre
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} km³")]
    public readonly partial struct CubicKilometre : IUnit, IEquatable<CubicKilometre>, IComparable<CubicKilometre> {
        private readonly double _value;

        public const string Symbol = "km³";

        public CubicKilometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public CubicKilometre Ceiling() => new CubicKilometre(Math.Ceiling(_value));

        public CubicKilometre Round() => new CubicKilometre(Math.Round(_value));
        public CubicKilometre Round(int digits) => new CubicKilometre(Math.Round(_value, digits));
        public CubicKilometre Round(MidpointRounding mode) => new CubicKilometre(Math.Round(_value, mode));

        public CubicKilometre Floor() => new CubicKilometre(Math.Floor(_value));

        public CubicKilometre Truncate() => new CubicKilometre(Math.Truncate(_value));

        public CubicKilometre Abs() => new CubicKilometre(Math.Abs(_value));

        public bool Equals(CubicKilometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(CubicKilometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CubicKilometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CubicKilometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} km³", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicKilometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} km³";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(CubicKilometre self, CubicKilometre other) => self.Equals(other);
        public static bool operator !=(CubicKilometre self, CubicKilometre other) => !self.Equals(other);

        public static bool operator <(CubicKilometre self, CubicKilometre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicKilometre self, CubicKilometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicKilometre self, CubicKilometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicKilometre self, CubicKilometre other) => self.CompareTo(other) >= 0;

        public static CubicKilometre operator +(CubicKilometre self, CubicKilometre other) => new CubicKilometre(self._value + other._value);
        public static CubicKilometre operator -(CubicKilometre self, CubicKilometre other) => new CubicKilometre(self._value - other._value);

        public static CubicKilometre operator *(CubicKilometre self, double other) => new CubicKilometre(self._value * other);
        public static CubicKilometre operator *(double self, CubicKilometre other) => new CubicKilometre(self * other._value);

        public static CubicKilometre operator /(CubicKilometre self, double other) => new CubicKilometre(self._value / other);

        public static explicit operator double(CubicKilometre self) => self._value;
        public static explicit operator CubicKilometre(double self) => new CubicKilometre(self);
    }
}