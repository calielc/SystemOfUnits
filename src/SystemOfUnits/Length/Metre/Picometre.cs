using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Picometre (symbol pm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} pm")]
    public readonly partial struct Picometre : IUnit, IEquatable<Picometre>, IComparable<Picometre> {
        private readonly double _value;

        public const string Symbol = "pm";

        public Picometre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Picometre Ceiling() => new Picometre(Math.Ceiling(_value));

        public Picometre Round() => new Picometre(Math.Round(_value));
        public Picometre Round(int digits) => new Picometre(Math.Round(_value, digits));
        public Picometre Round(MidpointRounding mode) => new Picometre(Math.Round(_value, mode));

        public Picometre Floor() => new Picometre(Math.Floor(_value));

        public Picometre Truncate() => new Picometre(Math.Truncate(_value));

        public Picometre Abs() => new Picometre(Math.Abs(_value));

        public bool Equals(Picometre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Picometre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Picometre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Picometre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} pm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Picometre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} pm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Picometre self, Picometre other) => self.Equals(other);
        public static bool operator !=(Picometre self, Picometre other) => !self.Equals(other);

        public static bool operator <(Picometre self, Picometre other) => self.CompareTo(other) < 0;
        public static bool operator >(Picometre self, Picometre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Picometre self, Picometre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Picometre self, Picometre other) => self.CompareTo(other) >= 0;

        public static Picometre operator +(Picometre self, Picometre other) => new Picometre(self._value + other._value);
        public static Picometre operator -(Picometre self, Picometre other) => new Picometre(self._value - other._value);

        public static Picometre operator *(Picometre self, double other) => new Picometre(self._value * other);
        public static Picometre operator *(double self, Picometre other) => new Picometre(self * other._value);

        public static Picometre operator /(Picometre self, double other) => new Picometre(self._value / other);

        public static explicit operator double(Picometre self) => self._value;
        public static explicit operator Picometre(double self) => new Picometre(self);
    }
}