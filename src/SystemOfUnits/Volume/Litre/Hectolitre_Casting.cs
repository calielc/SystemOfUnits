using System;

namespace SystemOfUnits.Volume.Litre {
    public partial struct Hectolitre {
        public static implicit operator Hectolitre(Kilolitre self) => new Hectolitre(self.Value * Math.Pow(10, 1));
        public static implicit operator Hectolitre(Decalitre self) => new Hectolitre(self.Value * Math.Pow(10, -1));
        public static implicit operator Hectolitre(Litre self) => new Hectolitre(self.Value * Math.Pow(10, -2));
        public static implicit operator Hectolitre(Decilitre self) => new Hectolitre(self.Value * Math.Pow(10, -3));
        public static implicit operator Hectolitre(Centilitre self) => new Hectolitre(self.Value * Math.Pow(10, -4));
        public static implicit operator Hectolitre(Millilitre self) => new Hectolitre(self.Value * Math.Pow(10, -5));
    }
}
