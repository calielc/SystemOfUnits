using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Exabyte {
        public static implicit operator Exabyte(Yottabyte self) => new Exabyte(self.Value * Math.Pow(10, 6));
        public static implicit operator Exabyte(Zettabyte self) => new Exabyte(self.Value * Math.Pow(10, 3));
        public static implicit operator Exabyte(Petabyte self) => new Exabyte(self.Value * Math.Pow(10, -3));
        public static implicit operator Exabyte(Terabyte self) => new Exabyte(self.Value * Math.Pow(10, -6));
        public static implicit operator Exabyte(Gigabyte self) => new Exabyte(self.Value * Math.Pow(10, -9));
        public static implicit operator Exabyte(Megabyte self) => new Exabyte(self.Value * Math.Pow(10, -12));
        public static implicit operator Exabyte(Kilobyte self) => new Exabyte(self.Value * Math.Pow(10, -15));
        public static implicit operator Exabyte(Byte self) => new Exabyte(self.Value * Math.Pow(10, -18));
    }
}
