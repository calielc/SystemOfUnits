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
    public readonly partial struct CubicCentimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<CubicCentimetre>,
        IComparable,
        IComparable<CubicCentimetre> {
        public const string Symbol = "cm³";

        public CubicCentimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(CubicCentimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(CubicCentimetre other) => Value.CompareTo(other.Value);

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
            => string.Format(format ?? "{0} cm³", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicCentimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} cm³";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new CubicCentimetre(Value);

        public static bool operator ==(CubicCentimetre self, CubicCentimetre other) => self.Equals(other);
        public static bool operator !=(CubicCentimetre self, CubicCentimetre other) => !self.Equals(other);

        public static bool operator <(CubicCentimetre self, CubicCentimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicCentimetre self, CubicCentimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicCentimetre self, CubicCentimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicCentimetre self, CubicCentimetre other) => self.CompareTo(other) >= 0;

        public static CubicCentimetre operator +(CubicCentimetre self, CubicCentimetre other) => new CubicCentimetre(self.Value + other.Value);
        public static CubicCentimetre operator -(CubicCentimetre self, CubicCentimetre other) => new CubicCentimetre(self.Value - other.Value);

        public static CubicCentimetre operator *(CubicCentimetre self, double other) => new CubicCentimetre(self.Value * other);
        public static CubicCentimetre operator *(double self, CubicCentimetre other) => new CubicCentimetre(self * other.Value);

        public static CubicCentimetre operator /(CubicCentimetre self, double other) => new CubicCentimetre(self.Value / other);

        public static explicit operator double(CubicCentimetre self) => self.Value;
        public static explicit operator CubicCentimetre(double self) => new CubicCentimetre(self);
    }
}