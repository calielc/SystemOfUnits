using System;

namespace SystemOfUnits.Energy.Joule {
    public partial struct Centijoule {
        public static implicit operator Centijoule(Kilojoule self) => new Centijoule(self.Value * Math.Pow(10, 5));
        public static implicit operator Centijoule(Hectojoule self) => new Centijoule(self.Value * Math.Pow(10, 4));
        public static implicit operator Centijoule(Decajoule self) => new Centijoule(self.Value * Math.Pow(10, 3));
        public static implicit operator Centijoule(Joule self) => new Centijoule(self.Value * Math.Pow(10, 2));
        public static implicit operator Centijoule(Decijoule self) => new Centijoule(self.Value * Math.Pow(10, 1));
        public static implicit operator Centijoule(Millijoule self) => new Centijoule(self.Value * Math.Pow(10, -1));
    }
}
