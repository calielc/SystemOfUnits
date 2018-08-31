using System;

namespace SystemOfUnits.Frequency.Hertz {
    public partial struct Hectohertz {
        public static implicit operator Hectohertz(Kilohertz self) => new Hectohertz(self.Value * Math.Pow(10, 1));
        public static implicit operator Hectohertz(Decahertz self) => new Hectohertz(self.Value * Math.Pow(10, -1));
        public static implicit operator Hectohertz(Hertz self) => new Hectohertz(self.Value * Math.Pow(10, -2));
        public static implicit operator Hectohertz(Decihertz self) => new Hectohertz(self.Value * Math.Pow(10, -3));
        public static implicit operator Hectohertz(Centihertz self) => new Hectohertz(self.Value * Math.Pow(10, -4));
        public static implicit operator Hectohertz(Millihertz self) => new Hectohertz(self.Value * Math.Pow(10, -5));
    }
}
