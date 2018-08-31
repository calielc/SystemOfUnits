using System;

namespace SystemOfUnits.Volume.Litre {
    public partial struct Millilitre {
        public static implicit operator Millilitre(Kilolitre self) => new Millilitre(self.Value * Math.Pow(10, 6));
        public static implicit operator Millilitre(Hectolitre self) => new Millilitre(self.Value * Math.Pow(10, 5));
        public static implicit operator Millilitre(Decalitre self) => new Millilitre(self.Value * Math.Pow(10, 4));
        public static implicit operator Millilitre(Litre self) => new Millilitre(self.Value * Math.Pow(10, 3));
        public static implicit operator Millilitre(Decilitre self) => new Millilitre(self.Value * Math.Pow(10, 2));
        public static implicit operator Millilitre(Centilitre self) => new Millilitre(self.Value * Math.Pow(10, 1));
    }
}
