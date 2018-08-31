using System;

namespace SystemOfUnits.Energy.Joule {
    public partial struct Millijoule {
        public static implicit operator Millijoule(Kilojoule self) => new Millijoule(self.Value * Math.Pow(10, 6));
        public static implicit operator Millijoule(Hectojoule self) => new Millijoule(self.Value * Math.Pow(10, 5));
        public static implicit operator Millijoule(Decajoule self) => new Millijoule(self.Value * Math.Pow(10, 4));
        public static implicit operator Millijoule(Joule self) => new Millijoule(self.Value * Math.Pow(10, 3));
        public static implicit operator Millijoule(Decijoule self) => new Millijoule(self.Value * Math.Pow(10, 2));
        public static implicit operator Millijoule(Centijoule self) => new Millijoule(self.Value * Math.Pow(10, 1));
    }
}
