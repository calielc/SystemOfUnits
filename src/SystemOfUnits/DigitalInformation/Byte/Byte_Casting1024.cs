using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Byte {
        public static implicit operator Byte(Yobibyte self) => new Byte(self.Value * Math.Pow(2, 80));
        public static implicit operator Byte(Zebibyte self) => new Byte(self.Value * Math.Pow(2, 70));
        public static implicit operator Byte(Exbibyte self) => new Byte(self.Value * Math.Pow(2, 60));
        public static implicit operator Byte(Pebibyte self) => new Byte(self.Value * Math.Pow(2, 50));
        public static implicit operator Byte(Tebibyte self) => new Byte(self.Value * Math.Pow(2, 40));
        public static implicit operator Byte(Gibibyte self) => new Byte(self.Value * Math.Pow(2, 30));
        public static implicit operator Byte(Mebibyte self) => new Byte(self.Value * Math.Pow(2, 20));
        public static implicit operator Byte(Kibibyte self) => new Byte(self.Value * Math.Pow(2, 10));
    }
}
