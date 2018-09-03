using System;

namespace SystemOfUnits.DigitalInformation.Pixel {
    public partial struct Megapixel {
        public static implicit operator Megapixel(Pixel self) => new Megapixel(self.Value * Math.Pow(10, -6));
    }
}
