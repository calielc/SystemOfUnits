using NUnit.Framework;

namespace SystemOfUnitsTests.Mass.Gram {
    using Decigram = SystemOfUnits.Mass.Gram.Decigram;

    partial class DecigramTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+006)]
        public void Should_cast_from_Kilogram(double kilogramValue, double expectedValue) {
            var kilogramInstance = new SystemOfUnits.Mass.Gram.Kilogram(kilogramValue);

            Decigram actual = kilogramInstance;
            Assert.IsAssignableFrom<Decigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+005)]
        public void Should_cast_from_Hectogram(double hectogramValue, double expectedValue) {
            var hectogramInstance = new SystemOfUnits.Mass.Gram.Hectogram(hectogramValue);

            Decigram actual = hectogramInstance;
            Assert.IsAssignableFrom<Decigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+004)]
        public void Should_cast_from_Decagram(double decagramValue, double expectedValue) {
            var decagramInstance = new SystemOfUnits.Mass.Gram.Decagram(decagramValue);

            Decigram actual = decagramInstance;
            Assert.IsAssignableFrom<Decigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+003)]
        public void Should_cast_from_Gram(double gramValue, double expectedValue) {
            var gramInstance = new SystemOfUnits.Mass.Gram.Gram(gramValue);

            Decigram actual = gramInstance;
            Assert.IsAssignableFrom<Decigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+001)]
        public void Should_cast_from_Centigram(double centigramValue, double expectedValue) {
            var centigramInstance = new SystemOfUnits.Mass.Gram.Centigram(centigramValue);

            Decigram actual = centigramInstance;
            Assert.IsAssignableFrom<Decigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+000)]
        public void Should_cast_from_Milligram(double milligramValue, double expectedValue) {
            var milligramInstance = new SystemOfUnits.Mass.Gram.Milligram(milligramValue);

            Decigram actual = milligramInstance;
            Assert.IsAssignableFrom<Decigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
