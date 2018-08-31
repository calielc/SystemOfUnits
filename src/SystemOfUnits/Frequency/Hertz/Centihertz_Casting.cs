using System;

namespace SystemOfUnits.Frequency.Hertz {
    public partial struct Centihertz {
        public static implicit operator Centihertz(Kilohertz self) => new Centihertz(self.Value * Math.Pow(10, 5));
        public static implicit operator Centihertz(Hectohertz self) => new Centihertz(self.Value * Math.Pow(10, 4));
        public static implicit operator Centihertz(Decahertz self) => new Centihertz(self.Value * Math.Pow(10, 3));
        public static implicit operator Centihertz(Hertz self) => new Centihertz(self.Value * Math.Pow(10, 2));
        public static implicit operator Centihertz(Decihertz self) => new Centihertz(self.Value * Math.Pow(10, 1));
        public static implicit operator Centihertz(Millihertz self) => new Centihertz(self.Value * Math.Pow(10, -1));
    }
}
