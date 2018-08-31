using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Gigabyte {
        public static implicit operator Gigabyte(Yottabyte self) => new Gigabyte(self.Value * Math.Pow(10, 15));
        public static implicit operator Gigabyte(Zettabyte self) => new Gigabyte(self.Value * Math.Pow(10, 12));
        public static implicit operator Gigabyte(Exabyte self) => new Gigabyte(self.Value * Math.Pow(10, 9));
        public static implicit operator Gigabyte(Petabyte self) => new Gigabyte(self.Value * Math.Pow(10, 6));
        public static implicit operator Gigabyte(Terabyte self) => new Gigabyte(self.Value * Math.Pow(10, 3));
        public static implicit operator Gigabyte(Megabyte self) => new Gigabyte(self.Value * Math.Pow(10, -3));
        public static implicit operator Gigabyte(Kilobyte self) => new Gigabyte(self.Value * Math.Pow(10, -6));
        public static implicit operator Gigabyte(Byte self) => new Gigabyte(self.Value * Math.Pow(10, -9));
    }
}
