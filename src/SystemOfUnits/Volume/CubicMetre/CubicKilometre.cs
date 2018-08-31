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
    public readonly partial struct CubicKilometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<CubicKilometre>,
        IComparable,
        IComparable<CubicKilometre> {
        public const string Symbol = "km³";

        public CubicKilometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(CubicKilometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(CubicKilometre other) => Value.CompareTo(other.Value);

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
            => string.Format(format ?? "{0} km³", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicKilometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} km³";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new CubicKilometre(Value);

        public static bool operator ==(CubicKilometre self, CubicKilometre other) => self.Equals(other);
        public static bool operator !=(CubicKilometre self, CubicKilometre other) => !self.Equals(other);

        public static bool operator <(CubicKilometre self, CubicKilometre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicKilometre self, CubicKilometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicKilometre self, CubicKilometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicKilometre self, CubicKilometre other) => self.CompareTo(other) >= 0;

        public static CubicKilometre operator +(CubicKilometre self, CubicKilometre other) => new CubicKilometre(self.Value + other.Value);
        public static CubicKilometre operator -(CubicKilometre self, CubicKilometre other) => new CubicKilometre(self.Value - other.Value);

        public static CubicKilometre operator *(CubicKilometre self, double other) => new CubicKilometre(self.Value * other);
        public static CubicKilometre operator *(double self, CubicKilometre other) => new CubicKilometre(self * other.Value);

        public static CubicKilometre operator /(CubicKilometre self, double other) => new CubicKilometre(self.Value / other);

        public static explicit operator double(CubicKilometre self) => self.Value;
        public static explicit operator CubicKilometre(double self) => new CubicKilometre(self);
    }
}