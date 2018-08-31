using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} pm²")]
    public readonly partial struct SquarePicometre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquarePicometre>,
        IComparable,
        IComparable<SquarePicometre> {
        public const string Symbol = "pm²";

        public SquarePicometre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquarePicometre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquarePicometre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquarePicometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquarePicometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} pm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquarePicometre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} pm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquarePicometre(Value);

        public static bool operator ==(SquarePicometre self, SquarePicometre other) => self.Equals(other);
        public static bool operator !=(SquarePicometre self, SquarePicometre other) => !self.Equals(other);

        public static bool operator <(SquarePicometre self, SquarePicometre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquarePicometre self, SquarePicometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquarePicometre self, SquarePicometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquarePicometre self, SquarePicometre other) => self.CompareTo(other) >= 0;

        public static SquarePicometre operator +(SquarePicometre self, SquarePicometre other) => new SquarePicometre(self.Value + other.Value);
        public static SquarePicometre operator -(SquarePicometre self, SquarePicometre other) => new SquarePicometre(self.Value - other.Value);

        public static SquarePicometre operator *(SquarePicometre self, double other) => new SquarePicometre(self.Value * other);
        public static SquarePicometre operator *(double self, SquarePicometre other) => new SquarePicometre(self * other.Value);

        public static SquarePicometre operator /(SquarePicometre self, double other) => new SquarePicometre(self.Value / other);

        public static explicit operator double(SquarePicometre self) => self.Value;
        public static explicit operator SquarePicometre(double self) => new SquarePicometre(self);
    }
}