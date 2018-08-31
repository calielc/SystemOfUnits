using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} nm²")]
    public readonly partial struct SquareNanometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareNanometre>,
        IComparable,
        IComparable<SquareNanometre> {
        public const string Symbol = "nm²";

        public SquareNanometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareNanometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareNanometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareNanometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareNanometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} nm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareNanometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} nm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareNanometre(Value);

        public static bool operator ==(SquareNanometre self, SquareNanometre other) => self.Equals(other);
        public static bool operator !=(SquareNanometre self, SquareNanometre other) => !self.Equals(other);

        public static bool operator <(SquareNanometre self, SquareNanometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareNanometre self, SquareNanometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareNanometre self, SquareNanometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareNanometre self, SquareNanometre other) => self.CompareTo(other) >= 0;

        public static SquareNanometre operator +(SquareNanometre self, SquareNanometre other) => new SquareNanometre(self.Value + other.Value);
        public static SquareNanometre operator -(SquareNanometre self, SquareNanometre other) => new SquareNanometre(self.Value - other.Value);

        public static SquareNanometre operator *(SquareNanometre self, double other) => new SquareNanometre(self.Value * other);
        public static SquareNanometre operator *(double self, SquareNanometre other) => new SquareNanometre(self * other.Value);

        public static SquareNanometre operator /(SquareNanometre self, double other) => new SquareNanometre(self.Value / other);

        public static explicit operator double(SquareNanometre self) => self.Value;
        public static explicit operator SquareNanometre(double self) => new SquareNanometre(self);
    }
}