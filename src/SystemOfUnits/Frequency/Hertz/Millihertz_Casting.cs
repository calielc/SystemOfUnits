using System;

namespace SystemOfUnits.Frequency.Hertz {
    public partial struct Millihertz {
        public static implicit operator Millihertz(Kilohertz self) => new Millihertz(self.Value * Math.Pow(10, 6));
        public static implicit operator Millihertz(Hectohertz self) => new Millihertz(self.Value * Math.Pow(10, 5));
        public static implicit operator Millihertz(Decahertz self) => new Millihertz(self.Value * Math.Pow(10, 4));
        public static implicit operator Millihertz(Hertz self) => new Millihertz(self.Value * Math.Pow(10, 3));
        public static implicit operator Millihertz(Decihertz self) => new Millihertz(self.Value * Math.Pow(10, 2));
        public static implicit operator Millihertz(Centihertz self) => new Millihertz(self.Value * Math.Pow(10, 1));
    }
}
