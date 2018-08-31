using System;

namespace SystemOfUnits.Energy.Joule {
    public partial struct Joule {
        public static implicit operator Joule(Kilojoule self) => new Joule(self.Value * Math.Pow(10, 3));
        public static implicit operator Joule(Hectojoule self) => new Joule(self.Value * Math.Pow(10, 2));
        public static implicit operator Joule(Decajoule self) => new Joule(self.Value * Math.Pow(10, 1));
        public static implicit operator Joule(Decijoule self) => new Joule(self.Value * Math.Pow(10, -1));
        public static implicit operator Joule(Centijoule self) => new Joule(self.Value * Math.Pow(10, -2));
        public static implicit operator Joule(Millijoule self) => new Joule(self.Value * Math.Pow(10, -3));
    }
}
