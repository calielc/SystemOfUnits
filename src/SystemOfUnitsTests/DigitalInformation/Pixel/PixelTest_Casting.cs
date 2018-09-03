using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Pixel {
    using Pixel = SystemOfUnits.DigitalInformation.Pixel.Pixel;

    partial class PixelTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-012,  1.000000000000000e-006)]
        public void Should_cast_from_Megapixel(double megapixelValue, double expectedValue) {
            var megapixelInstance = new SystemOfUnits.DigitalInformation.Pixel.Megapixel(megapixelValue);

            Pixel actual = megapixelInstance;
            Assert.IsAssignableFrom<Pixel>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
