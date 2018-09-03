using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Pixel {
    using Megapixel = SystemOfUnits.DigitalInformation.Pixel.Megapixel;

    partial class MegapixelTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-006)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-012)]
        public void Should_cast_from_Pixel(double pixelValue, double expectedValue) {
            var pixelInstance = new SystemOfUnits.DigitalInformation.Pixel.Pixel(pixelValue);

            Megapixel actual = pixelInstance;
            Assert.IsAssignableFrom<Megapixel>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
