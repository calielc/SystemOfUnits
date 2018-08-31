using NUnit.Framework;

namespace SystemOfUnitsTests.Power.Watt {
    using Centiwatt = SystemOfUnits.Power.Watt.Centiwatt;

    partial class CentiwattTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+006)]
        public void Should_cast_from_Kilowatt(double kilowattValue, double expectedValue) {
            var kilowattInstance = new SystemOfUnits.Power.Watt.Kilowatt(kilowattValue);

            Centiwatt actual = kilowattInstance;
            Assert.IsAssignableFrom<Centiwatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+005)]
        public void Should_cast_from_Hectowatt(double hectowattValue, double expectedValue) {
            var hectowattInstance = new SystemOfUnits.Power.Watt.Hectowatt(hectowattValue);

            Centiwatt actual = hectowattInstance;
            Assert.IsAssignableFrom<Centiwatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+004)]
        public void Should_cast_from_Decawatt(double decawattValue, double expectedValue) {
            var decawattInstance = new SystemOfUnits.Power.Watt.Decawatt(decawattValue);

            Centiwatt actual = decawattInstance;
            Assert.IsAssignableFrom<Centiwatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+003)]
        public void Should_cast_from_Watt(double wattValue, double expectedValue) {
            var wattInstance = new SystemOfUnits.Power.Watt.Watt(wattValue);

            Centiwatt actual = wattInstance;
            Assert.IsAssignableFrom<Centiwatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+002)]
        public void Should_cast_from_Deciwatt(double deciwattValue, double expectedValue) {
            var deciwattInstance = new SystemOfUnits.Power.Watt.Deciwatt(deciwattValue);

            Centiwatt actual = deciwattInstance;
            Assert.IsAssignableFrom<Centiwatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+000)]
        public void Should_cast_from_Milliwatt(double milliwattValue, double expectedValue) {
            var milliwattInstance = new SystemOfUnits.Power.Watt.Milliwatt(milliwattValue);

            Centiwatt actual = milliwattInstance;
            Assert.IsAssignableFrom<Centiwatt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
