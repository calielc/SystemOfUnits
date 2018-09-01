using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Canadian dollar (code: CAD and symbol C$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("C$ {Value}")]
    public readonly partial struct CAD : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<CAD>,
        IComparable,
        IComparable<CAD> {
        public const string Symbol = "C$";

        public CAD(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(CAD other) => Value == other.Value;

        public int CompareTo(CAD other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case CAD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(CAD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "C$ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is CAD other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"C$ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new CAD(Value);

        public static bool operator ==(CAD self, CAD other) => self.Equals(other);
        public static bool operator !=(CAD self, CAD other) => !self.Equals(other);

        public static bool operator <(CAD self, CAD other) => self.CompareTo(other) < 0;
        public static bool operator >(CAD self, CAD other) => self.CompareTo(other) > 0;
        public static bool operator <=(CAD self, CAD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(CAD self, CAD other) => self.CompareTo(other) >= 0;

        public static CAD operator +(CAD self, CAD other) => new CAD(self.Value + other.Value);
        public static CAD operator -(CAD self, CAD other) => new CAD(self.Value - other.Value);

        public static CAD operator *(CAD self, decimal other) => new CAD(self.Value * other);
        public static CAD operator *(decimal self, CAD other) => new CAD(self * other.Value);

        public static CAD operator /(CAD self, decimal other) => new CAD(self.Value / other);

        public static explicit operator decimal(CAD self) => self.Value;
        public static explicit operator CAD(decimal self) => new CAD(self);
    }
}