using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Metre {
    /// <summary>
    /// Represents a Petametre (symbol Pm).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} Pm")]
    public readonly partial struct Petametre : IUnit, IEquatable<Petametre>, IComparable<Petametre> {
        private readonly double _value;

        public const string Symbol = "Pm";

        public Petametre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Petametre Ceiling() => new Petametre(Math.Ceiling(_value));

        public Petametre Round() => new Petametre(Math.Round(_value));
        public Petametre Round(int digits) => new Petametre(Math.Round(_value, digits));
        public Petametre Round(MidpointRounding mode) => new Petametre(Math.Round(_value, mode));

        public Petametre Floor() => new Petametre(Math.Floor(_value));

        public Petametre Truncate() => new Petametre(Math.Truncate(_value));

        public Petametre Abs() => new Petametre(Math.Abs(_value));

        public bool Equals(Petametre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Petametre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Petametre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Petametre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} Pm", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Petametre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} Pm";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Petametre self, Petametre other) => self.Equals(other);
        public static bool operator !=(Petametre self, Petametre other) => !self.Equals(other);

        public static bool operator <(Petametre self, Petametre other) => self.CompareTo(other) < 0;
        public static bool operator >(Petametre self, Petametre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Petametre self, Petametre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Petametre self, Petametre other) => self.CompareTo(other) >= 0;

        public static Petametre operator +(Petametre self, Petametre other) => new Petametre(self._value + other._value);
        public static Petametre operator -(Petametre self, Petametre other) => new Petametre(self._value - other._value);

        public static Petametre operator *(Petametre self, double other) => new Petametre(self._value * other);
        public static Petametre operator *(double self, Petametre other) => new Petametre(self * other._value);

        public static Petametre operator /(Petametre self, double other) => new Petametre(self._value / other);

        public static explicit operator double(Petametre self) => self._value;
        public static explicit operator Petametre(double self) => new Petametre(self);
    }
}