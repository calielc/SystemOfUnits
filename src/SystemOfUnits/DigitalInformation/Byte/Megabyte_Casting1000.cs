using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Megabyte {
        public static implicit operator Megabyte(Yottabyte self) => new Megabyte(self.Value * Math.Pow(10, 18));
        public static implicit operator Megabyte(Zettabyte self) => new Megabyte(self.Value * Math.Pow(10, 15));
        public static implicit operator Megabyte(Exabyte self) => new Megabyte(self.Value * Math.Pow(10, 12));
        public static implicit operator Megabyte(Petabyte self) => new Megabyte(self.Value * Math.Pow(10, 9));
        public static implicit operator Megabyte(Terabyte self) => new Megabyte(self.Value * Math.Pow(10, 6));
        public static implicit operator Megabyte(Gigabyte self) => new Megabyte(self.Value * Math.Pow(10, 3));
        public static implicit operator Megabyte(Kilobyte self) => new Megabyte(self.Value * Math.Pow(10, -3));
        public static implicit operator Megabyte(Byte self) => new Megabyte(self.Value * Math.Pow(10, -6));
    }
}
