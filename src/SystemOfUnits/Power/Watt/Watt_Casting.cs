using System;

namespace SystemOfUnits.Power.Watt {
    public partial struct Watt {
        public static implicit operator Watt(Kilowatt self) => new Watt(self.Value * Math.Pow(10, 3));
        public static implicit operator Watt(Hectowatt self) => new Watt(self.Value * Math.Pow(10, 2));
        public static implicit operator Watt(Decawatt self) => new Watt(self.Value * Math.Pow(10, 1));
        public static implicit operator Watt(Deciwatt self) => new Watt(self.Value * Math.Pow(10, -1));
        public static implicit operator Watt(Centiwatt self) => new Watt(self.Value * Math.Pow(10, -2));
        public static implicit operator Watt(Milliwatt self) => new Watt(self.Value * Math.Pow(10, -3));
    }
}
