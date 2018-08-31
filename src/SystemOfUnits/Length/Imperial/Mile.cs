using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Imperial {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mi")]
    public readonly partial struct Mile : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Mile>,
        IComparable,
        IComparable<Mile> {
        public const string Symbol = "mi";

        public Mile(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Mile other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Mile other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Mile other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Mile)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} mi", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Mile other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} mi";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Mile(Value);

        public static bool operator ==(Mile self, Mile other) => self.Equals(other);
        public static bool operator !=(Mile self, Mile other) => !self.Equals(other);

        public static bool operator <(Mile self, Mile other) => self.CompareTo(other) < 0;
        public static bool operator >(Mile self, Mile other) => self.CompareTo(other) > 0;
        public static bool operator <=(Mile self, Mile other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Mile self, Mile other) => self.CompareTo(other) >= 0;

        public static Mile operator +(Mile self, Mile other) => new Mile(self.Value + other.Value);
        public static Mile operator -(Mile self, Mile other) => new Mile(self.Value - other.Value);

        public static Mile operator *(Mile self, double other) => new Mile(self.Value * other);
        public static Mile operator *(double self, Mile other) => new Mile(self * other.Value);

        public static Mile operator /(Mile self, double other) => new Mile(self.Value / other);

        public static explicit operator double(Mile self) => self.Value;
        public static explicit operator Mile(double self) => new Mile(self);
    }
}