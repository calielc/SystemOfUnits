using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic Centimetre (symbol cm³).
    /// It is a multiple of the unit <c>Cubic Metre</c>, where:
    /// - 1,000 Cubic Centimetre = 1 Cubic Decimetre
    /// - 1 Cubic Centimetre = 10^-6 Cubic Metre
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cm³")]
    public readonly partial struct CubicCentimetre : IUnit, IEquatable<CubicCentimetre>, IComparable<CubicCentimetre> {
        private readonly double _value;

        public const string Symbol = "cm³";

        public CubicCentimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public CubicCentimetre Ceiling() => new CubicCentimetre(Math.Ceiling(_value));

        public CubicCentimetre Round() => new CubicCentimetre(Math.Round(_value));
        public CubicCentimetre Round(int digits) => new CubicCentimetre(Math.Round(_value, digits));
        public CubicCentimetre Round(MidpointRounding mode) => new CubicCentimetre(Math.Round(_value, mode));

        public CubicCentimetre Floor() => new CubicCentimetre(Math.Floor(_value));

        public CubicCentimetre Truncate() => new CubicCentimetre(Math.Truncate(_value));

        public CubicCentimetre Abs() => new CubicCentimetre(Math.Abs(_value));

        public bool Equals(CubicCentimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(CubicCentimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CubicCentimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CubicCentimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cm³", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicCentimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} cm³";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(CubicCentimetre self, CubicCentimetre other) => self.Equals(other);
        public static bool operator !=(CubicCentimetre self, CubicCentimetre other) => !self.Equals(other);

        public static bool operator <(CubicCentimetre self, CubicCentimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicCentimetre self, CubicCentimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicCentimetre self, CubicCentimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicCentimetre self, CubicCentimetre other) => self.CompareTo(other) >= 0;

        public static CubicCentimetre operator +(CubicCentimetre self, CubicCentimetre other) => new CubicCentimetre(self._value + other._value);
        public static CubicCentimetre operator -(CubicCentimetre self, CubicCentimetre other) => new CubicCentimetre(self._value - other._value);

        public static CubicCentimetre operator *(CubicCentimetre self, double other) => new CubicCentimetre(self._value * other);
        public static CubicCentimetre operator *(double self, CubicCentimetre other) => new CubicCentimetre(self * other._value);

        public static CubicCentimetre operator /(CubicCentimetre self, double other) => new CubicCentimetre(self._value / other);

        public static explicit operator double(CubicCentimetre self) => self._value;
        public static explicit operator CubicCentimetre(double self) => new CubicCentimetre(self);
    }
}