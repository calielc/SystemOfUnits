using NUnit.Framework;

namespace SystemOfUnitsTests.Volume.Litre {
    using Hectolitre = SystemOfUnits.Volume.Litre.Hectolitre;

    partial class HectolitreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+006)]
        public void Should_cast_from_Kilolitre(double kilolitreValue, double expectedValue) {
            var kilolitreInstance = new SystemOfUnits.Volume.Litre.Kilolitre(kilolitreValue);

            Hectolitre actual = kilolitreInstance;
            Assert.IsAssignableFrom<Hectolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+004)]
        public void Should_cast_from_Decalitre(double decalitreValue, double expectedValue) {
            var decalitreInstance = new SystemOfUnits.Volume.Litre.Decalitre(decalitreValue);

            Hectolitre actual = decalitreInstance;
            Assert.IsAssignableFrom<Hectolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+003)]
        public void Should_cast_from_Litre(double litreValue, double expectedValue) {
            var litreInstance = new SystemOfUnits.Volume.Litre.Litre(litreValue);

            Hectolitre actual = litreInstance;
            Assert.IsAssignableFrom<Hectolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+002)]
        public void Should_cast_from_Decilitre(double decilitreValue, double expectedValue) {
            var decilitreInstance = new SystemOfUnits.Volume.Litre.Decilitre(decilitreValue);

            Hectolitre actual = decilitreInstance;
            Assert.IsAssignableFrom<Hectolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+001)]
        public void Should_cast_from_Centilitre(double centilitreValue, double expectedValue) {
            var centilitreInstance = new SystemOfUnits.Volume.Litre.Centilitre(centilitreValue);

            Hectolitre actual = centilitreInstance;
            Assert.IsAssignableFrom<Hectolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+000)]
        public void Should_cast_from_Millilitre(double millilitreValue, double expectedValue) {
            var millilitreInstance = new SystemOfUnits.Volume.Litre.Millilitre(millilitreValue);

            Hectolitre actual = millilitreInstance;
            Assert.IsAssignableFrom<Hectolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
