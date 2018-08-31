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
    public readonly partial struct CubicHectometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<CubicHectometre>,
        IComparable,
        IComparable<CubicHectometre> {
        public const string Symbol = "hm³";

        public CubicHectometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(CubicHectometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(CubicHectometre other) => Value.CompareTo(other.Value);

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
            => string.Format(format ?? "{0} hm³", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicHectometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hm³";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new CubicHectometre(Value);

        public static bool operator ==(CubicHectometre self, CubicHectometre other) => self.Equals(other);
        public static bool operator !=(CubicHectometre self, CubicHectometre other) => !self.Equals(other);

        public static bool operator <(CubicHectometre self, CubicHectometre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicHectometre self, CubicHectometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicHectometre self, CubicHectometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicHectometre self, CubicHectometre other) => self.CompareTo(other) >= 0;

        public static CubicHectometre operator +(CubicHectometre self, CubicHectometre other) => new CubicHectometre(self.Value + other.Value);
        public static CubicHectometre operator -(CubicHectometre self, CubicHectometre other) => new CubicHectometre(self.Value - other.Value);

        public static CubicHectometre operator *(CubicHectometre self, double other) => new CubicHectometre(self.Value * other);
        public static CubicHectometre operator *(double self, CubicHectometre other) => new CubicHectometre(self * other.Value);

        public static CubicHectometre operator /(CubicHectometre self, double other) => new CubicHectometre(self.Value / other);

        public static explicit operator double(CubicHectometre self) => self.Value;
        public static explicit operator CubicHectometre(double self) => new CubicHectometre(self);
    }
}