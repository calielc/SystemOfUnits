using System;

namespace SystemOfUnits.Frequency.Hertz {
    public partial struct Kilohertz {
        public static implicit operator Kilohertz(Hectohertz self) => new Kilohertz(self.Value * Math.Pow(10, -1));
        public static implicit operator Kilohertz(Decahertz self) => new Kilohertz(self.Value * Math.Pow(10, -2));
        public static implicit operator Kilohertz(Hertz self) => new Kilohertz(self.Value * Math.Pow(10, -3));
        public static implicit operator Kilohertz(Decihertz self) => new Kilohertz(self.Value * Math.Pow(10, -4));
        public static implicit operator Kilohertz(Centihertz self) => new Kilohertz(self.Value * Math.Pow(10, -5));
        public static implicit operator Kilohertz(Millihertz self) => new Kilohertz(self.Value * Math.Pow(10, -6));
    }
}
