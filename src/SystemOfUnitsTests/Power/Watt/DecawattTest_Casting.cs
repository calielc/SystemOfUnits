using NUnit.Framework;

namespace SystemOfUnitsTests.Power.Watt {
    using Decawatt = SystemOfUnits.Power.Watt.Decawatt;

    partial class DecawattTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+006)]
        public void Should_cast_from_Kilowatt(double kilowattValue, double expectedValue) {
            var kilowattInstance = new SystemOfUnits.Power.Watt.Kilowatt(kilowattValue);

            Decawatt actual = kilowattInstance;
            Assert.IsAssignableFrom<Decawatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+005)]
        public void Should_cast_from_Hectowatt(double hectowattValue, double expectedValue) {
            var hectowattInstance = new SystemOfUnits.Power.Watt.Hectowatt(hectowattValue);

            Decawatt actual = hectowattInstance;
            Assert.IsAssignableFrom<Decawatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+003)]
        public void Should_cast_from_Watt(double wattValue, double expectedValue) {
            var wattInstance = new SystemOfUnits.Power.Watt.Watt(wattValue);

            Decawatt actual = wattInstance;
            Assert.IsAssignableFrom<Decawatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+002)]
        public void Should_cast_from_Deciwatt(double deciwattValue, double expectedValue) {
            var deciwattInstance = new SystemOfUnits.Power.Watt.Deciwatt(deciwattValue);

            Decawatt actual = deciwattInstance;
            Assert.IsAssignableFrom<Decawatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+001)]
        public void Should_cast_from_Centiwatt(double centiwattValue, double expectedValue) {
            var centiwattInstance = new SystemOfUnits.Power.Watt.Centiwatt(centiwattValue);

            Decawatt actual = centiwattInstance;
            Assert.IsAssignableFrom<Decawatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+000)]
        public void Should_cast_from_Milliwatt(double milliwattValue, double expectedValue) {
            var milliwattInstance = new SystemOfUnits.Power.Watt.Milliwatt(milliwattValue);

            Decawatt actual = milliwattInstance;
            Assert.IsAssignableFrom<Decawatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
