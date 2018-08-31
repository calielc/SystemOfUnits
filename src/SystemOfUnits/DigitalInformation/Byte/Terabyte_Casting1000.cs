using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Terabyte {
        public static implicit operator Terabyte(Yottabyte self) => new Terabyte(self.Value * Math.Pow(10, 12));
        public static implicit operator Terabyte(Zettabyte self) => new Terabyte(self.Value * Math.Pow(10, 9));
        public static implicit operator Terabyte(Exabyte self) => new Terabyte(self.Value * Math.Pow(10, 6));
        public static implicit operator Terabyte(Petabyte self) => new Terabyte(self.Value * Math.Pow(10, 3));
        public static implicit operator Terabyte(Gigabyte self) => new Terabyte(self.Value * Math.Pow(10, -3));
        public static implicit operator Terabyte(Megabyte self) => new Terabyte(self.Value * Math.Pow(10, -6));
        public static implicit operator Terabyte(Kilobyte self) => new Terabyte(self.Value * Math.Pow(10, -9));
        public static implicit operator Terabyte(Byte self) => new Terabyte(self.Value * Math.Pow(10, -12));
    }
}
