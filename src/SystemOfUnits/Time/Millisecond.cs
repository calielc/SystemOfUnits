using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Time {
    /// <summary>
    /// Represents a Millisecond (symbol milliseconds).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} milliseconds")]
    public readonly partial struct Millisecond : IUnit, IEquatable<Millisecond>, IComparable<Millisecond> {
        private readonly double _value;

        public const string Symbol = "milliseconds";

        public Millisecond(double value) {
            _value = value;
        }

        public double Value => _value;

        public Millisecond Ceiling() => new Millisecond(Math.Ceiling(_value));

        public Millisecond Round() => new Millisecond(Math.Round(_value));
        public Millisecond Round(int digits) => new Millisecond(Math.Round(_value, digits));
        public Millisecond Round(MidpointRounding mode) => new Millisecond(Math.Round(_value, mode));

        public Millisecond Floor() => new Millisecond(Math.Floor(_value));

        public Millisecond Truncate() => new Millisecond(Math.Truncate(_value));

        public Millisecond Abs() => new Millisecond(Math.Abs(_value));

        public bool Equals(Millisecond other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Millisecond other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Millisecond other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Millisecond)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} milliseconds", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Millisecond other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} milliseconds";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Millisecond self, Millisecond other) => self.Equals(other);
        public static bool operator !=(Millisecond self, Millisecond other) => !self.Equals(other);

        public static bool operator <(Millisecond self, Millisecond other) => self.CompareTo(other) < 0;
        public static bool operator >(Millisecond self, Millisecond other) => self.CompareTo(other) > 0;
        public static bool operator <=(Millisecond self, Millisecond other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Millisecond self, Millisecond other) => self.CompareTo(other) >= 0;

        public static Millisecond operator +(Millisecond self, Millisecond other) => new Millisecond(self._value + other._value);
        public static Millisecond operator -(Millisecond self, Millisecond other) => new Millisecond(self._value - other._value);

        public static Millisecond operator *(Millisecond self, double other) => new Millisecond(self._value * other);
        public static Millisecond operator *(double self, Millisecond other) => new Millisecond(self * other._value);

        public static Millisecond operator /(Millisecond self, double other) => new Millisecond(self._value / other);

        public static explicit operator double(Millisecond self) => self._value;
        public static explicit operator Millisecond(double self) => new Millisecond(self);
    }
}