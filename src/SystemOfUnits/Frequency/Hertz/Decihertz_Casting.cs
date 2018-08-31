using System;

namespace SystemOfUnits.Frequency.Hertz {
    public partial struct Decihertz {
        public static implicit operator Decihertz(Kilohertz self) => new Decihertz(self.Value * Math.Pow(10, 4));
        public static implicit operator Decihertz(Hectohertz self) => new Decihertz(self.Value * Math.Pow(10, 3));
        public static implicit operator Decihertz(Decahertz self) => new Decihertz(self.Value * Math.Pow(10, 2));
        public static implicit operator Decihertz(Hertz self) => new Decihertz(self.Value * Math.Pow(10, 1));
        public static implicit operator Decihertz(Centihertz self) => new Decihertz(self.Value * Math.Pow(10, -1));
        public static implicit operator Decihertz(Millihertz self) => new Decihertz(self.Value * Math.Pow(10, -2));
    }
}
