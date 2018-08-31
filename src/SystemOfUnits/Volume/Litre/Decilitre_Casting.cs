using System;

namespace SystemOfUnits.Volume.Litre {
    public partial struct Decilitre {
        public static implicit operator Decilitre(Kilolitre self) => new Decilitre(self.Value * Math.Pow(10, 4));
        public static implicit operator Decilitre(Hectolitre self) => new Decilitre(self.Value * Math.Pow(10, 3));
        public static implicit operator Decilitre(Decalitre self) => new Decilitre(self.Value * Math.Pow(10, 2));
        public static implicit operator Decilitre(Litre self) => new Decilitre(self.Value * Math.Pow(10, 1));
        public static implicit operator Decilitre(Centilitre self) => new Decilitre(self.Value * Math.Pow(10, -1));
        public static implicit operator Decilitre(Millilitre self) => new Decilitre(self.Value * Math.Pow(10, -2));
    }
}
