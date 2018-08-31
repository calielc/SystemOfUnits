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
    public readonly partial struct CubicDecimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<CubicDecimetre>,
        IComparable,
        IComparable<CubicDecimetre> {
        public const string Symbol = "dm³";

        public CubicDecimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(CubicDecimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(CubicDecimetre other) => Value.CompareTo(other.Value);

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
            => string.Format(format ?? "{0} dm³", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicDecimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dm³";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new CubicDecimetre(Value);

        public static bool operator ==(CubicDecimetre self, CubicDecimetre other) => self.Equals(other);
        public static bool operator !=(CubicDecimetre self, CubicDecimetre other) => !self.Equals(other);

        public static bool operator <(CubicDecimetre self, CubicDecimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicDecimetre self, CubicDecimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicDecimetre self, CubicDecimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicDecimetre self, CubicDecimetre other) => self.CompareTo(other) >= 0;

        public static CubicDecimetre operator +(CubicDecimetre self, CubicDecimetre other) => new CubicDecimetre(self.Value + other.Value);
        public static CubicDecimetre operator -(CubicDecimetre self, CubicDecimetre other) => new CubicDecimetre(self.Value - other.Value);

        public static CubicDecimetre operator *(CubicDecimetre self, double other) => new CubicDecimetre(self.Value * other);
        public static CubicDecimetre operator *(double self, CubicDecimetre other) => new CubicDecimetre(self * other.Value);

        public static CubicDecimetre operator /(CubicDecimetre self, double other) => new CubicDecimetre(self.Value / other);

        public static explicit operator double(CubicDecimetre self) => self.Value;
        public static explicit operator CubicDecimetre(double self) => new CubicDecimetre(self);
    }
}