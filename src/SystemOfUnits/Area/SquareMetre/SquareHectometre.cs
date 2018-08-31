using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} hm²")]
    public readonly partial struct SquareHectometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareHectometre>,
        IComparable,
        IComparable<SquareHectometre> {
        public const string Symbol = "hm²";

        public SquareHectometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareHectometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareHectometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareHectometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareHectometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} hm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareHectometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} hm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareHectometre(Value);

        public static bool operator ==(SquareHectometre self, SquareHectometre other) => self.Equals(other);
        public static bool operator !=(SquareHectometre self, SquareHectometre other) => !self.Equals(other);

        public static bool operator <(SquareHectometre self, SquareHectometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareHectometre self, SquareHectometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareHectometre self, SquareHectometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareHectometre self, SquareHectometre other) => self.CompareTo(other) >= 0;

        public static SquareHectometre operator +(SquareHectometre self, SquareHectometre other) => new SquareHectometre(self.Value + other.Value);
        public static SquareHectometre operator -(SquareHectometre self, SquareHectometre other) => new SquareHectometre(self.Value - other.Value);

        public static SquareHectometre operator *(SquareHectometre self, double other) => new SquareHectometre(self.Value * other);
        public static SquareHectometre operator *(double self, SquareHectometre other) => new SquareHectometre(self * other.Value);

        public static SquareHectometre operator /(SquareHectometre self, double other) => new SquareHectometre(self.Value / other);

        public static explicit operator double(SquareHectometre self) => self.Value;
        public static explicit operator SquareHectometre(double self) => new SquareHectometre(self);
    }
}