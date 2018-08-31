using System;

namespace SystemOfUnits.DigitalInformation.Bit {
    public partial struct Megabit {
        public static implicit operator Megabit(Terabit self) => new Megabit(self.Value * Math.Pow(10, 6));
        public static implicit operator Megabit(Gigabit self) => new Megabit(self.Value * Math.Pow(10, 3));
        public static implicit operator Megabit(Kilobit self) => new Megabit(self.Value * Math.Pow(10, -3));
        public static implicit operator Megabit(Bit self) => new Megabit(self.Value * Math.Pow(10, -6));
    }
}
