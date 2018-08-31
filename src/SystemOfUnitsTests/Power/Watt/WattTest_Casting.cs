using NUnit.Framework;

namespace SystemOfUnitsTests.Power.Watt {
    using Watt = SystemOfUnits.Power.Watt.Watt;

    partial class WattTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+006)]
        public void Should_cast_from_Kilowatt(double kilowattValue, double expectedValue) {
            var kilowattInstance = new SystemOfUnits.Power.Watt.Kilowatt(kilowattValue);

            Watt actual = kilowattInstance;
            Assert.IsAssignableFrom<Watt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+005)]
        public void Should_cast_from_Hectowatt(double hectowattValue, double expectedValue) {
            var hectowattInstance = new SystemOfUnits.Power.Watt.Hectowatt(hectowattValue);

            Watt actual = hectowattInstance;
            Assert.IsAssignableFrom<Watt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+004)]
        public void Should_cast_from_Decawatt(double decawattValue, double expectedValue) {
            var decawattInstance = new SystemOfUnits.Power.Watt.Decawatt(decawattValue);

            Watt actual = decawattInstance;
            Assert.IsAssignableFrom<Watt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+002)]
        public void Should_cast_from_Deciwatt(double deciwattValue, double expectedValue) {
            var deciwattInstance = new SystemOfUnits.Power.Watt.Deciwatt(deciwattValue);

            Watt actual = deciwattInstance;
            Assert.IsAssignableFrom<Watt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+001)]
        public void Should_cast_from_Centiwatt(double centiwattValue, double expectedValue) {
            var centiwattInstance = new SystemOfUnits.Power.Watt.Centiwatt(centiwattValue);

            Watt actual = centiwattInstance;
            Assert.IsAssignableFrom<Watt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+000)]
        public void Should_cast_from_Milliwatt(double milliwattValue, double expectedValue) {
            var milliwattInstance = new SystemOfUnits.Power.Watt.Milliwatt(milliwattValue);

            Watt actual = milliwattInstance;
            Assert.IsAssignableFrom<Watt>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
