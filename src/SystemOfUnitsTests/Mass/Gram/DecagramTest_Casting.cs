using NUnit.Framework;

namespace SystemOfUnitsTests.Mass.Gram {
    using Decagram = SystemOfUnits.Mass.Gram.Decagram;

    partial class DecagramTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+006)]
        public void Should_cast_from_Kilogram(double kilogramValue, double expectedValue) {
            var kilogramInstance = new SystemOfUnits.Mass.Gram.Kilogram(kilogramValue);

            Decagram actual = kilogramInstance;
            Assert.IsAssignableFrom<Decagram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+005)]
        public void Should_cast_from_Hectogram(double hectogramValue, double expectedValue) {
            var hectogramInstance = new SystemOfUnits.Mass.Gram.Hectogram(hectogramValue);

            Decagram actual = hectogramInstance;
            Assert.IsAssignableFrom<Decagram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+003)]
        public void Should_cast_from_Gram(double gramValue, double expectedValue) {
            var gramInstance = new SystemOfUnits.Mass.Gram.Gram(gramValue);

            Decagram actual = gramInstance;
            Assert.IsAssignableFrom<Decagram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+002)]
        public void Should_cast_from_Decigram(double decigramValue, double expectedValue) {
            var decigramInstance = new SystemOfUnits.Mass.Gram.Decigram(decigramValue);

            Decagram actual = decigramInstance;
            Assert.IsAssignableFrom<Decagram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+001)]
        public void Should_cast_from_Centigram(double centigramValue, double expectedValue) {
            var centigramInstance = new SystemOfUnits.Mass.Gram.Centigram(centigramValue);

            Decagram actual = centigramInstance;
            Assert.IsAssignableFrom<Decagram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+000)]
        public void Should_cast_from_Milligram(double milligramValue, double expectedValue) {
            var milligramInstance = new SystemOfUnits.Mass.Gram.Milligram(milligramValue);

            Decagram actual = milligramInstance;
            Assert.IsAssignableFrom<Decagram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
