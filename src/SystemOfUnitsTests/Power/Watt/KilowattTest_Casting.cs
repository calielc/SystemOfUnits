using NUnit.Framework;

namespace SystemOfUnitsTests.Power.Watt {
    using Kilowatt = SystemOfUnits.Power.Watt.Kilowatt;

    partial class KilowattTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+005)]
        public void Should_cast_from_Hectowatt(double hectowattValue, double expectedValue) {
            var hectowattInstance = new SystemOfUnits.Power.Watt.Hectowatt(hectowattValue);

            Kilowatt actual = hectowattInstance;
            Assert.IsAssignableFrom<Kilowatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+004)]
        public void Should_cast_from_Decawatt(double decawattValue, double expectedValue) {
            var decawattInstance = new SystemOfUnits.Power.Watt.Decawatt(decawattValue);

            Kilowatt actual = decawattInstance;
            Assert.IsAssignableFrom<Kilowatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+003)]
        public void Should_cast_from_Watt(double wattValue, double expectedValue) {
            var wattInstance = new SystemOfUnits.Power.Watt.Watt(wattValue);

            Kilowatt actual = wattInstance;
            Assert.IsAssignableFrom<Kilowatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+002)]
        public void Should_cast_from_Deciwatt(double deciwattValue, double expectedValue) {
            var deciwattInstance = new SystemOfUnits.Power.Watt.Deciwatt(deciwattValue);

            Kilowatt actual = deciwattInstance;
            Assert.IsAssignableFrom<Kilowatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+001)]
        public void Should_cast_from_Centiwatt(double centiwattValue, double expectedValue) {
            var centiwattInstance = new SystemOfUnits.Power.Watt.Centiwatt(centiwattValue);

            Kilowatt actual = centiwattInstance;
            Assert.IsAssignableFrom<Kilowatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+000)]
        public void Should_cast_from_Milliwatt(double milliwattValue, double expectedValue) {
            var milliwattInstance = new SystemOfUnits.Power.Watt.Milliwatt(milliwattValue);

            Kilowatt actual = milliwattInstance;
            Assert.IsAssignableFrom<Kilowatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
