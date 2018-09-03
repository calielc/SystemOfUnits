using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Imperial {
    /// <summary>
    /// Represents a Mile (symbol mi).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} mi")]
    public readonly partial struct Mile : IUnit, IEquatable<Mile>, IComparable<Mile> {
        private readonly double _value;

        public const string Symbol = "mi";

        public Mile(double value) {
            _value = value;
        }

        public double Value => _value;

        public Mile Ceiling() => new Mile(Math.Ceiling(_value));

        public Mile Round() => new Mile(Math.Round(_value));
        public Mile Round(int digits) => new Mile(Math.Round(_value, digits));
        public Mile Round(MidpointRounding mode) => new Mile(Math.Round(_value, mode));

        public Mile Floor() => new Mile(Math.Floor(_value));

        public Mile Truncate() => new Mile(Math.Truncate(_value));

        public Mile Abs() => new Mile(Math.Abs(_value));

        public bool Equals(Mile other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Mile other) => this._value.CompareTo(other._value);

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
            => string.Format(format ?? "{0} mi", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Mile other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} mi";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Mile self, Mile other) => self.Equals(other);
        public static bool operator !=(Mile self, Mile other) => !self.Equals(other);

        public static bool operator <(Mile self, Mile other) => self.CompareTo(other) < 0;
        public static bool operator >(Mile self, Mile other) => self.CompareTo(other) > 0;
        public static bool operator <=(Mile self, Mile other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Mile self, Mile other) => self.CompareTo(other) >= 0;

        public static Mile operator +(Mile self, Mile other) => new Mile(self._value + other._value);
        public static Mile operator -(Mile self, Mile other) => new Mile(self._value - other._value);

        public static Mile operator *(Mile self, double other) => new Mile(self._value * other);
        public static Mile operator *(double self, Mile other) => new Mile(self * other._value);

        public static Mile operator /(Mile self, double other) => new Mile(self._value / other);

        public static explicit operator double(Mile self) => self._value;
        public static explicit operator Mile(double self) => new Mile(self);
    }
}