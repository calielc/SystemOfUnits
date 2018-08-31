using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Mebibyte {
        public static implicit operator Mebibyte(Yobibyte self) => new Mebibyte(self.Value * Math.Pow(2, 60));
        public static implicit operator Mebibyte(Zebibyte self) => new Mebibyte(self.Value * Math.Pow(2, 50));
        public static implicit operator Mebibyte(Exbibyte self) => new Mebibyte(self.Value * Math.Pow(2, 40));
        public static implicit operator Mebibyte(Pebibyte self) => new Mebibyte(self.Value * Math.Pow(2, 30));
        public static implicit operator Mebibyte(Tebibyte self) => new Mebibyte(self.Value * Math.Pow(2, 20));
        public static implicit operator Mebibyte(Gibibyte self) => new Mebibyte(self.Value * Math.Pow(2, 10));
        public static implicit operator Mebibyte(Kibibyte self) => new Mebibyte(self.Value * Math.Pow(2, -10));
        public static implicit operator Mebibyte(Byte self) => new Mebibyte(self.Value * Math.Pow(2, -20));
    }
}
