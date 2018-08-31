using NUnit.Framework;

namespace SystemOfUnitsTests.Angle {
    using Degree = SystemOfUnits.Angle.Degree;

    partial class DegreeTest {
        [TestCase(0d, 0d)]
        [TestCase(0.523598775598299d, 30d)]
        [TestCase(0.785398163397448d, 45d)]
        [TestCase(1.0471975511966d, 60d)]
        [TestCase(1.5707963267949d, 90d)]
        [TestCase(3.14159265358979d, 180d)]
        [TestCase(4.71238898038469d, 270d)]
        [TestCase(6.28318530717959d, 360d)]
        [TestCase(-3.14159265358979d, -180d)]
        public void Should_cast_from_Radian(double radianValue, double expectedValue) {
            var radianInstance = new SystemOfUnits.Angle.Radian(radianValue);

            Degree actual = radianInstance;
            Assert.IsAssignableFrom<Degree>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(523.598775598299d, 30d)]
        [TestCase(785.398163397448d, 45d)]
        [TestCase(1047.1975511966d, 60d)]
        [TestCase(1570.7963267949d, 90d)]
        [TestCase(3141.59265358979d, 180d)]
        [TestCase(4712.38898038469d, 270d)]
        [TestCase(6283.18530717959d, 360d)]
        [TestCase(-3141.59265358979d, -180d)]
        public void Should_cast_from_Milliradian(double milliradianValue, double expectedValue) {
            var milliradianInstance = new SystemOfUnits.Angle.Milliradian(milliradianValue);

            Degree actual = milliradianInstance;
            Assert.IsAssignableFrom<Degree>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
