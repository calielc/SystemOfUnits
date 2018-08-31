using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Zettabyte {
        public static implicit operator Zettabyte(Yottabyte self) => new Zettabyte(self.Value * Math.Pow(10, 3));
        public static implicit operator Zettabyte(Exabyte self) => new Zettabyte(self.Value * Math.Pow(10, -3));
        public static implicit operator Zettabyte(Petabyte self) => new Zettabyte(self.Value * Math.Pow(10, -6));
        public static implicit operator Zettabyte(Terabyte self) => new Zettabyte(self.Value * Math.Pow(10, -9));
        public static implicit operator Zettabyte(Gigabyte self) => new Zettabyte(self.Value * Math.Pow(10, -12));
        public static implicit operator Zettabyte(Megabyte self) => new Zettabyte(self.Value * Math.Pow(10, -15));
        public static implicit operator Zettabyte(Kilobyte self) => new Zettabyte(self.Value * Math.Pow(10, -18));
        public static implicit operator Zettabyte(Byte self) => new Zettabyte(self.Value * Math.Pow(10, -21));
    }
}
