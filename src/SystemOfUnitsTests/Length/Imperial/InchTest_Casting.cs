using NUnit.Framework;

namespace SystemOfUnitsTests.Length.Imperial {
    using Inch = SystemOfUnits.Length.Imperial.Inch;

    partial class InchTest {
        [TestCase(0d, 0d)]
        [TestCase(0.0833333d, 1d)]
        [TestCase(0.833333d, 10d)]
        [TestCase(-0.0416667d, -0.5d)]
        public void Should_cast_from_Foot(double footValue, double expectedValue) {
            var footInstance = new SystemOfUnits.Length.Imperial.Foot(footValue);

            Inch actual = footInstance;
            Assert.IsAssignableFrom<Inch>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.0277778d, 1d)]
        [TestCase(0.277778d, 10d)]
        [TestCase(-0.0138889d, -0.5d)]
        public void Should_cast_from_Yard(double yardValue, double expectedValue) {
            var yardInstance = new SystemOfUnits.Length.Imperial.Yard(yardValue);

            Inch actual = yardInstance;
            Assert.IsAssignableFrom<Inch>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1.5783E-05d, 1d)]
        [TestCase(0.00015783d, 10d)]
        [TestCase(-7.8914204545E-06d, -0.5d)]
        public void Should_cast_from_Mile(double mileValue, double expectedValue) {
            var mileInstance = new SystemOfUnits.Length.Imperial.Mile(mileValue);

            Inch actual = mileInstance;
            Assert.IsAssignableFrom<Inch>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
