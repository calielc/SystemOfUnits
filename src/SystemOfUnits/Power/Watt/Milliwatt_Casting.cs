using System;

namespace SystemOfUnits.Power.Watt {
    public partial struct Milliwatt {
        public static implicit operator Milliwatt(Kilowatt self) => new Milliwatt(self.Value * Math.Pow(10, 6));
        public static implicit operator Milliwatt(Hectowatt self) => new Milliwatt(self.Value * Math.Pow(10, 5));
        public static implicit operator Milliwatt(Decawatt self) => new Milliwatt(self.Value * Math.Pow(10, 4));
        public static implicit operator Milliwatt(Watt self) => new Milliwatt(self.Value * Math.Pow(10, 3));
        public static implicit operator Milliwatt(Deciwatt self) => new Milliwatt(self.Value * Math.Pow(10, 2));
        public static implicit operator Milliwatt(Centiwatt self) => new Milliwatt(self.Value * Math.Pow(10, 1));
    }
}
