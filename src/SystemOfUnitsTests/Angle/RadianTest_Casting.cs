using NUnit.Framework;

namespace SystemOfUnitsTests.Angle {
    using Radian = SystemOfUnits.Angle.Radian;

    partial class RadianTest {
        [TestCase(0d, 0d)]
        [TestCase(523.598775598299d, 0.523598775598299d)]
        [TestCase(785.398163397448d, 0.785398163397448d)]
        [TestCase(1047.1975511966d, 1.0471975511966d)]
        [TestCase(1570.7963267949d, 1.5707963267949d)]
        [TestCase(3141.59265358979d, 3.14159265358979d)]
        [TestCase(4712.38898038469d, 4.71238898038469d)]
        [TestCase(6283.18530717959d, 6.28318530717959d)]
        [TestCase(-3141.59265358979d, -3.14159265358979d)]
        public void Should_cast_from_Milliradian(double milliradianValue, double expectedValue) {
            var milliradianInstance = new SystemOfUnits.Angle.Milliradian(milliradianValue);

            Radian actual = milliradianInstance;
            Assert.IsAssignableFrom<Radian>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(30d, 0.523598775598299d)]
        [TestCase(45d, 0.785398163397448d)]
        [TestCase(60d, 1.0471975511966d)]
        [TestCase(90d, 1.5707963267949d)]
        [TestCase(180d, 3.14159265358979d)]
        [TestCase(270d, 4.71238898038469d)]
        [TestCase(360d, 6.28318530717959d)]
        [TestCase(-180d, -3.14159265358979d)]
        public void Should_cast_from_Degree(double degreeValue, double expectedValue) {
            var degreeInstance = new SystemOfUnits.Angle.Degree(degreeValue);

            Radian actual = degreeInstance;
            Assert.IsAssignableFrom<Radian>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
