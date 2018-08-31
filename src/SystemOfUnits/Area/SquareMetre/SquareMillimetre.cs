using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mm²")]
    public readonly partial struct SquareMillimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareMillimetre>,
        IComparable,
        IComparable<SquareMillimetre> {
        public const string Symbol = "mm²";

        public SquareMillimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareMillimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareMillimetre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareMillimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareMillimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareMillimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareMillimetre(Value);

        public static bool operator ==(SquareMillimetre self, SquareMillimetre other) => self.Equals(other);
        public static bool operator !=(SquareMillimetre self, SquareMillimetre other) => !self.Equals(other);

        public static bool operator <(SquareMillimetre self, SquareMillimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareMillimetre self, SquareMillimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareMillimetre self, SquareMillimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareMillimetre self, SquareMillimetre other) => self.CompareTo(other) >= 0;

        public static SquareMillimetre operator +(SquareMillimetre self, SquareMillimetre other) => new SquareMillimetre(self.Value + other.Value);
        public static SquareMillimetre operator -(SquareMillimetre self, SquareMillimetre other) => new SquareMillimetre(self.Value - other.Value);

        public static SquareMillimetre operator *(SquareMillimetre self, double other) => new SquareMillimetre(self.Value * other);
        public static SquareMillimetre operator *(double self, SquareMillimetre other) => new SquareMillimetre(self * other.Value);

        public static SquareMillimetre operator /(SquareMillimetre self, double other) => new SquareMillimetre(self.Value / other);

        public static explicit operator double(SquareMillimetre self) => self.Value;
        public static explicit operator SquareMillimetre(double self) => new SquareMillimetre(self);
    }
}