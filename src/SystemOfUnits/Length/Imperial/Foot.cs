using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Length.Imperial {
    /// <summary>
    /// Represents a Foot (symbol ft).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} ft")]
    public readonly partial struct Foot : IUnit, IEquatable<Foot>, IComparable<Foot> {
        private readonly double _value;

        public const string Symbol = "ft";

        public Foot(double value) {
            _value = value;
        }

        public double Value => _value;

        public Foot Ceiling() => new Foot(Math.Ceiling(_value));

        public Foot Round() => new Foot(Math.Round(_value));
        public Foot Round(int digits) => new Foot(Math.Round(_value, digits));
        public Foot Round(MidpointRounding mode) => new Foot(Math.Round(_value, mode));

        public Foot Floor() => new Foot(Math.Floor(_value));

        public Foot Truncate() => new Foot(Math.Truncate(_value));

        public Foot Abs() => new Foot(Math.Abs(_value));

        public bool Equals(Foot other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Foot other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Foot other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Foot)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} ft", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Foot other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} ft";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Foot self, Foot other) => self.Equals(other);
        public static bool operator !=(Foot self, Foot other) => !self.Equals(other);

        public static bool operator <(Foot self, Foot other) => self.CompareTo(other) < 0;
        public static bool operator >(Foot self, Foot other) => self.CompareTo(other) > 0;
        public static bool operator <=(Foot self, Foot other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Foot self, Foot other) => self.CompareTo(other) >= 0;

        public static Foot operator +(Foot self, Foot other) => new Foot(self._value + other._value);
        public static Foot operator -(Foot self, Foot other) => new Foot(self._value - other._value);

        public static Foot operator *(Foot self, double other) => new Foot(self._value * other);
        public static Foot operator *(double self, Foot other) => new Foot(self * other._value);

        public static Foot operator /(Foot self, double other) => new Foot(self._value / other);

        public static explicit operator double(Foot self) => self._value;
        public static explicit operator Foot(double self) => new Foot(self);
    }
}