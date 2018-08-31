using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Pebibyte {
        public static implicit operator Pebibyte(Yobibyte self) => new Pebibyte(self.Value * Math.Pow(2, 30));
        public static implicit operator Pebibyte(Zebibyte self) => new Pebibyte(self.Value * Math.Pow(2, 20));
        public static implicit operator Pebibyte(Exbibyte self) => new Pebibyte(self.Value * Math.Pow(2, 10));
        public static implicit operator Pebibyte(Tebibyte self) => new Pebibyte(self.Value * Math.Pow(2, -10));
        public static implicit operator Pebibyte(Gibibyte self) => new Pebibyte(self.Value * Math.Pow(2, -20));
        public static implicit operator Pebibyte(Mebibyte self) => new Pebibyte(self.Value * Math.Pow(2, -30));
        public static implicit operator Pebibyte(Kibibyte self) => new Pebibyte(self.Value * Math.Pow(2, -40));
        public static implicit operator Pebibyte(Byte self) => new Pebibyte(self.Value * Math.Pow(2, -50));
    }
}
