using System;

namespace SystemOfUnits.Mass.Gram {
    public partial struct Centigram {
        public static implicit operator Centigram(Kilogram self) => new Centigram(self.Value * Math.Pow(10, 5));
        public static implicit operator Centigram(Hectogram self) => new Centigram(self.Value * Math.Pow(10, 4));
        public static implicit operator Centigram(Decagram self) => new Centigram(self.Value * Math.Pow(10, 3));
        public static implicit operator Centigram(Gram self) => new Centigram(self.Value * Math.Pow(10, 2));
        public static implicit operator Centigram(Decigram self) => new Centigram(self.Value * Math.Pow(10, 1));
        public static implicit operator Centigram(Milligram self) => new Centigram(self.Value * Math.Pow(10, -1));
    }
}
