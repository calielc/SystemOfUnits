using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} fm²")]
    public readonly partial struct SquareFemtometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareFemtometre>,
        IComparable,
        IComparable<SquareFemtometre> {
        public const string Symbol = "fm²";

        public SquareFemtometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareFemtometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareFemtometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareFemtometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareFemtometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} fm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareFemtometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} fm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareFemtometre(Value);

        public static bool operator ==(SquareFemtometre self, SquareFemtometre other) => self.Equals(other);
        public static bool operator !=(SquareFemtometre self, SquareFemtometre other) => !self.Equals(other);

        public static bool operator <(SquareFemtometre self, SquareFemtometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareFemtometre self, SquareFemtometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareFemtometre self, SquareFemtometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareFemtometre self, SquareFemtometre other) => self.CompareTo(other) >= 0;

        public static SquareFemtometre operator +(SquareFemtometre self, SquareFemtometre other) => new SquareFemtometre(self.Value + other.Value);
        public static SquareFemtometre operator -(SquareFemtometre self, SquareFemtometre other) => new SquareFemtometre(self.Value - other.Value);

        public static SquareFemtometre operator *(SquareFemtometre self, double other) => new SquareFemtometre(self.Value * other);
        public static SquareFemtometre operator *(double self, SquareFemtometre other) => new SquareFemtometre(self * other.Value);

        public static SquareFemtometre operator /(SquareFemtometre self, double other) => new SquareFemtometre(self.Value / other);

        public static explicit operator double(SquareFemtometre self) => self.Value;
        public static explicit operator SquareFemtometre(double self) => new SquareFemtometre(self);
    }
}