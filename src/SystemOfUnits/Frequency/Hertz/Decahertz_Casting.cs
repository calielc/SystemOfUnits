using System;

namespace SystemOfUnits.Frequency.Hertz {
    public partial struct Decahertz {
        public static implicit operator Decahertz(Kilohertz self) => new Decahertz(self.Value * Math.Pow(10, 2));
        public static implicit operator Decahertz(Hectohertz self) => new Decahertz(self.Value * Math.Pow(10, 1));
        public static implicit operator Decahertz(Hertz self) => new Decahertz(self.Value * Math.Pow(10, -1));
        public static implicit operator Decahertz(Decihertz self) => new Decahertz(self.Value * Math.Pow(10, -2));
        public static implicit operator Decahertz(Centihertz self) => new Decahertz(self.Value * Math.Pow(10, -3));
        public static implicit operator Decahertz(Millihertz self) => new Decahertz(self.Value * Math.Pow(10, -4));
    }
}
