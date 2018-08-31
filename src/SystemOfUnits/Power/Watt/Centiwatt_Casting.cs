using System;

namespace SystemOfUnits.Power.Watt {
    public partial struct Centiwatt {
        public static implicit operator Centiwatt(Kilowatt self) => new Centiwatt(self.Value * Math.Pow(10, 5));
        public static implicit operator Centiwatt(Hectowatt self) => new Centiwatt(self.Value * Math.Pow(10, 4));
        public static implicit operator Centiwatt(Decawatt self) => new Centiwatt(self.Value * Math.Pow(10, 3));
        public static implicit operator Centiwatt(Watt self) => new Centiwatt(self.Value * Math.Pow(10, 2));
        public static implicit operator Centiwatt(Deciwatt self) => new Centiwatt(self.Value * Math.Pow(10, 1));
        public static implicit operator Centiwatt(Milliwatt self) => new Centiwatt(self.Value * Math.Pow(10, -1));
    }
}
