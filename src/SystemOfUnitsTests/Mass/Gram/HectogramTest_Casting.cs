using NUnit.Framework;

namespace SystemOfUnitsTests.Mass.Gram {
    using Hectogram = SystemOfUnits.Mass.Gram.Hectogram;

    partial class HectogramTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+006)]
        public void Should_cast_from_Kilogram(double kilogramValue, double expectedValue) {
            var kilogramInstance = new SystemOfUnits.Mass.Gram.Kilogram(kilogramValue);

            Hectogram actual = kilogramInstance;
            Assert.IsAssignableFrom<Hectogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+004)]
        public void Should_cast_from_Decagram(double decagramValue, double expectedValue) {
            var decagramInstance = new SystemOfUnits.Mass.Gram.Decagram(decagramValue);

            Hectogram actual = decagramInstance;
            Assert.IsAssignableFrom<Hectogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+003)]
        public void Should_cast_from_Gram(double gramValue, double expectedValue) {
            var gramInstance = new SystemOfUnits.Mass.Gram.Gram(gramValue);

            Hectogram actual = gramInstance;
            Assert.IsAssignableFrom<Hectogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+002)]
        public void Should_cast_from_Decigram(double decigramValue, double expectedValue) {
            var decigramInstance = new SystemOfUnits.Mass.Gram.Decigram(decigramValue);

            Hectogram actual = decigramInstance;
            Assert.IsAssignableFrom<Hectogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+001)]
        public void Should_cast_from_Centigram(double centigramValue, double expectedValue) {
            var centigramInstance = new SystemOfUnits.Mass.Gram.Centigram(centigramValue);

            Hectogram actual = centigramInstance;
            Assert.IsAssignableFrom<Hectogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+000)]
        public void Should_cast_from_Milligram(double milligramValue, double expectedValue) {
            var milligramInstance = new SystemOfUnits.Mass.Gram.Milligram(milligramValue);

            Hectogram actual = milligramInstance;
            Assert.IsAssignableFrom<Hectogram>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
