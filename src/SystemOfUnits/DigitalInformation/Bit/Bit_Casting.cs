using System;

namespace SystemOfUnits.DigitalInformation.Bit {
    public partial struct Bit {
        public static implicit operator Bit(Terabit self) => new Bit(self.Value * Math.Pow(10, 12));
        public static implicit operator Bit(Gigabit self) => new Bit(self.Value * Math.Pow(10, 9));
        public static implicit operator Bit(Megabit self) => new Bit(self.Value * Math.Pow(10, 6));
        public static implicit operator Bit(Kilobit self) => new Bit(self.Value * Math.Pow(10, 3));
    }
}
