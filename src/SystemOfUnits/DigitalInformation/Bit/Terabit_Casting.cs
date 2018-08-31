using System;

namespace SystemOfUnits.DigitalInformation.Bit {
    public partial struct Terabit {
        public static implicit operator Terabit(Gigabit self) => new Terabit(self.Value * Math.Pow(10, -3));
        public static implicit operator Terabit(Megabit self) => new Terabit(self.Value * Math.Pow(10, -6));
        public static implicit operator Terabit(Kilobit self) => new Terabit(self.Value * Math.Pow(10, -9));
        public static implicit operator Terabit(Bit self) => new Terabit(self.Value * Math.Pow(10, -12));
    }
}
