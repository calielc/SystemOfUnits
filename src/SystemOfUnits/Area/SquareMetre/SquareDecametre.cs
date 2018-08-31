using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dam²")]
    public readonly partial struct SquareDecametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareDecametre>,
        IComparable,
        IComparable<SquareDecametre> {
        public const string Symbol = "dam²";

        public SquareDecametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareDecametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareDecametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareDecametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareDecametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dam²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareDecametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dam²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareDecametre(Value);

        public static bool operator ==(SquareDecametre self, SquareDecametre other) => self.Equals(other);
        public static bool operator !=(SquareDecametre self, SquareDecametre other) => !self.Equals(other);

        public static bool operator <(SquareDecametre self, SquareDecametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareDecametre self, SquareDecametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareDecametre self, SquareDecametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareDecametre self, SquareDecametre other) => self.CompareTo(other) >= 0;

        public static SquareDecametre operator +(SquareDecametre self, SquareDecametre other) => new SquareDecametre(self.Value + other.Value);
        public static SquareDecametre operator -(SquareDecametre self, SquareDecametre other) => new SquareDecametre(self.Value - other.Value);

        public static SquareDecametre operator *(SquareDecametre self, double other) => new SquareDecametre(self.Value * other);
        public static SquareDecametre operator *(double self, SquareDecametre other) => new SquareDecametre(self * other.Value);

        public static SquareDecametre operator /(SquareDecametre self, double other) => new SquareDecametre(self.Value / other);

        public static explicit operator double(SquareDecametre self) => self.Value;
        public static explicit operator SquareDecametre(double self) => new SquareDecametre(self);
    }
}