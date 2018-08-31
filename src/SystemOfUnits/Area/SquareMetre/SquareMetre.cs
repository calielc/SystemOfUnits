using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} m²")]
    public readonly partial struct SquareMetre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareMetre>,
        IComparable,
        IComparable<SquareMetre> {
        public const string Symbol = "m²";

        public SquareMetre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareMetre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareMetre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareMetre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareMetre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} m²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareMetre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} m²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareMetre(Value);

        public static bool operator ==(SquareMetre self, SquareMetre other) => self.Equals(other);
        public static bool operator !=(SquareMetre self, SquareMetre other) => !self.Equals(other);

        public static bool operator <(SquareMetre self, SquareMetre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareMetre self, SquareMetre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareMetre self, SquareMetre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareMetre self, SquareMetre other) => self.CompareTo(other) >= 0;

        public static SquareMetre operator +(SquareMetre self, SquareMetre other) => new SquareMetre(self.Value + other.Value);
        public static SquareMetre operator -(SquareMetre self, SquareMetre other) => new SquareMetre(self.Value - other.Value);

        public static SquareMetre operator *(SquareMetre self, double other) => new SquareMetre(self.Value * other);
        public static SquareMetre operator *(double self, SquareMetre other) => new SquareMetre(self * other.Value);

        public static SquareMetre operator /(SquareMetre self, double other) => new SquareMetre(self.Value / other);

        public static explicit operator double(SquareMetre self) => self.Value;
        public static explicit operator SquareMetre(double self) => new SquareMetre(self);
    }
}