using NUnit.Framework;

namespace SystemOfUnitsTests.Length.Imperial {
    using Yard = SystemOfUnits.Length.Imperial.Yard;

    partial class YardTest {
        [TestCase(0d, 0d)]
        [TestCase(36d, 1d)]
        [TestCase(360d, 10d)]
        [TestCase(-18d, -0.5d)]
        public void Should_cast_from_Inch(double inchValue, double expectedValue) {
            var inchInstance = new SystemOfUnits.Length.Imperial.Inch(inchValue);

            Yard actual = inchInstance;
            Assert.IsAssignableFrom<Yard>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(3d, 1d)]
        [TestCase(30d, 10d)]
        [TestCase(-1.5d, -0.5d)]
        public void Should_cast_from_Foot(double footValue, double expectedValue) {
            var footInstance = new SystemOfUnits.Length.Imperial.Foot(footValue);

            Yard actual = footInstance;
            Assert.IsAssignableFrom<Yard>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.000568182d, 1d)]
        [TestCase(0.00568182d, 10d)]
        [TestCase(-0.000284091d, -0.5d)]
        public void Should_cast_from_Mile(double mileValue, double expectedValue) {
            var mileInstance = new SystemOfUnits.Length.Imperial.Mile(mileValue);

            Yard actual = mileInstance;
            Assert.IsAssignableFrom<Yard>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
