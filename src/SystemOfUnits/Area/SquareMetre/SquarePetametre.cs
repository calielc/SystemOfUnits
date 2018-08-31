using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Area.SquareMetre {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Pm²")]
    public readonly partial struct SquarePetametre : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<SquarePetametre>,
        IComparable,
        IComparable<SquarePetametre> {
        public const string Symbol = "Pm²";

        public SquarePetametre(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(SquarePetametre other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(SquarePetametre other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case SquarePetametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(SquarePetametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Pm²", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is SquarePetametre other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} Pm²";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new SquarePetametre(Value);

        public static bool operator ==(SquarePetametre self, SquarePetametre other) => self.Equals(other);
        public static bool operator !=(SquarePetametre self, SquarePetametre other) => !self.Equals(other);

        public static bool operator <(SquarePetametre self, SquarePetametre other) => self.CompareTo(other) < 0;
        public static bool operator >(SquarePetametre self, SquarePetametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(SquarePetametre self, SquarePetametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(SquarePetametre self, SquarePetametre other) => self.CompareTo(other) >= 0;

        public static SquarePetametre operator +(SquarePetametre self, SquarePetametre other) => new SquarePetametre(self.Value + other.Value);
        public static SquarePetametre operator -(SquarePetametre self, SquarePetametre other) => new SquarePetametre(self.Value - other.Value);

        public static SquarePetametre operator *(SquarePetametre self, double other) => new SquarePetametre(self.Value * other);
        public static SquarePetametre operator *(double self, SquarePetametre other) => new SquarePetametre(self * other.Value);

        public static SquarePetametre operator /(SquarePetametre self, double other) => new SquarePetametre(self.Value / other);

        public static explicit operator double(SquarePetametre self) => self.Value;
        public static explicit operator SquarePetametre(double self) => new SquarePetametre(self);
    }
}