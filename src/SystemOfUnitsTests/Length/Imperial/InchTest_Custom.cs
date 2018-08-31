using NUnit.Framework;
using SystemOfUnits.Length.Imperial;
using SystemOfUnits.Length.Metre;

namespace SystemOfUnitsTests.Length.Imperial {
    public partial class InchTest {
        [Test]
        public void Shouuld_have_const_to_centimetres() {
            const double expected = 2.54d;

            Assert.AreEqual(expected, Inch.CentimetresInAnInch);
        }

        [TestCase(-3.75d, -9.525d)]
        [TestCase(0d, 0d)]
        [TestCase(1d, 2.54d)]
        [TestCase(2d, 5.08d)]
        [TestCase(100.45, 255.143d)]
        public void Should_convert_to_centimetres(double inches, double expected) {
            var instance = new Inch(inches);

            Centimetre actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }

        [TestCase(-3.75d, -9.525d)]
        [TestCase(0d, 0d)]
        [TestCase(1d, 2.54d)]
        [TestCase(2d, 5.08d)]
        [TestCase(100.45, 255.143d)]
        public void Should_convert_from_centimetres(double expected, double centimetres) {
            var instance = new Centimetre(centimetres);

            Inch actual = instance;

            Assert.AreEqual(expected, actual.Value, Consts.DeltaAssert);
        }
    }
}