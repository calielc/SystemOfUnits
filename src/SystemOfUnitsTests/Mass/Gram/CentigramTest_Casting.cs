using NUnit.Framework;

namespace SystemOfUnitsTests.Mass.Gram {
    using Centigram = SystemOfUnits.Mass.Gram.Centigram;

    partial class CentigramTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+006)]
        public void Should_cast_from_Kilogram(double kilogramValue, double expectedValue) {
            var kilogramInstance = new SystemOfUnits.Mass.Gram.Kilogram(kilogramValue);

            Centigram actual = kilogramInstance;
            Assert.IsAssignableFrom<Centigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+005)]
        public void Should_cast_from_Hectogram(double hectogramValue, double expectedValue) {
            var hectogramInstance = new SystemOfUnits.Mass.Gram.Hectogram(hectogramValue);

            Centigram actual = hectogramInstance;
            Assert.IsAssignableFrom<Centigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+004)]
        public void Should_cast_from_Decagram(double decagramValue, double expectedValue) {
            var decagramInstance = new SystemOfUnits.Mass.Gram.Decagram(decagramValue);

            Centigram actual = decagramInstance;
            Assert.IsAssignableFrom<Centigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+003)]
        public void Should_cast_from_Gram(double gramValue, double expectedValue) {
            var gramInstance = new SystemOfUnits.Mass.Gram.Gram(gramValue);

            Centigram actual = gramInstance;
            Assert.IsAssignableFrom<Centigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+002)]
        public void Should_cast_from_Decigram(double decigramValue, double expectedValue) {
            var decigramInstance = new SystemOfUnits.Mass.Gram.Decigram(decigramValue);

            Centigram actual = decigramInstance;
            Assert.IsAssignableFrom<Centigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+000)]
        public void Should_cast_from_Milligram(double milligramValue, double expectedValue) {
            var milligramInstance = new SystemOfUnits.Mass.Gram.Milligram(milligramValue);

            Centigram actual = milligramInstance;
            Assert.IsAssignableFrom<Centigram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
