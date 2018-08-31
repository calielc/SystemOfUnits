using System;

namespace SystemOfUnits.Volume.Litre {
    public partial struct Centilitre {
        public static implicit operator Centilitre(Kilolitre self) => new Centilitre(self.Value * Math.Pow(10, 5));
        public static implicit operator Centilitre(Hectolitre self) => new Centilitre(self.Value * Math.Pow(10, 4));
        public static implicit operator Centilitre(Decalitre self) => new Centilitre(self.Value * Math.Pow(10, 3));
        public static implicit operator Centilitre(Litre self) => new Centilitre(self.Value * Math.Pow(10, 2));
        public static implicit operator Centilitre(Decilitre self) => new Centilitre(self.Value * Math.Pow(10, 1));
        public static implicit operator Centilitre(Millilitre self) => new Centilitre(self.Value * Math.Pow(10, -1));
    }
}
