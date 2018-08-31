using NUnit.Framework;

namespace SystemOfUnitsTests.Length.Imperial {
    using Foot = SystemOfUnits.Length.Imperial.Foot;

    partial class FootTest {
        [TestCase(0d, 0d)]
        [TestCase(12d, 1d)]
        [TestCase(120d, 10d)]
        [TestCase(-6d, -0.5d)]
        public void Should_cast_from_Inch(double inchValue, double expectedValue) {
            var inchInstance = new SystemOfUnits.Length.Imperial.Inch(inchValue);

            Foot actual = inchInstance;
            Assert.IsAssignableFrom<Foot>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.333333d, 1d)]
        [TestCase(3.33333d, 10d)]
        [TestCase(-0.166667d, -0.5d)]
        public void Should_cast_from_Yard(double yardValue, double expectedValue) {
            var yardInstance = new SystemOfUnits.Length.Imperial.Yard(yardValue);

            Foot actual = yardInstance;
            Assert.IsAssignableFrom<Foot>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.000189394d, 1d)]
        [TestCase(0.00189394d, 10d)]
        [TestCase(-9.4697E-05d, -0.5d)]
        public void Should_cast_from_Mile(double mileValue, double expectedValue) {
            var mileInstance = new SystemOfUnits.Length.Imperial.Mile(mileValue);

            Foot actual = mileInstance;
            Assert.IsAssignableFrom<Foot>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
