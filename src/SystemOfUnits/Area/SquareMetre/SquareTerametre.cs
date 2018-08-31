using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Tm²")]
    public readonly partial struct SquareTerametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareTerametre>,
        IComparable,
        IComparable<SquareTerametre> {
        public const string Symbol = "Tm²";

        public SquareTerametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareTerametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareTerametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareTerametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareTerametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Tm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareTerametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Tm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareTerametre(Value);

        public static bool operator ==(SquareTerametre self, SquareTerametre other) => self.Equals(other);
        public static bool operator !=(SquareTerametre self, SquareTerametre other) => !self.Equals(other);

        public static bool operator <(SquareTerametre self, SquareTerametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareTerametre self, SquareTerametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareTerametre self, SquareTerametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareTerametre self, SquareTerametre other) => self.CompareTo(other) >= 0;

        public static SquareTerametre operator +(SquareTerametre self, SquareTerametre other) => new SquareTerametre(self.Value + other.Value);
        public static SquareTerametre operator -(SquareTerametre self, SquareTerametre other) => new SquareTerametre(self.Value - other.Value);

        public static SquareTerametre operator *(SquareTerametre self, double other) => new SquareTerametre(self.Value * other);
        public static SquareTerametre operator *(double self, SquareTerametre other) => new SquareTerametre(self * other.Value);

        public static SquareTerametre operator /(SquareTerametre self, double other) => new SquareTerametre(self.Value / other);

        public static explicit operator double(SquareTerametre self) => self.Value;
        public static explicit operator SquareTerametre(double self) => new SquareTerametre(self);
    }
}