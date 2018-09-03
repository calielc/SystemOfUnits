using System;

namespace SystemOfUnits.DigitalInformation.Pixel {
    public partial struct Pixel {
        public static implicit operator Pixel(Megapixel self) => new Pixel(self.Value * Math.Pow(10, 6));
    }
}
