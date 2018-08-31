using System;

namespace SystemOfUnits.Mass.Gram {
    public partial struct Milligram {
        public static implicit operator Milligram(Kilogram self) => new Milligram(self.Value * Math.Pow(10, 6));
        public static implicit operator Milligram(Hectogram self) => new Milligram(self.Value * Math.Pow(10, 5));
        public static implicit operator Milligram(Decagram self) => new Milligram(self.Value * Math.Pow(10, 4));
        public static implicit operator Milligram(Gram self) => new Milligram(self.Value * Math.Pow(10, 3));
        public static implicit operator Milligram(Decigram self) => new Milligram(self.Value * Math.Pow(10, 2));
        public static implicit operator Milligram(Centigram self) => new Milligram(self.Value * Math.Pow(10, 1));
    }
}
