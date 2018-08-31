using System;

namespace SystemOfUnits.Mass.Gram {
    public partial struct Decigram {
        public static implicit operator Decigram(Kilogram self) => new Decigram(self.Value * Math.Pow(10, 4));
        public static implicit operator Decigram(Hectogram self) => new Decigram(self.Value * Math.Pow(10, 3));
        public static implicit operator Decigram(Decagram self) => new Decigram(self.Value * Math.Pow(10, 2));
        public static implicit operator Decigram(Gram self) => new Decigram(self.Value * Math.Pow(10, 1));
        public static implicit operator Decigram(Centigram self) => new Decigram(self.Value * Math.Pow(10, -1));
        public static implicit operator Decigram(Milligram self) => new Decigram(self.Value * Math.Pow(10, -2));
    }
}
