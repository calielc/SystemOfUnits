using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic Decimetre (symbol dm³).
    /// It is a multiple of the unit <c>Cubic Metre</c>, where:
    /// - 1,000 Cubic Decimetre = 1 Cubic Metre
    /// - 1 Cubic Decimetre = 10^-3 Cubic Metre
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dm³")]
    public readonly partial struct CubicDecimetre : IUnit, IEquatable<CubicDecimetre>, IComparable<CubicDecimetre> {
        private readonly double _value;

        public const string Symbol = "dm³";

        public CubicDecimetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public CubicDecimetre Ceiling() => new CubicDecimetre(Math.Ceiling(_value));

        public CubicDecimetre Round() => new CubicDecimetre(Math.Round(_value));
        public CubicDecimetre Round(int digits) => new CubicDecimetre(Math.Round(_value, digits));
        public CubicDecimetre Round(MidpointRounding mode) => new CubicDecimetre(Math.Round(_value, mode));

        public CubicDecimetre Floor() => new CubicDecimetre(Math.Floor(_value));

        public CubicDecimetre Truncate() => new CubicDecimetre(Math.Truncate(_value));

        public CubicDecimetre Abs() => new CubicDecimetre(Math.Abs(_value));

        public bool Equals(CubicDecimetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(CubicDecimetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CubicDecimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CubicDecimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dm³", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicDecimetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dm³";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(CubicDecimetre self, CubicDecimetre other) => self.Equals(other);
        public static bool operator !=(CubicDecimetre self, CubicDecimetre other) => !self.Equals(other);

        public static bool operator <(CubicDecimetre self, CubicDecimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicDecimetre self, CubicDecimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicDecimetre self, CubicDecimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicDecimetre self, CubicDecimetre other) => self.CompareTo(other) >= 0;

        public static CubicDecimetre operator +(CubicDecimetre self, CubicDecimetre other) => new CubicDecimetre(self._value + other._value);
        public static CubicDecimetre operator -(CubicDecimetre self, CubicDecimetre other) => new CubicDecimetre(self._value - other._value);

        public static CubicDecimetre operator *(CubicDecimetre self, double other) => new CubicDecimetre(self._value * other);
        public static CubicDecimetre operator *(double self, CubicDecimetre other) => new CubicDecimetre(self * other._value);

        public static CubicDecimetre operator /(CubicDecimetre self, double other) => new CubicDecimetre(self._value / other);

        public static explicit operator double(CubicDecimetre self) => self._value;
        public static explicit operator CubicDecimetre(double self) => new CubicDecimetre(self);
    }
}