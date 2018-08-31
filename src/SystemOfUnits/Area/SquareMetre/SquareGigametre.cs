using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Gm²")]
    public readonly partial struct SquareGigametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquareGigametre>,
        IComparable,
        IComparable<SquareGigametre> {
        public const string Symbol = "Gm²";

        public SquareGigametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquareGigametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquareGigametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquareGigametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquareGigametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Gm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquareGigametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Gm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquareGigametre(Value);

        public static bool operator ==(SquareGigametre self, SquareGigametre other) => self.Equals(other);
        public static bool operator !=(SquareGigametre self, SquareGigametre other) => !self.Equals(other);

        public static bool operator <(SquareGigametre self, SquareGigametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquareGigametre self, SquareGigametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquareGigametre self, SquareGigametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquareGigametre self, SquareGigametre other) => self.CompareTo(other) >= 0;

        public static SquareGigametre operator +(SquareGigametre self, SquareGigametre other) => new SquareGigametre(self.Value + other.Value);
        public static SquareGigametre operator -(SquareGigametre self, SquareGigametre other) => new SquareGigametre(self.Value - other.Value);

        public static SquareGigametre operator *(SquareGigametre self, double other) => new SquareGigametre(self.Value * other);
        public static SquareGigametre operator *(double self, SquareGigametre other) => new SquareGigametre(self * other.Value);

        public static SquareGigametre operator /(SquareGigametre self, double other) => new SquareGigametre(self.Value / other);

        public static explicit operator double(SquareGigametre self) => self.Value;
        public static explicit operator SquareGigametre(double self) => new SquareGigametre(self);
    }
}