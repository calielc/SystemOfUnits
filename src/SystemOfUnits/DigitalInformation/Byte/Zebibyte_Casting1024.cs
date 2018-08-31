using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Zebibyte {
        public static implicit operator Zebibyte(Yobibyte self) => new Zebibyte(self.Value * Math.Pow(2, 10));
        public static implicit operator Zebibyte(Exbibyte self) => new Zebibyte(self.Value * Math.Pow(2, -10));
        public static implicit operator Zebibyte(Pebibyte self) => new Zebibyte(self.Value * Math.Pow(2, -20));
        public static implicit operator Zebibyte(Tebibyte self) => new Zebibyte(self.Value * Math.Pow(2, -30));
        public static implicit operator Zebibyte(Gibibyte self) => new Zebibyte(self.Value * Math.Pow(2, -40));
        public static implicit operator Zebibyte(Mebibyte self) => new Zebibyte(self.Value * Math.Pow(2, -50));
        public static implicit operator Zebibyte(Kibibyte self) => new Zebibyte(self.Value * Math.Pow(2, -60));
        public static implicit operator Zebibyte(Byte self) => new Zebibyte(self.Value * Math.Pow(2, -70));
    }
}
