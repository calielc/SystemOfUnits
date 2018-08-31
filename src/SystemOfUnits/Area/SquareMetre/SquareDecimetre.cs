using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dm²")]
    public readonly partial struct SquareDecimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareDecimetre>,
        IComparable,
        IComparable<SquareDecimetre> {
        public const string Symbol = "dm²";

        public SquareDecimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareDecimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareDecimetre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareDecimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareDecimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareDecimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} dm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareDecimetre(Value);

        public static bool operator ==(SquareDecimetre self, SquareDecimetre other) => self.Equals(other);
        public static bool operator !=(SquareDecimetre self, SquareDecimetre other) => !self.Equals(other);

        public static bool operator <(SquareDecimetre self, SquareDecimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareDecimetre self, SquareDecimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareDecimetre self, SquareDecimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareDecimetre self, SquareDecimetre other) => self.CompareTo(other) >= 0;

        public static SquareDecimetre operator +(SquareDecimetre self, SquareDecimetre other) => new SquareDecimetre(self.Value + other.Value);
        public static SquareDecimetre operator -(SquareDecimetre self, SquareDecimetre other) => new SquareDecimetre(self.Value - other.Value);

        public static SquareDecimetre operator *(SquareDecimetre self, double other) => new SquareDecimetre(self.Value * other);
        public static SquareDecimetre operator *(double self, SquareDecimetre other) => new SquareDecimetre(self * other.Value);

        public static SquareDecimetre operator /(SquareDecimetre self, double other) => new SquareDecimetre(self.Value / other);

        public static explicit operator double(SquareDecimetre self) => self.Value;
        public static explicit operator SquareDecimetre(double self) => new SquareDecimetre(self);
    }
}