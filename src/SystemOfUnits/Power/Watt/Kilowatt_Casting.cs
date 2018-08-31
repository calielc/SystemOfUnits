using System;

namespace SystemOfUnits.Power.Watt {
    public partial struct Kilowatt {
        public static implicit operator Kilowatt(Hectowatt self) => new Kilowatt(self.Value * Math.Pow(10, -1));
        public static implicit operator Kilowatt(Decawatt self) => new Kilowatt(self.Value * Math.Pow(10, -2));
        public static implicit operator Kilowatt(Watt self) => new Kilowatt(self.Value * Math.Pow(10, -3));
        public static implicit operator Kilowatt(Deciwatt self) => new Kilowatt(self.Value * Math.Pow(10, -4));
        public static implicit operator Kilowatt(Centiwatt self) => new Kilowatt(self.Value * Math.Pow(10, -5));
        public static implicit operator Kilowatt(Milliwatt self) => new Kilowatt(self.Value * Math.Pow(10, -6));
    }
}
