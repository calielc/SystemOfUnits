using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Yottabyte {
        public static implicit operator Yottabyte(Zettabyte self) => new Yottabyte(self.Value * Math.Pow(10, -3));
        public static implicit operator Yottabyte(Exabyte self) => new Yottabyte(self.Value * Math.Pow(10, -6));
        public static implicit operator Yottabyte(Petabyte self) => new Yottabyte(self.Value * Math.Pow(10, -9));
        public static implicit operator Yottabyte(Terabyte self) => new Yottabyte(self.Value * Math.Pow(10, -12));
        public static implicit operator Yottabyte(Gigabyte self) => new Yottabyte(self.Value * Math.Pow(10, -15));
        public static implicit operator Yottabyte(Megabyte self) => new Yottabyte(self.Value * Math.Pow(10, -18));
        public static implicit operator Yottabyte(Kilobyte self) => new Yottabyte(self.Value * Math.Pow(10, -21));
        public static implicit operator Yottabyte(Byte self) => new Yottabyte(self.Value * Math.Pow(10, -24));
    }
}
