using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} km²")]
    public readonly partial struct SquareKilometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareKilometre>,
        IComparable,
        IComparable<SquareKilometre> {
        public const string Symbol = "km²";

        public SquareKilometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareKilometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareKilometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareKilometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareKilometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} km²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareKilometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} km²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareKilometre(Value);

        public static bool operator ==(SquareKilometre self, SquareKilometre other) => self.Equals(other);
        public static bool operator !=(SquareKilometre self, SquareKilometre other) => !self.Equals(other);

        public static bool operator <(SquareKilometre self, SquareKilometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareKilometre self, SquareKilometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareKilometre self, SquareKilometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareKilometre self, SquareKilometre other) => self.CompareTo(other) >= 0;

        public static SquareKilometre operator +(SquareKilometre self, SquareKilometre other) => new SquareKilometre(self.Value + other.Value);
        public static SquareKilometre operator -(SquareKilometre self, SquareKilometre other) => new SquareKilometre(self.Value - other.Value);

        public static SquareKilometre operator *(SquareKilometre self, double other) => new SquareKilometre(self.Value * other);
        public static SquareKilometre operator *(double self, SquareKilometre other) => new SquareKilometre(self * other.Value);

        public static SquareKilometre operator /(SquareKilometre self, double other) => new SquareKilometre(self.Value / other);

        public static explicit operator double(SquareKilometre self) => self.Value;
        public static explicit operator SquareKilometre(double self) => new SquareKilometre(self);
    }
}