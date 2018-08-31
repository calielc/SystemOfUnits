using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Petabyte {
        public static implicit operator Petabyte(Yottabyte self) => new Petabyte(self.Value * Math.Pow(10, 9));
        public static implicit operator Petabyte(Zettabyte self) => new Petabyte(self.Value * Math.Pow(10, 6));
        public static implicit operator Petabyte(Exabyte self) => new Petabyte(self.Value * Math.Pow(10, 3));
        public static implicit operator Petabyte(Terabyte self) => new Petabyte(self.Value * Math.Pow(10, -3));
        public static implicit operator Petabyte(Gigabyte self) => new Petabyte(self.Value * Math.Pow(10, -6));
        public static implicit operator Petabyte(Megabyte self) => new Petabyte(self.Value * Math.Pow(10, -9));
        public static implicit operator Petabyte(Kilobyte self) => new Petabyte(self.Value * Math.Pow(10, -12));
        public static implicit operator Petabyte(Byte self) => new Petabyte(self.Value * Math.Pow(10, -15));
    }
}
