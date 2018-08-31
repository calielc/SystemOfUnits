using System;

namespace SystemOfUnits.Energy.Joule {
    public partial struct Decijoule {
        public static implicit operator Decijoule(Kilojoule self) => new Decijoule(self.Value * Math.Pow(10, 4));
        public static implicit operator Decijoule(Hectojoule self) => new Decijoule(self.Value * Math.Pow(10, 3));
        public static implicit operator Decijoule(Decajoule self) => new Decijoule(self.Value * Math.Pow(10, 2));
        public static implicit operator Decijoule(Joule self) => new Decijoule(self.Value * Math.Pow(10, 1));
        public static implicit operator Decijoule(Centijoule self) => new Decijoule(self.Value * Math.Pow(10, -1));
        public static implicit operator Decijoule(Millijoule self) => new Decijoule(self.Value * Math.Pow(10, -2));
    }
}
