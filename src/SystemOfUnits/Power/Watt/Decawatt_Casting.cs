using System;

namespace SystemOfUnits.Power.Watt {
    public partial struct Decawatt {
        public static implicit operator Decawatt(Kilowatt self) => new Decawatt(self.Value * Math.Pow(10, 2));
        public static implicit operator Decawatt(Hectowatt self) => new Decawatt(self.Value * Math.Pow(10, 1));
        public static implicit operator Decawatt(Watt self) => new Decawatt(self.Value * Math.Pow(10, -1));
        public static implicit operator Decawatt(Deciwatt self) => new Decawatt(self.Value * Math.Pow(10, -2));
        public static implicit operator Decawatt(Centiwatt self) => new Decawatt(self.Value * Math.Pow(10, -3));
        public static implicit operator Decawatt(Milliwatt self) => new Decawatt(self.Value * Math.Pow(10, -4));
    }
}
