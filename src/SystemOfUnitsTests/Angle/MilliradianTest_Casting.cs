using NUnit.Framework;

namespace SystemOfUnitsTests.Angle {
    using Milliradian = SystemOfUnits.Angle.Milliradian;

    partial class MilliradianTest {
        [TestCase(0d, 0d)]
        [TestCase(0.523598775598299d, 523.598775598299d)]
        [TestCase(0.785398163397448d, 785.398163397448d)]
        [TestCase(1.0471975511966d, 1047.1975511966d)]
        [TestCase(1.5707963267949d, 1570.7963267949d)]
        [TestCase(3.14159265358979d, 3141.59265358979d)]
        [TestCase(4.71238898038469d, 4712.38898038469d)]
        [TestCase(6.28318530717959d, 6283.18530717959d)]
        [TestCase(-3.14159265358979d, -3141.59265358979d)]
        public void Should_cast_from_Radian(double radianValue, double expectedValue) {
            var radianInstance = new SystemOfUnits.Angle.Radian(radianValue);

            Milliradian actual = radianInstance;
            Assert.IsAssignableFrom<Milliradian>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(30d, 523.598775598299d)]
        [TestCase(45d, 785.398163397448d)]
        [TestCase(60d, 1047.1975511966d)]
        [TestCase(90d, 1570.7963267949d)]
        [TestCase(180d, 3141.59265358979d)]
        [TestCase(270d, 4712.38898038469d)]
        [TestCase(360d, 6283.18530717959d)]
        [TestCase(-180d, -3141.59265358979d)]
        public void Should_cast_from_Degree(double degreeValue, double expectedValue) {
            var degreeInstance = new SystemOfUnits.Angle.Degree(degreeValue);

            Milliradian actual = degreeInstance;
            Assert.IsAssignableFrom<Milliradian>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
