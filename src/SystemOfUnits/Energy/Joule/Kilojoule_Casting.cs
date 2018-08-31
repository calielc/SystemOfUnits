using System;

namespace SystemOfUnits.Energy.Joule {
    public partial struct Kilojoule {
        public static implicit operator Kilojoule(Hectojoule self) => new Kilojoule(self.Value * Math.Pow(10, -1));
        public static implicit operator Kilojoule(Decajoule self) => new Kilojoule(self.Value * Math.Pow(10, -2));
        public static implicit operator Kilojoule(Joule self) => new Kilojoule(self.Value * Math.Pow(10, -3));
        public static implicit operator Kilojoule(Decijoule self) => new Kilojoule(self.Value * Math.Pow(10, -4));
        public static implicit operator Kilojoule(Centijoule self) => new Kilojoule(self.Value * Math.Pow(10, -5));
        public static implicit operator Kilojoule(Millijoule self) => new Kilojoule(self.Value * Math.Pow(10, -6));
    }
}
