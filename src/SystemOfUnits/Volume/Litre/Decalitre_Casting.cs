using System;

namespace SystemOfUnits.Volume.Litre {
    public partial struct Decalitre {
        public static implicit operator Decalitre(Kilolitre self) => new Decalitre(self.Value * Math.Pow(10, 2));
        public static implicit operator Decalitre(Hectolitre self) => new Decalitre(self.Value * Math.Pow(10, 1));
        public static implicit operator Decalitre(Litre self) => new Decalitre(self.Value * Math.Pow(10, -1));
        public static implicit operator Decalitre(Decilitre self) => new Decalitre(self.Value * Math.Pow(10, -2));
        public static implicit operator Decalitre(Centilitre self) => new Decalitre(self.Value * Math.Pow(10, -3));
        public static implicit operator Decalitre(Millilitre self) => new Decalitre(self.Value * Math.Pow(10, -4));
    }
}
