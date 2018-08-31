using System;

namespace SystemOfUnits.Mass.Gram {
    public partial struct Kilogram {
        public static implicit operator Kilogram(Hectogram self) => new Kilogram(self.Value * Math.Pow(10, -1));
        public static implicit operator Kilogram(Decagram self) => new Kilogram(self.Value * Math.Pow(10, -2));
        public static implicit operator Kilogram(Gram self) => new Kilogram(self.Value * Math.Pow(10, -3));
        public static implicit operator Kilogram(Decigram self) => new Kilogram(self.Value * Math.Pow(10, -4));
        public static implicit operator Kilogram(Centigram self) => new Kilogram(self.Value * Math.Pow(10, -5));
        public static implicit operator Kilogram(Milligram self) => new Kilogram(self.Value * Math.Pow(10, -6));
    }
}
