using System;

namespace SystemOfUnits.Energy.Joule {
    public partial struct Hectojoule {
        public static implicit operator Hectojoule(Kilojoule self) => new Hectojoule(self.Value * Math.Pow(10, 1));
        public static implicit operator Hectojoule(Decajoule self) => new Hectojoule(self.Value * Math.Pow(10, -1));
        public static implicit operator Hectojoule(Joule self) => new Hectojoule(self.Value * Math.Pow(10, -2));
        public static implicit operator Hectojoule(Decijoule self) => new Hectojoule(self.Value * Math.Pow(10, -3));
        public static implicit operator Hectojoule(Centijoule self) => new Hectojoule(self.Value * Math.Pow(10, -4));
        public static implicit operator Hectojoule(Millijoule self) => new Hectojoule(self.Value * Math.Pow(10, -5));
    }
}
