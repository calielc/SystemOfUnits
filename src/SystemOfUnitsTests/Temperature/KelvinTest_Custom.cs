using NUnit.Framework;
using SystemOfUnits.Temperature;

namespace SystemOfUnitsTests.Temperature {
    public partial class KelvinTest {
        [Test]
        public void Should_have_absolute_zero() {
            var expected = new Kelvin(0);

            var actual = Kelvin.AbsoluteZero;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3.75d)]
        [TestCase(0d)]
        [TestCase(1d)]
        [TestCase(2d)]
        [TestCase(100.45d)]
        [TestCase(227.328d)]
        public void Should_convert_to_international_system(double value) {
            var expected = new Kelvin(value);

            var actual = (expected as ITemperatureUnit).ToKelvin();

            Assert.AreEqual(expected, actual);
        }
    }
}