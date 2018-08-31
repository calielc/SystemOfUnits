using NUnit.Framework;

namespace SystemOfUnitsTests.Volume.Litre {
    using Millilitre = SystemOfUnits.Volume.Litre.Millilitre;

    partial class MillilitreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+006)]
        public void Should_cast_from_Kilolitre(double kilolitreValue, double expectedValue) {
            var kilolitreInstance = new SystemOfUnits.Volume.Litre.Kilolitre(kilolitreValue);

            Millilitre actual = kilolitreInstance;
            Assert.IsAssignableFrom<Millilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+005)]
        public void Should_cast_from_Hectolitre(double hectolitreValue, double expectedValue) {
            var hectolitreInstance = new SystemOfUnits.Volume.Litre.Hectolitre(hectolitreValue);

            Millilitre actual = hectolitreInstance;
            Assert.IsAssignableFrom<Millilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+004)]
        public void Should_cast_from_Decalitre(double decalitreValue, double expectedValue) {
            var decalitreInstance = new SystemOfUnits.Volume.Litre.Decalitre(decalitreValue);

            Millilitre actual = decalitreInstance;
            Assert.IsAssignableFrom<Millilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+003)]
        public void Should_cast_from_Litre(double litreValue, double expectedValue) {
            var litreInstance = new SystemOfUnits.Volume.Litre.Litre(litreValue);

            Millilitre actual = litreInstance;
            Assert.IsAssignableFrom<Millilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+002)]
        public void Should_cast_from_Decilitre(double decilitreValue, double expectedValue) {
            var decilitreInstance = new SystemOfUnits.Volume.Litre.Decilitre(decilitreValue);

            Millilitre actual = decilitreInstance;
            Assert.IsAssignableFrom<Millilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+001)]
        public void Should_cast_from_Centilitre(double centilitreValue, double expectedValue) {
            var centilitreInstance = new SystemOfUnits.Volume.Litre.Centilitre(centilitreValue);

            Millilitre actual = centilitreInstance;
            Assert.IsAssignableFrom<Millilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
