using System;

namespace SystemOfUnits.Volume.Litre {
    public partial struct Kilolitre {
        public static implicit operator Kilolitre(Hectolitre self) => new Kilolitre(self.Value * Math.Pow(10, -1));
        public static implicit operator Kilolitre(Decalitre self) => new Kilolitre(self.Value * Math.Pow(10, -2));
        public static implicit operator Kilolitre(Litre self) => new Kilolitre(self.Value * Math.Pow(10, -3));
        public static implicit operator Kilolitre(Decilitre self) => new Kilolitre(self.Value * Math.Pow(10, -4));
        public static implicit operator Kilolitre(Centilitre self) => new Kilolitre(self.Value * Math.Pow(10, -5));
        public static implicit operator Kilolitre(Millilitre self) => new Kilolitre(self.Value * Math.Pow(10, -6));
    }
}
