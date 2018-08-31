using System;

namespace SystemOfUnits.Frequency.Hertz {
    public partial struct Hertz {
        public static implicit operator Hertz(Kilohertz self) => new Hertz(self.Value * Math.Pow(10, 3));
        public static implicit operator Hertz(Hectohertz self) => new Hertz(self.Value * Math.Pow(10, 2));
        public static implicit operator Hertz(Decahertz self) => new Hertz(self.Value * Math.Pow(10, 1));
        public static implicit operator Hertz(Decihertz self) => new Hertz(self.Value * Math.Pow(10, -1));
        public static implicit operator Hertz(Centihertz self) => new Hertz(self.Value * Math.Pow(10, -2));
        public static implicit operator Hertz(Millihertz self) => new Hertz(self.Value * Math.Pow(10, -3));
    }
}
