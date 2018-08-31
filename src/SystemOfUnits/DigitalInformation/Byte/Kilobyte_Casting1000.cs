using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Kilobyte {
        public static implicit operator Kilobyte(Yottabyte self) => new Kilobyte(self.Value * Math.Pow(10, 21));
        public static implicit operator Kilobyte(Zettabyte self) => new Kilobyte(self.Value * Math.Pow(10, 18));
        public static implicit operator Kilobyte(Exabyte self) => new Kilobyte(self.Value * Math.Pow(10, 15));
        public static implicit operator Kilobyte(Petabyte self) => new Kilobyte(self.Value * Math.Pow(10, 12));
        public static implicit operator Kilobyte(Terabyte self) => new Kilobyte(self.Value * Math.Pow(10, 9));
        public static implicit operator Kilobyte(Gigabyte self) => new Kilobyte(self.Value * Math.Pow(10, 6));
        public static implicit operator Kilobyte(Megabyte self) => new Kilobyte(self.Value * Math.Pow(10, 3));
        public static implicit operator Kilobyte(Byte self) => new Kilobyte(self.Value * Math.Pow(10, -3));
    }
}
