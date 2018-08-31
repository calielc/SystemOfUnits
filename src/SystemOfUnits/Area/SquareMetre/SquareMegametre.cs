using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Mm²")]
    public readonly partial struct SquareMegametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareMegametre>,
        IComparable,
        IComparable<SquareMegametre> {
        public const string Symbol = "Mm²";

        public SquareMegametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareMegametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareMegametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareMegametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareMegametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Mm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareMegametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Mm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareMegametre(Value);

        public static bool operator ==(SquareMegametre self, SquareMegametre other) => self.Equals(other);
        public static bool operator !=(SquareMegametre self, SquareMegametre other) => !self.Equals(other);

        public static bool operator <(SquareMegametre self, SquareMegametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareMegametre self, SquareMegametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareMegametre self, SquareMegametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareMegametre self, SquareMegametre other) => self.CompareTo(other) >= 0;

        public static SquareMegametre operator +(SquareMegametre self, SquareMegametre other) => new SquareMegametre(self.Value + other.Value);
        public static SquareMegametre operator -(SquareMegametre self, SquareMegametre other) => new SquareMegametre(self.Value - other.Value);

        public static SquareMegametre operator *(SquareMegametre self, double other) => new SquareMegametre(self.Value * other);
        public static SquareMegametre operator *(double self, SquareMegametre other) => new SquareMegametre(self * other.Value);

        public static SquareMegametre operator /(SquareMegametre self, double other) => new SquareMegametre(self.Value / other);

        public static explicit operator double(SquareMegametre self) => self.Value;
        public static explicit operator SquareMegametre(double self) => new SquareMegametre(self);
    }
}