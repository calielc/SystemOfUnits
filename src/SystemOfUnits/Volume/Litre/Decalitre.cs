using System;
using System.Diagnostics;
using Newtonsoft.Json;

namespace SystemOfUnits.Volume.Litre {
    /// <summary>
    /// Represents a Decalitre (symbol dal).
    /// </summary>
    [Serializable]
    [JsonConverter(typeof(UnitJsonConverter))]
    [DebuggerDisplay("{Value} dal")]
    public readonly partial struct Decalitre : IUnit, IEquatable<Decalitre>, IComparable<Decalitre> {
        private readonly double _value;

        public const string Symbol = "dal";

        public Decalitre(double value) {
            _value = value;
        }

        public double Value => _value;

        public Decalitre Ceiling() => new Decalitre(Math.Ceiling(_value));

        public Decalitre Round() => new Decalitre(Math.Round(_value));
        public Decalitre Round(int digits) => new Decalitre(Math.Round(_value, digits));
        public Decalitre Round(MidpointRounding mode) => new Decalitre(Math.Round(_value, mode));

        public Decalitre Floor() => new Decalitre(Math.Floor(_value));

        public Decalitre Truncate() => new Decalitre(Math.Truncate(_value));

        public Decalitre Abs() => new Decalitre(Math.Abs(_value));

        public bool Equals(Decalitre other) => Math.Abs(this._value - other._value) < 1e-6;

        public int CompareTo(Decalitre other) => this._value.CompareTo(other._value);

        public int CompareTo(object obj) {
            switch (obj) {
                case null:
                    return 1;

                case Decalitre other:
                    return CompareTo(other);

                default:
                    throw new ArgumentException($"Object must be of type {nameof(Decalitre)}");
            }
        }

        public string ToString(string format, IFormatProvider formatProvider)
            => string.Format(format ?? "{0} dal", _value, formatProvider);

        public override bool Equals(object obj) {
            if (obj is null) {
                return false;
            }
            return obj is Decalitre other && Equals(other);
        }

        public override int GetHashCode() => _value.GetHashCode();

        public override string ToString() => $"{_value:e} dal";

        string IUnit.Symbol => Symbol;

        public static bool operator ==(Decalitre self, Decalitre other) => self.Equals(other);
        public static bool operator !=(Decalitre self, Decalitre other) => !self.Equals(other);

        public static bool operator <(Decalitre self, Decalitre other) => self.CompareTo(other) < 0;
        public static bool operator >(Decalitre self, Decalitre other) => self.CompareTo(other) > 0;
        public static bool operator <=(Decalitre self, Decalitre other) => self.CompareTo(other) <= 0;
        public static bool operator >=(Decalitre self, Decalitre other) => self.CompareTo(other) >= 0;

        public static Decalitre operator +(Decalitre self, Decalitre other) => new Decalitre(self._value + other._value);
        public static Decalitre operator -(Decalitre self, Decalitre other) => new Decalitre(self._value - other._value);

        public static Decalitre operator *(Decalitre self, double other) => new Decalitre(self._value * other);
        public static Decalitre operator *(double self, Decalitre other) => new Decalitre(self * other._value);

        public static Decalitre operator /(Decalitre self, double other) => new Decalitre(self._value / other);

        public static explicit operator double(Decalitre self) => self._value;
        public static explicit operator Decalitre(double self) => new Decalitre(self);
    }
}