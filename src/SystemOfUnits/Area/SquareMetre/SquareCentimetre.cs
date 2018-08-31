using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} cm²")]
    public readonly partial struct SquareCentimetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareCentimetre>,
        IComparable,
        IComparable<SquareCentimetre> {
        public const string Symbol = "cm²";

        public SquareCentimetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareCentimetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareCentimetre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareCentimetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareCentimetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} cm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareCentimetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} cm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareCentimetre(Value);

        public static bool operator ==(SquareCentimetre self, SquareCentimetre other) => self.Equals(other);
        public static bool operator !=(SquareCentimetre self, SquareCentimetre other) => !self.Equals(other);

        public static bool operator <(SquareCentimetre self, SquareCentimetre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareCentimetre self, SquareCentimetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareCentimetre self, SquareCentimetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareCentimetre self, SquareCentimetre other) => self.CompareTo(other) >= 0;

        public static SquareCentimetre operator +(SquareCentimetre self, SquareCentimetre other) => new SquareCentimetre(self.Value + other.Value);
        public static SquareCentimetre operator -(SquareCentimetre self, SquareCentimetre other) => new SquareCentimetre(self.Value - other.Value);

        public static SquareCentimetre operator *(SquareCentimetre self, double other) => new SquareCentimetre(self.Value * other);
        public static SquareCentimetre operator *(double self, SquareCentimetre other) => new SquareCentimetre(self * other.Value);

        public static SquareCentimetre operator /(SquareCentimetre self, double other) => new SquareCentimetre(self.Value / other);

        public static explicit operator double(SquareCentimetre self) => self.Value;
        public static explicit operator SquareCentimetre(double self) => new SquareCentimetre(self);
    }
}