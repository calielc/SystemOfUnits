using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Exbibyte {
        public static implicit operator Exbibyte(Yobibyte self) => new Exbibyte(self.Value * Math.Pow(2, 20));
        public static implicit operator Exbibyte(Zebibyte self) => new Exbibyte(self.Value * Math.Pow(2, 10));
        public static implicit operator Exbibyte(Pebibyte self) => new Exbibyte(self.Value * Math.Pow(2, -10));
        public static implicit operator Exbibyte(Tebibyte self) => new Exbibyte(self.Value * Math.Pow(2, -20));
        public static implicit operator Exbibyte(Gibibyte self) => new Exbibyte(self.Value * Math.Pow(2, -30));
        public static implicit operator Exbibyte(Mebibyte self) => new Exbibyte(self.Value * Math.Pow(2, -40));
        public static implicit operator Exbibyte(Kibibyte self) => new Exbibyte(self.Value * Math.Pow(2, -50));
        public static implicit operator Exbibyte(Byte self) => new Exbibyte(self.Value * Math.Pow(2, -60));
    }
}
