using System;

namespace SystemOfUnits.Mass.Gram {
    public partial struct Hectogram {
        public static implicit operator Hectogram(Kilogram self) => new Hectogram(self.Value * Math.Pow(10, 1));
        public static implicit operator Hectogram(Decagram self) => new Hectogram(self.Value * Math.Pow(10, -1));
        public static implicit operator Hectogram(Gram self) => new Hectogram(self.Value * Math.Pow(10, -2));
        public static implicit operator Hectogram(Decigram self) => new Hectogram(self.Value * Math.Pow(10, -3));
        public static implicit operator Hectogram(Centigram self) => new Hectogram(self.Value * Math.Pow(10, -4));
        public static implicit operator Hectogram(Milligram self) => new Hectogram(self.Value * Math.Pow(10, -5));
    }
}
