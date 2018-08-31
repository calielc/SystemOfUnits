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
    public readonly partial struct CubicMillimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<CubicMillimetre>,
        IComparable,
        IComparable<CubicMillimetre> {
        public const string Symbol = "mm³";

        public CubicMillimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(CubicMillimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(CubicMillimetre other) => Value.CompareTo(other.Value);

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
            => string.Format(format ?? "{0} mm³", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicMillimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mm³";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new CubicMillimetre(Value);

        public static bool operator ==(CubicMillimetre self, CubicMillimetre other) => self.Equals(other);
        public static bool operator !=(CubicMillimetre self, CubicMillimetre other) => !self.Equals(other);

        public static bool operator <(CubicMillimetre self, CubicMillimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicMillimetre self, CubicMillimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicMillimetre self, CubicMillimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicMillimetre self, CubicMillimetre other) => self.CompareTo(other) >= 0;

        public static CubicMillimetre operator +(CubicMillimetre self, CubicMillimetre other) => new CubicMillimetre(self.Value + other.Value);
        public static CubicMillimetre operator -(CubicMillimetre self, CubicMillimetre other) => new CubicMillimetre(self.Value - other.Value);

        public static CubicMillimetre operator *(CubicMillimetre self, double other) => new CubicMillimetre(self.Value * other);
        public static CubicMillimetre operator *(double self, CubicMillimetre other) => new CubicMillimetre(self * other.Value);

        public static CubicMillimetre operator /(CubicMillimetre self, double other) => new CubicMillimetre(self.Value / other);

        public static explicit operator double(CubicMillimetre self) => self.Value;
        public static explicit operator CubicMillimetre(double self) => new CubicMillimetre(self);
    }
}