using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Kibibyte {
        public static implicit operator Kibibyte(Yobibyte self) => new Kibibyte(self.Value * Math.Pow(2, 70));
        public static implicit operator Kibibyte(Zebibyte self) => new Kibibyte(self.Value * Math.Pow(2, 60));
        public static implicit operator Kibibyte(Exbibyte self) => new Kibibyte(self.Value * Math.Pow(2, 50));
        public static implicit operator Kibibyte(Pebibyte self) => new Kibibyte(self.Value * Math.Pow(2, 40));
        public static implicit operator Kibibyte(Tebibyte self) => new Kibibyte(self.Value * Math.Pow(2, 30));
        public static implicit operator Kibibyte(Gibibyte self) => new Kibibyte(self.Value * Math.Pow(2, 20));
        public static implicit operator Kibibyte(Mebibyte self) => new Kibibyte(self.Value * Math.Pow(2, 10));
        public static implicit operator Kibibyte(Byte self) => new Kibibyte(self.Value * Math.Pow(2, -10));
    }
}
