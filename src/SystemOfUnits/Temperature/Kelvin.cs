using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Temperature {
    /// <summary>
    /// Represents a Kelvin (symbol K).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} K")]
    public readonly partial struct Kelvin : IUnit, IEquatable<Kelvin>, IComparable<Kelvin> {
        private readonly double _value;

        public const string Symbol = "K";

        public Kelvin(double value) {
            _value = value;
        }

        public double Value => _value;

        public Kelvin Ceiling() => new Kelvin(Math.Ceiling(_value));

        public Kelvin Round() => new Kelvin(Math.Round(_value));
        public Kelvin Round(int digits) => new Kelvin(Math.Round(_value, digits));
        public Kelvin Round(MidpointRounding mode) => new Kelvin(Math.Round(_value, mode));

        public Kelvin Floor() => new Kelvin(Math.Floor(_value));

        public Kelvin Truncate() => new Kelvin(Math.Truncate(_value));

        public Kelvin Abs() => new Kelvin(Math.Abs(_value));

        public bool Equals(Kelvin other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Kelvin other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Kelvin other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Kelvin)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} K", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Kelvin other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} K";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Kelvin self, Kelvin other) => self.Equals(other);
        public static bool operator !=(Kelvin self, Kelvin other) => !self.Equals(other);

        public static bool operator <(Kelvin self, Kelvin other) => self.CompareTo(other) < 0;
        public static bool operator >(Kelvin self, Kelvin other) => self.CompareTo(other) > 0;
        public static bool operator <=(Kelvin self, Kelvin other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Kelvin self, Kelvin other) => self.CompareTo(other) >= 0;

        public static Kelvin operator +(Kelvin self, Kelvin other) => new Kelvin(self._value + other._value);
        public static Kelvin operator -(Kelvin self, Kelvin other) => new Kelvin(self._value - other._value);

        public static Kelvin operator *(Kelvin self, double other) => new Kelvin(self._value * other);
        public static Kelvin operator *(double self, Kelvin other) => new Kelvin(self * other._value);

        public static Kelvin operator /(Kelvin self, double other) => new Kelvin(self._value / other);

        public static explicit operator double(Kelvin self) => self._value;
        public static explicit operator Kelvin(double self) => new Kelvin(self);
    }
}