using NUnit.Framework;
using SystemOfUnits.Temperature;

namespace SystemOfUnitsTests.Temperature {
    public partial class FahrenheitTest {
        [Test]
        public void Should_have_absolute_zero() {
            var expected = new Fahrenheit(-459.67d);

            var actual = Fahrenheit.AbsoluteZero;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3.75d)]
        [TestCase(0d)]
        [TestCase(1d)]
        [TestCase(2d)]
        [TestCase(100.45d)]
        [TestCase(227.328d)]
        public void Should_convert_to_international_system(double value) {
            var fahrenheit = new Fahrenheit(value);
            var expected = (Kelvin)fahrenheit;

            var actual = (fahrenheit as ITemperatureUnit).ToKelvin();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-3.75d, 253.2889d)]
        [TestCase(0d, 255.372d)]
        [TestCase(1d, 255.928d)]
        [TestCase(2d, 256.483d)]
        [TestCase(100.45d, 311.177778d)]
        public void Should_convert_to_Kelvin(double fahrenheit, double expected) {
            var instance = new Fahrenheit(fahrenheit);

            Kelvin actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }

        [TestCase(-3.75d, -466.42d)]
        [TestCase(0d, -459.67d)]
        [TestCase(1d, -457.87d)]
        [TestCase(2d, -456.07d)]
        [TestCase(100.45d, -278.86d)]
        [TestCase(500.478d, 441.1904d)]
        public void Should_convert_from_Kelvin(double kelvin, double expected) {
            var instance = new Kelvin(kelvin);

            Fahrenheit actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }

        [TestCase(0d, -17.7778d)]
        [TestCase(50d, 10d)]
        [TestCase(100d, 37.7778d)]
        public void Should_convert_to_Celsius(double fahrenheit, double expected) {
            var instance = new Fahrenheit(fahrenheit);

            Celsius actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }

        [TestCase(-25, -13)]
        [TestCase(0d, 32d)]
        [TestCase(50, 122d)]
        public void Should_convert_from_Celsius(double celsius, double expected) {
            var instance = new Celsius(celsius);

            Fahrenheit actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }
    }
}