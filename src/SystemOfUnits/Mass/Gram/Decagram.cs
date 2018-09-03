using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Mass.Gram {
    /// <summary>
    /// Represents a Decagram (symbol dag).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dag")]
    public readonly partial struct Decagram : IUnit, IEquatable<Decagram>, IComparable<Decagram> {
        private readonly double _value;

        public const string Symbol = "dag";

        public Decagram(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decagram Ceiling() => new Decagram(Math.Ceiling(_value));

        public Decagram Round() => new Decagram(Math.Round(_value));
        public Decagram Round(int digits) => new Decagram(Math.Round(_value, digits));
        public Decagram Round(MidpointRounding mode) => new Decagram(Math.Round(_value, mode));

        public Decagram Floor() => new Decagram(Math.Floor(_value));

        public Decagram Truncate() => new Decagram(Math.Truncate(_value));

        public Decagram Abs() => new Decagram(Math.Abs(_value));

        public bool Equals(Decagram other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decagram other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decagram other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decagram)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dag", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decagram other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dag";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decagram self, Decagram other) => self.Equals(other);
        public static bool operator !=(Decagram self, Decagram other) => !self.Equals(other);

        public static bool operator <(Decagram self, Decagram other) => self.CompareTo(other) < 0;
        public static bool operator >(Decagram self, Decagram other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decagram self, Decagram other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decagram self, Decagram other) => self.CompareTo(other) >= 0;

        public static Decagram operator +(Decagram self, Decagram other) => new Decagram(self._value + other._value);
        public static Decagram operator -(Decagram self, Decagram other) => new Decagram(self._value - other._value);

        public static Decagram operator *(Decagram self, double other) => new Decagram(self._value * other);
        public static Decagram operator *(double self, Decagram other) => new Decagram(self * other._value);

        public static Decagram operator /(Decagram self, double other) => new Decagram(self._value / other);

        public static explicit operator double(Decagram self) => self._value;
        public static explicit operator Decagram(double self) => new Decagram(self);
    }
}