using System;

namespace SystemOfUnits.Mass.Gram {
    public partial struct Gram {
        public static implicit operator Gram(Kilogram self) => new Gram(self.Value * Math.Pow(10, 3));
        public static implicit operator Gram(Hectogram self) => new Gram(self.Value * Math.Pow(10, 2));
        public static implicit operator Gram(Decagram self) => new Gram(self.Value * Math.Pow(10, 1));
        public static implicit operator Gram(Decigram self) => new Gram(self.Value * Math.Pow(10, -1));
        public static implicit operator Gram(Centigram self) => new Gram(self.Value * Math.Pow(10, -2));
        public static implicit operator Gram(Milligram self) => new Gram(self.Value * Math.Pow(10, -3));
    }
}
