using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Yobibyte {
        public static implicit operator Yobibyte(Zebibyte self) => new Yobibyte(self.Value * Math.Pow(2, -10));
        public static implicit operator Yobibyte(Exbibyte self) => new Yobibyte(self.Value * Math.Pow(2, -20));
        public static implicit operator Yobibyte(Pebibyte self) => new Yobibyte(self.Value * Math.Pow(2, -30));
        public static implicit operator Yobibyte(Tebibyte self) => new Yobibyte(self.Value * Math.Pow(2, -40));
        public static implicit operator Yobibyte(Gibibyte self) => new Yobibyte(self.Value * Math.Pow(2, -50));
        public static implicit operator Yobibyte(Mebibyte self) => new Yobibyte(self.Value * Math.Pow(2, -60));
        public static implicit operator Yobibyte(Kibibyte self) => new Yobibyte(self.Value * Math.Pow(2, -70));
        public static implicit operator Yobibyte(Byte self) => new Yobibyte(self.Value * Math.Pow(2, -80));
    }
}
