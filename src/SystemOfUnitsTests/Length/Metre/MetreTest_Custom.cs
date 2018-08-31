using NUnit.Framework;

namespace SystemOfUnitsTests.Length.Metre {
    using CubicMetre = SystemOfUnits.Volume.CubicMetre.CubicMetre;
    using Metre = SystemOfUnits.Length.Metre.Metre;
    using SquareMetre = SystemOfUnits.Area.SquareMetre.SquareMetre;

    public partial class MetreTest {
        [TestCase(0d, 0d, 0d)]
        [TestCase(0d, 56d, 0d)]
        [TestCase(56d, 0, 0d)]
        [TestCase(45.75, 12.75, 583.3125d)]
        [TestCase(45.75, -12.75, -583.3125d)]
        [TestCase(-12.75, 45.75, -583.3125)]
        [TestCase(30.13, 0.27, 8.1351)]
        public void Should_multiply_instance_by_instance(double leftValue, double rightValue, double expectedValue) {
            var expected = new SquareMetre(expectedValue);

            var leftInstance = new Metre(leftValue);
            var rightInstance = new Metre(rightValue);
            var actual = leftInstance * rightInstance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, 0d, 0d)]
        [TestCase(0d, 56d, 0d)]
        [TestCase(56d, 0, 0d)]
        [TestCase(45.75, 12.75, 583.3125d)]
        [TestCase(45.75, -12.75, -583.3125d)]
        [TestCase(-12.75, 45.75, -583.3125)]
        [TestCase(30.13, 0.27, 8.1351)]
        public void Should_multiply_instance_by_squareMetre(double leftValue, double rightValue, double expectedValue) {
            var expected = new CubicMetre(expectedValue);

            var leftInstance = new Metre(leftValue);
            var rightInstance = new SquareMetre(rightValue);
            var actual = leftInstance * rightInstance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, 0d, 0d)]
        [TestCase(0d, 56d, 0d)]
        [TestCase(56d, 0, 0d)]
        [TestCase(45.75, 12.75, 583.3125d)]
        [TestCase(45.75, -12.75, -583.3125d)]
        [TestCase(-12.75, 45.75, -583.3125)]
        [TestCase(30.13, 0.27, 8.1351)]
        public void Should_multiply_squareMetre_by_instance(double leftValue, double rightValue, double expectedValue) {
            var expected = new CubicMetre(expectedValue);

            var leftInstance = new SquareMetre(leftValue);
            var rightInstance = new Metre(rightValue);
            var actual = leftInstance * rightInstance;

            Assert.AreEqual(expected, actual);
        }
    }
}