using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} weeks")]
    public readonly partial struct Week : IUnit, 
        IFormattable,
        ICloneable,
        IEquatable<Week>,
        IComparable,
        IComparable<Week> {
        public const string Symbol = "weeks";

        public Week(double value) {
            Value = value;
        }

        public double Value { get; }

        public bool Equals(Week other) => Math.Abs(Value - other.Value) < 1e-6;

        public int CompareTo(Week other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Week other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Week)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} weeks", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Week other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"{Value:e} weeks";

        string IUnit.Symbol => Symbol;

        object ICloneable.Clone() => new Week(Value);

        public static bool operator ==(Week self, Week other) => self.Equals(other);
        public static bool operator !=(Week self, Week other) => !self.Equals(other);

        public static bool operator <(Week self, Week other) => self.CompareTo(other) < 0;
        public static bool operator >(Week self, Week other) => self.CompareTo(other) > 0;
        public static bool operator <=(Week self, Week other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Week self, Week other) => self.CompareTo(other) >= 0;

        public static Week operator +(Week self, Week other) => new Week(self.Value + other.Value);
        public static Week operator -(Week self, Week other) => new Week(self.Value - other.Value);

        public static Week operator *(Week self, double other) => new Week(self.Value * other);
        public static Week operator *(double self, Week other) => new Week(self * other.Value);

        public static Week operator /(Week self, double other) => new Week(self.Value / other);

        public static explicit operator double(Week self) => self.Value;
        public static explicit operator Week(double self) => new Week(self);
    }
}