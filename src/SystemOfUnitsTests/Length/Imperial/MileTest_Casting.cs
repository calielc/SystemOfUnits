using NUnit.Framework;

namespace SystemOfUnitsTests.Length.Imperial {
    using Mile = SystemOfUnits.Length.Imperial.Mile;

    partial class MileTest {
        [TestCase(0d, 0d)]
        [TestCase(63360d, 1d)]
        [TestCase(633600d, 10d)]
        [TestCase(-31680d, -0.5d)]
        public void Should_cast_from_Inch(double inchValue, double expectedValue) {
            var inchInstance = new SystemOfUnits.Length.Imperial.Inch(inchValue);

            Mile actual = inchInstance;
            Assert.IsAssignableFrom<Mile>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(5280d, 1d)]
        [TestCase(52800d, 10d)]
        [TestCase(-2640d, -0.5d)]
        public void Should_cast_from_Foot(double footValue, double expectedValue) {
            var footInstance = new SystemOfUnits.Length.Imperial.Foot(footValue);

            Mile actual = footInstance;
            Assert.IsAssignableFrom<Mile>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1760d, 1d)]
        [TestCase(17600d, 10d)]
        [TestCase(-880d, -0.5d)]
        public void Should_cast_from_Yard(double yardValue, double expectedValue) {
            var yardInstance = new SystemOfUnits.Length.Imperial.Yard(yardValue);

            Mile actual = yardInstance;
            Assert.IsAssignableFrom<Mile>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
