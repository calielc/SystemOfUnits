using System;

namespace SystemOfUnits.Power.Watt {
    public partial struct Deciwatt {
        public static implicit operator Deciwatt(Kilowatt self) => new Deciwatt(self.Value * Math.Pow(10, 4));
        public static implicit operator Deciwatt(Hectowatt self) => new Deciwatt(self.Value * Math.Pow(10, 3));
        public static implicit operator Deciwatt(Decawatt self) => new Deciwatt(self.Value * Math.Pow(10, 2));
        public static implicit operator Deciwatt(Watt self) => new Deciwatt(self.Value * Math.Pow(10, 1));
        public static implicit operator Deciwatt(Centiwatt self) => new Deciwatt(self.Value * Math.Pow(10, -1));
        public static implicit operator Deciwatt(Milliwatt self) => new Deciwatt(self.Value * Math.Pow(10, -2));
    }
}
