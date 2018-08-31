using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Byte {
        public static implicit operator Byte(Yottabyte self) => new Byte(self.Value * Math.Pow(10, 24));
        public static implicit operator Byte(Zettabyte self) => new Byte(self.Value * Math.Pow(10, 21));
        public static implicit operator Byte(Exabyte self) => new Byte(self.Value * Math.Pow(10, 18));
        public static implicit operator Byte(Petabyte self) => new Byte(self.Value * Math.Pow(10, 15));
        public static implicit operator Byte(Terabyte self) => new Byte(self.Value * Math.Pow(10, 12));
        public static implicit operator Byte(Gigabyte self) => new Byte(self.Value * Math.Pow(10, 9));
        public static implicit operator Byte(Megabyte self) => new Byte(self.Value * Math.Pow(10, 6));
        public static implicit operator Byte(Kilobyte self) => new Byte(self.Value * Math.Pow(10, 3));
    }
}
