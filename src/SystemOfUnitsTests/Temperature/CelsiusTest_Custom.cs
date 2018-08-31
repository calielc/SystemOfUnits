using NUnit.Framework;
using SystemOfUnits.Temperature;

namespace SystemOfUnitsTests.Temperature {
    public partial class CelsiusTest {
        [Test]
        public void Should_have_absolute_zero() {
            var expected = new Celsius(-273.15d);

            var actual = Celsius.AbsoluteZero;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3.75d)]
        [TestCase(0d)]
        [TestCase(1d)]
        [TestCase(2d)]
        [TestCase(100.45d)]
        [TestCase(227.328d)]
        public void Should_convert_to_international_system(double value) {
            var celsius = new Celsius(value);
            var expected = (Kelvin)celsius;

            var actual = (celsius as ITemperatureUnit).ToKelvin();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3.75d, 269.4d)]
        [TestCase(0d, 273.15d)]
        [TestCase(1d, 274.15d)]
        [TestCase(2d, 275.15d)]
        [TestCase(100.45d, 373.6d)]
        public void Should_convert_to_kelvin(double celsius, double expected) {
            var instance = new Celsius(celsius);

            Kelvin actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }

        [TestCase(-3.75d, -276.9d)]
        [TestCase(0d, -273.15d)]
        [TestCase(1d, -272.15d)]
        [TestCase(2d, -271.15d)]
        [TestCase(100.45d, -172.7d)]
        [TestCase(500.478d, 227.328d)]
        public void Should_convert_from_kelvin(double kelvin, double expected) {
            var instance = new Kelvin(kelvin);

            Celsius actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }
    }
}