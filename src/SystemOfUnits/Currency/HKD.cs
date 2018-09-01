using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Currency {
    /// <summary>
    /// Represents a Hong Kong dollar (code: HKD and symbol HK$)
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(CurrencyJsonConverter ))]
    [DebuggerDisplay("HK$ {Value}")]
    public readonly partial struct HKD : ICurrency, 
        IFormattable,
        ICloneable,
        IEquatable<HKD>,
        IComparable,
        IComparable<HKD> {
        public const string Symbol = "HK$";

        public HKD(decimal value) {
            Value = value;
        }

        public decimal Value { get; }

        public bool Equals(HKD other) => Value == other.Value;

        public int CompareTo(HKD other) => Value.CompareTo(other.Value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case HKD other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(HKD)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "HK$ {0}", Value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is HKD other && Equals(other);
        }

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => $"HK$ {Value:0.00}";

        string ICurrency.Symbol => Symbol;

        object ICloneable.Clone() => new HKD(Value);

        public static bool operator ==(HKD self, HKD other) => self.Equals(other);
        public static bool operator !=(HKD self, HKD other) => !self.Equals(other);

        public static bool operator <(HKD self, HKD other) => self.CompareTo(other) < 0;
        public static bool operator >(HKD self, HKD other) => self.CompareTo(other) > 0;
        public static bool operator <=(HKD self, HKD other) => self.CompareTo(other) <= 0;
        public static bool operator >=(HKD self, HKD other) => self.CompareTo(other) >= 0;

        public static HKD operator +(HKD self, HKD other) => new HKD(self.Value + other.Value);
        public static HKD operator -(HKD self, HKD other) => new HKD(self.Value - other.Value);

        public static HKD operator *(HKD self, decimal other) => new HKD(self.Value * other);
        public static HKD operator *(decimal self, HKD other) => new HKD(self * other.Value);

        public static HKD operator /(HKD self, decimal other) => new HKD(self.Value / other);

        public static explicit operator decimal(HKD self) => self.Value;
        public static explicit operator HKD(decimal self) => new HKD(self);
    }
}