using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} μm²")]
    public readonly partial struct SquareMicrometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareMicrometre>,
        IComparable,
        IComparable<SquareMicrometre> {
        public const string Symbol = "μm²";

        public SquareMicrometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareMicrometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareMicrometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareMicrometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareMicrometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} μm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareMicrometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} μm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareMicrometre(Value);

        public static bool operator ==(SquareMicrometre self, SquareMicrometre other) => self.Equals(other);
        public static bool operator !=(SquareMicrometre self, SquareMicrometre other) => !self.Equals(other);

        public static bool operator <(SquareMicrometre self, SquareMicrometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareMicrometre self, SquareMicrometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareMicrometre self, SquareMicrometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareMicrometre self, SquareMicrometre other) => self.CompareTo(other) >= 0;

        public static SquareMicrometre operator +(SquareMicrometre self, SquareMicrometre other) => new SquareMicrometre(self.Value + other.Value);
        public static SquareMicrometre operator -(SquareMicrometre self, SquareMicrometre other) => new SquareMicrometre(self.Value - other.Value);

        public static SquareMicrometre operator *(SquareMicrometre self, double other) => new SquareMicrometre(self.Value * other);
        public static SquareMicrometre operator *(double self, SquareMicrometre other) => new SquareMicrometre(self * other.Value);

        public static SquareMicrometre operator /(SquareMicrometre self, double other) => new SquareMicrometre(self.Value / other);

        public static explicit operator double(SquareMicrometre self) => self.Value;
        public static explicit operator SquareMicrometre(double self) => new SquareMicrometre(self);
    }
}