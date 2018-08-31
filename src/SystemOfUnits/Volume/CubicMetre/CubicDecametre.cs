using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic Decametre (symbol dam³).
    /// It is a multiple of the unit <c>Cubic Metre</c>, where:
    /// - 1 Cubic Decametre = 1,000 Cubic Metre
    /// - 1 Cubic Decametre = 10^3 Cubic Metre
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dam³")]
    public readonly partial struct CubicDecametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<CubicDecametre>,
        IComparable,
        IComparable<CubicDecametre> {
        public const string Symbol = "dam³";

        public CubicDecametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(CubicDecametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(CubicDecametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CubicDecametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CubicDecametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dam³", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicDecametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dam³";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new CubicDecametre(Value);

        public static bool operator ==(CubicDecametre self, CubicDecametre other) => self.Equals(other);
        public static bool operator !=(CubicDecametre self, CubicDecametre other) => !self.Equals(other);

        public static bool operator <(CubicDecametre self, CubicDecametre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicDecametre self, CubicDecametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicDecametre self, CubicDecametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicDecametre self, CubicDecametre other) => self.CompareTo(other) >= 0;

        public static CubicDecametre operator +(CubicDecametre self, CubicDecametre other) => new CubicDecametre(self.Value + other.Value);
        public static CubicDecametre operator -(CubicDecametre self, CubicDecametre other) => new CubicDecametre(self.Value - other.Value);

        public static CubicDecametre operator *(CubicDecametre self, double other) => new CubicDecametre(self.Value * other);
        public static CubicDecametre operator *(double self, CubicDecametre other) => new CubicDecametre(self * other.Value);

        public static CubicDecametre operator /(CubicDecametre self, double other) => new CubicDecametre(self.Value / other);

        public static explicit operator double(CubicDecametre self) => self.Value;
        public static explicit operator CubicDecametre(double self) => new CubicDecametre(self);
    }
}