using NUnit.Framework;
using SystemOfUnits.Length.Imperial;
using SystemOfUnits.Length.Metre;

namespace SystemOfUnitsTests.Length.Imperial {
    public partial class MileTest {
        [Test]
        public void Shouuld_have_const_to_kilometres() {
            const double expected = 1.609344d;

            Assert.AreEqual(expected, Mile.KilometresInAMile);
        }

        [TestCase(-3.75d, -6.03504d)]
        [TestCase(0d, 0d)]
        [TestCase(1d, 1.609344d)]
        [TestCase(2d, 3.218688d)]
        [TestCase(100.45, 161.6586048d)]
        public void Should_convert_to_kilometres(double miles, double expected) {
            var instance = new Mile(miles);

            Kilometre actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }

        [TestCase(-3.75d, -6.03504d)]
        [TestCase(0d, 0d)]
        [TestCase(1d, 1.609344d)]
        [TestCase(2d, 3.218688d)]
        [TestCase(100.45, 161.6586048d)]
        public void Should_convert_from_kilometres(double expected, double kilometres) {
            var instance = new Kilometre(kilometres);

            Mile actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }
    }
}