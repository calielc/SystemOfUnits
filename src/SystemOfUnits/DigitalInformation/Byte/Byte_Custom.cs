namespace SystemOfUnits.DigitalInformation.Byte {
    using Bit = Bit.Bit;

    public partial struct Byte {
        public static implicit operator Byte(Bit self) => new Byte(self.Value / 8);
        public static implicit operator Bit(Byte self) => new Bit(self.Value * 8);
    }
}
