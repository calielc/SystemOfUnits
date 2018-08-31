using System;

namespace SystemOfUnits.Power.Watt {
    public partial struct Hectowatt {
        public static implicit operator Hectowatt(Kilowatt self) => new Hectowatt(self.Value * Math.Pow(10, 1));
        public static implicit operator Hectowatt(Decawatt self) => new Hectowatt(self.Value * Math.Pow(10, -1));
        public static implicit operator Hectowatt(Watt self) => new Hectowatt(self.Value * Math.Pow(10, -2));
        public static implicit operator Hectowatt(Deciwatt self) => new Hectowatt(self.Value * Math.Pow(10, -3));
        public static implicit operator Hectowatt(Centiwatt self) => new Hectowatt(self.Value * Math.Pow(10, -4));
        public static implicit operator Hectowatt(Milliwatt self) => new Hectowatt(self.Value * Math.Pow(10, -5));
    }
}
