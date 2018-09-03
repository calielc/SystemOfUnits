using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Imperial {
    /// <summary>
    /// Represents a Inch (symbol in).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} in")]
    public readonly partial struct Inch : IUnit, IEquatable<Inch>, IComparable<Inch> {
        private readonly double _value;

        public const string Symbol = "in";

        public Inch(double value) {
            _value = value;
        }

        public double Value => _value;

        public Inch Ceiling() => new Inch(Math.Ceiling(_value));

        public Inch Round() => new Inch(Math.Round(_value));
        public Inch Round(int digits) => new Inch(Math.Round(_value, digits));
        public Inch Round(MidpointRounding mode) => new Inch(Math.Round(_value, mode));

        public Inch Floor() => new Inch(Math.Floor(_value));

        public Inch Truncate() => new Inch(Math.Truncate(_value));

        public Inch Abs() => new Inch(Math.Abs(_value));

        public bool Equals(Inch other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Inch other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Inch other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Inch)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} in", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Inch other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} in";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Inch self, Inch other) => self.Equals(other);
        public static bool operator !=(Inch self, Inch other) => !self.Equals(other);

        public static bool operator <(Inch self, Inch other) => self.CompareTo(other) < 0;
        public static bool operator >(Inch self, Inch other) => self.CompareTo(other) > 0;
        public static bool operator <=(Inch self, Inch other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Inch self, Inch other) => self.CompareTo(other) >= 0;

        public static Inch operator +(Inch self, Inch other) => new Inch(self._value + other._value);
        public static Inch operator -(Inch self, Inch other) => new Inch(self._value - other._value);

        public static Inch operator *(Inch self, double other) => new Inch(self._value * other);
        public static Inch operator *(double self, Inch other) => new Inch(self * other._value);

        public static Inch operator /(Inch self, double other) => new Inch(self._value / other);

        public static explicit operator double(Inch self) => self._value;
        public static explicit operator Inch(double self) => new Inch(self);
    }
}