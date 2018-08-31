using System;

namespace SystemOfUnits.DigitalInformation.Bit {
    public partial struct Gigabit {
        public static implicit operator Gigabit(Terabit self) => new Gigabit(self.Value * Math.Pow(10, 3));
        public static implicit operator Gigabit(Megabit self) => new Gigabit(self.Value * Math.Pow(10, -3));
        public static implicit operator Gigabit(Kilobit self) => new Gigabit(self.Value * Math.Pow(10, -6));
        public static implicit operator Gigabit(Bit self) => new Gigabit(self.Value * Math.Pow(10, -9));
    }
}
