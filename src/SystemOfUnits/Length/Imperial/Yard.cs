using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Imperial {
    /// <summary>
    /// Represents a Yard (symbol yd).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} yd")]
    public readonly partial struct Yard : IUnit, IEquatable<Yard>, IComparable<Yard> {
        private readonly double _value;

        public const string Symbol = "yd";

        public Yard(double value) {
            _value = value;
        }

        public double Value => _value;

        public Yard Ceiling() => new Yard(Math.Ceiling(_value));

        public Yard Round() => new Yard(Math.Round(_value));
        public Yard Round(int digits) => new Yard(Math.Round(_value, digits));
        public Yard Round(MidpointRounding mode) => new Yard(Math.Round(_value, mode));

        public Yard Floor() => new Yard(Math.Floor(_value));

        public Yard Truncate() => new Yard(Math.Truncate(_value));

        public Yard Abs() => new Yard(Math.Abs(_value));

        public bool Equals(Yard other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Yard other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Yard other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Yard)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} yd", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Yard other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} yd";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Yard self, Yard other) => self.Equals(other);
        public static bool operator !=(Yard self, Yard other) => !self.Equals(other);

        public static bool operator <(Yard self, Yard other) => self.CompareTo(other) < 0;
        public static bool operator >(Yard self, Yard other) => self.CompareTo(other) > 0;
        public static bool operator <=(Yard self, Yard other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Yard self, Yard other) => self.CompareTo(other) >= 0;

        public static Yard operator +(Yard self, Yard other) => new Yard(self._value + other._value);
        public static Yard operator -(Yard self, Yard other) => new Yard(self._value - other._value);

        public static Yard operator *(Yard self, double other) => new Yard(self._value * other);
        public static Yard operator *(double self, Yard other) => new Yard(self * other._value);

        public static Yard operator /(Yard self, double other) => new Yard(self._value / other);

        public static explicit operator double(Yard self) => self._value;
        public static explicit operator Yard(double self) => new Yard(self);
    }
}