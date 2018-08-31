using System;

namespace SystemOfUnits.Mass.Gram {
    public partial struct Decagram {
        public static implicit operator Decagram(Kilogram self) => new Decagram(self.Value * Math.Pow(10, 2));
        public static implicit operator Decagram(Hectogram self) => new Decagram(self.Value * Math.Pow(10, 1));
        public static implicit operator Decagram(Gram self) => new Decagram(self.Value * Math.Pow(10, -1));
        public static implicit operator Decagram(Decigram self) => new Decagram(self.Value * Math.Pow(10, -2));
        public static implicit operator Decagram(Centigram self) => new Decagram(self.Value * Math.Pow(10, -3));
        public static implicit operator Decagram(Milligram self) => new Decagram(self.Value * Math.Pow(10, -4));
    }
}
