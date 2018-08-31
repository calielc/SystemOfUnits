using System;

namespace SystemOfUnits.DigitalInformation.Bit {
    public partial struct Kilobit {
        public static implicit operator Kilobit(Terabit self) => new Kilobit(self.Value * Math.Pow(10, 9));
        public static implicit operator Kilobit(Gigabit self) => new Kilobit(self.Value * Math.Pow(10, 6));
        public static implicit operator Kilobit(Megabit self) => new Kilobit(self.Value * Math.Pow(10, 3));
        public static implicit operator Kilobit(Bit self) => new Kilobit(self.Value * Math.Pow(10, -3));
    }
}
