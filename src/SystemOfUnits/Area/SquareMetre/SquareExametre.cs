using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Em²")]
    public readonly partial struct SquareExametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareExametre>,
        IComparable,
        IComparable<SquareExametre> {
        public const string Symbol = "Em²";

        public SquareExametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareExametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareExametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareExametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareExametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Em²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareExametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Em²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareExametre(Value);

        public static bool operator ==(SquareExametre self, SquareExametre other) => self.Equals(other);
        public static bool operator !=(SquareExametre self, SquareExametre other) => !self.Equals(other);

        public static bool operator <(SquareExametre self, SquareExametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareExametre self, SquareExametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareExametre self, SquareExametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareExametre self, SquareExametre other) => self.CompareTo(other) >= 0;

        public static SquareExametre operator +(SquareExametre self, SquareExametre other) => new SquareExametre(self.Value + other.Value);
        public static SquareExametre operator -(SquareExametre self, SquareExametre other) => new SquareExametre(self.Value - other.Value);

        public static SquareExametre operator *(SquareExametre self, double other) => new SquareExametre(self.Value * other);
        public static SquareExametre operator *(double self, SquareExametre other) => new SquareExametre(self * other.Value);

        public static SquareExametre operator /(SquareExametre self, double other) => new SquareExametre(self.Value / other);

        public static explicit operator double(SquareExametre self) => self.Value;
        public static explicit operator SquareExametre(double self) => new SquareExametre(self);
    }
}