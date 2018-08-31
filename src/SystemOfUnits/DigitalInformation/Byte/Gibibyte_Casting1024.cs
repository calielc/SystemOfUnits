using System;

namespace SystemOfUnits.DigitalInformation.Byte {
    public partial struct Gibibyte {
        public static implicit operator Gibibyte(Yobibyte self) => new Gibibyte(self.Value * Math.Pow(2, 50));
        public static implicit operator Gibibyte(Zebibyte self) => new Gibibyte(self.Value * Math.Pow(2, 40));
        public static implicit operator Gibibyte(Exbibyte self) => new Gibibyte(self.Value * Math.Pow(2, 30));
        public static implicit operator Gibibyte(Pebibyte self) => new Gibibyte(self.Value * Math.Pow(2, 20));
        public static implicit operator Gibibyte(Tebibyte self) => new Gibibyte(self.Value * Math.Pow(2, 10));
        public static implicit operator Gibibyte(Mebibyte self) => new Gibibyte(self.Value * Math.Pow(2, -10));
        public static implicit operator Gibibyte(Kibibyte self) => new Gibibyte(self.Value * Math.Pow(2, -20));
        public static implicit operator Gibibyte(Byte self) => new Gibibyte(self.Value * Math.Pow(2, -30));
    }
}
