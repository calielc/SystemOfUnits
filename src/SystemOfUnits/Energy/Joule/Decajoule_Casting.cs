using System;

namespace SystemOfUnits.Energy.Joule {
    public partial struct Decajoule {
        public static implicit operator Decajoule(Kilojoule self) => new Decajoule(self.Value * Math.Pow(10, 2));
        public static implicit operator Decajoule(Hectojoule self) => new Decajoule(self.Value * Math.Pow(10, 1));
        public static implicit operator Decajoule(Joule self) => new Decajoule(self.Value * Math.Pow(10, -1));
        public static implicit operator Decajoule(Decijoule self) => new Decajoule(self.Value * Math.Pow(10, -2));
        public static implicit operator Decajoule(Centijoule self) => new Decajoule(self.Value * Math.Pow(10, -3));
        public static implicit operator Decajoule(Millijoule self) => new Decajoule(self.Value * Math.Pow(10, -4));
    }
}
