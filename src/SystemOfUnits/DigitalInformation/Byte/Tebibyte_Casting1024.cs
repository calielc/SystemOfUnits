using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Tebibyte {
        public static implicit operator Tebibyte(Yobibyte self) => new Tebibyte(self.Value * Math.Pow(2, 40));
        public static implicit operator Tebibyte(Zebibyte self) => new Tebibyte(self.Value * Math.Pow(2, 30));
        public static implicit operator Tebibyte(Exbibyte self) => new Tebibyte(self.Value * Math.Pow(2, 20));
        public static implicit operator Tebibyte(Pebibyte self) => new Tebibyte(self.Value * Math.Pow(2, 10));
        public static implicit operator Tebibyte(Gibibyte self) => new Tebibyte(self.Value * Math.Pow(2, -10));
        public static implicit operator Tebibyte(Mebibyte self) => new Tebibyte(self.Value * Math.Pow(2, -20));
        public static implicit operator Tebibyte(Kibibyte self) => new Tebibyte(self.Value * Math.Pow(2, -30));
        public static implicit operator Tebibyte(Byte self) => new Tebibyte(self.Value * Math.Pow(2, -40));
    }
}
