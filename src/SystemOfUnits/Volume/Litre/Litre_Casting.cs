using System;

namespace SystemOfUnits.Volume.Litre {
    public partial struct Litre {
        public static implicit operator Litre(Kilolitre self) => new Litre(self.Value * Math.Pow(10, 3));
        public static implicit operator Litre(Hectolitre self) => new Litre(self.Value * Math.Pow(10, 2));
        public static implicit operator Litre(Decalitre self) => new Litre(self.Value * Math.Pow(10, 1));
        public static implicit operator Litre(Decilitre self) => new Litre(self.Value * Math.Pow(10, -1));
        public static implicit operator Litre(Centilitre self) => new Litre(self.Value * Math.Pow(10, -2));
        public static implicit operator Litre(Millilitre self) => new Litre(self.Value * Math.Pow(10, -3));
    }
}
