using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.CubicMetre {
    /// <summary>
    /// Represents a Cubic Metre (symbol m³).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} m³")]
    public readonly partial struct CubicMetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<CubicMetre>,
        IComparable,
        IComparable<CubicMetre> {
        public const string Symbol = "m³";

        public CubicMetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(CubicMetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(CubicMetre other) => Value.CompareTo(other.Value);

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
            => string.Format(format ?? "{0} m³", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CubicMetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} m³";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new CubicMetre(Value);

        public static bool operator ==(CubicMetre self, CubicMetre other) => self.Equals(other);
        public static bool operator !=(CubicMetre self, CubicMetre other) => !self.Equals(other);

        public static bool operator <(CubicMetre self, CubicMetre other) => self.CompareTo(other) < 0;
        public static bool operator >(CubicMetre self, CubicMetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(CubicMetre self, CubicMetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CubicMetre self, CubicMetre other) => self.CompareTo(other) >= 0;

        public static CubicMetre operator +(CubicMetre self, CubicMetre other) => new CubicMetre(self.Value + other.Value);
        public static CubicMetre operator -(CubicMetre self, CubicMetre other) => new CubicMetre(self.Value - other.Value);

        public static CubicMetre operator *(CubicMetre self, double other) => new CubicMetre(self.Value * other);
        public static CubicMetre operator *(double self, CubicMetre other) => new CubicMetre(self * other.Value);

        public static CubicMetre operator /(CubicMetre self, double other) => new CubicMetre(self.Value / other);

        public static explicit operator double(CubicMetre self) => self.Value;
        public static explicit operator CubicMetre(double self) => new CubicMetre(self);
    }
}