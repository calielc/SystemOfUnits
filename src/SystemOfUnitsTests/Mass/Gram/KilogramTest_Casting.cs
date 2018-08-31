using NUnit.Framework;

namespace SystemOfUnitsTests.Mass.Gram {
    using Kilogram = SystemOfUnits.Mass.Gram.Kilogram;

    partial class KilogramTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+005)]
        public void Should_cast_from_Hectogram(double hectogramValue, double expectedValue) {
            var hectogramInstance = new SystemOfUnits.Mass.Gram.Hectogram(hectogramValue);

            Kilogram actual = hectogramInstance;
            Assert.IsAssignableFrom<Kilogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+004)]
        public void Should_cast_from_Decagram(double decagramValue, double expectedValue) {
            var decagramInstance = new SystemOfUnits.Mass.Gram.Decagram(decagramValue);

            Kilogram actual = decagramInstance;
            Assert.IsAssignableFrom<Kilogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+003)]
        public void Should_cast_from_Gram(double gramValue, double expectedValue) {
            var gramInstance = new SystemOfUnits.Mass.Gram.Gram(gramValue);

            Kilogram actual = gramInstance;
            Assert.IsAssignableFrom<Kilogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+002)]
        public void Should_cast_from_Decigram(double decigramValue, double expectedValue) {
            var decigramInstance = new SystemOfUnits.Mass.Gram.Decigram(decigramValue);

            Kilogram actual = decigramInstance;
            Assert.IsAssignableFrom<Kilogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+001)]
        public void Should_cast_from_Centigram(double centigramValue, double expectedValue) {
            var centigramInstance = new SystemOfUnits.Mass.Gram.Centigram(centigramValue);

            Kilogram actual = centigramInstance;
            Assert.IsAssignableFrom<Kilogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+000)]
        public void Should_cast_from_Milligram(double milligramValue, double expectedValue) {
            var milligramInstance = new SystemOfUnits.Mass.Gram.Milligram(milligramValue);

            Kilogram actual = milligramInstance;
            Assert.IsAssignableFrom<Kilogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
