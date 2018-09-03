using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic metre (symbol m³).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} m³")]
    public readonly partial struct CubicMetre : IUnit, IEquatable<CubicMetre>, IComparable<CubicMetre> {
        private readonly double _value;

        public const string Symbol = "m³";

        public CubicMetre(double value) {
            _value = value;
        }

        public double Value => _value;

        public CubicMetre Ceiling() => new CubicMetre(Math.Ceiling(_value));

        public CubicMetre Round() => new CubicMetre(Math.Round(_value));
        public CubicMetre Round(int digits) => new CubicMetre(Math.Round(_value, digits));
        public CubicMetre Round(MidpointRounding mode) => new CubicMetre(Math.Round(_value, mode));

        public CubicMetre Floor() => new CubicMetre(Math.Floor(_value));

        public CubicMetre Truncate() => new CubicMetre(Math.Truncate(_value));

        public CubicMetre Abs() => new CubicMetre(Math.Abs(_value));

        public bool Equals(CubicMetre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(CubicMetre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CubicMetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CubicMetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} m³", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicMetre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} m³";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(CubicMetre self, CubicMetre other) => self.Equals(other);
        public static bool operator !=(CubicMetre self, CubicMetre other) => !self.Equals(other);

        public static bool operator <(CubicMetre self, CubicMetre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicMetre self, CubicMetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicMetre self, CubicMetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicMetre self, CubicMetre other) => self.CompareTo(other) >= 0;

        public static CubicMetre operator +(CubicMetre self, CubicMetre other) => new CubicMetre(self._value + other._value);
        public static CubicMetre operator -(CubicMetre self, CubicMetre other) => new CubicMetre(self._value - other._value);

        public static CubicMetre operator *(CubicMetre self, double other) => new CubicMetre(self._value * other);
        public static CubicMetre operator *(double self, CubicMetre other) => new CubicMetre(self * other._value);

        public static CubicMetre operator /(CubicMetre self, double other) => new CubicMetre(self._value / other);

        public static explicit operator double(CubicMetre self) => self._value;
        public static explicit operator CubicMetre(double self) => new CubicMetre(self);
    }
}