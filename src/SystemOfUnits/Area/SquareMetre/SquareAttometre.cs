using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} am²")]
    public readonly partial struct SquareAttometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareAttometre>,
        IComparable,
        IComparable<SquareAttometre> {
        public const string Symbol = "am²";

        public SquareAttometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareAttometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareAttometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareAttometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareAttometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} am²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareAttometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} am²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareAttometre(Value);

        public static bool operator ==(SquareAttometre self, SquareAttometre other) => self.Equals(other);
        public static bool operator !=(SquareAttometre self, SquareAttometre other) => !self.Equals(other);

        public static bool operator <(SquareAttometre self, SquareAttometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareAttometre self, SquareAttometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareAttometre self, SquareAttometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareAttometre self, SquareAttometre other) => self.CompareTo(other) >= 0;

        public static SquareAttometre operator +(SquareAttometre self, SquareAttometre other) => new SquareAttometre(self.Value + other.Value);
        public static SquareAttometre operator -(SquareAttometre self, SquareAttometre other) => new SquareAttometre(self.Value - other.Value);

        public static SquareAttometre operator *(SquareAttometre self, double other) => new SquareAttometre(self.Value * other);
        public static SquareAttometre operator *(double self, SquareAttometre other) => new SquareAttometre(self * other.Value);

        public static SquareAttometre operator /(SquareAttometre self, double other) => new SquareAttometre(self.Value / other);

        public static explicit operator double(SquareAttometre self) => self.Value;
        public static explicit operator SquareAttometre(double self) => new SquareAttometre(self);
    }
}