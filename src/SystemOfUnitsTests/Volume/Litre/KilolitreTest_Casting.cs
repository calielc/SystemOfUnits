using NUnit.Framework;

namespace SystemOfUnitsTests.Volume.Litre {
    using Kilolitre = SystemOfUnits.Volume.Litre.Kilolitre;

    partial class KilolitreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+005)]
        public void Should_cast_from_Hectolitre(double hectolitreValue, double expectedValue) {
            var hectolitreInstance = new SystemOfUnits.Volume.Litre.Hectolitre(hectolitreValue);

            Kilolitre actual = hectolitreInstance;
            Assert.IsAssignableFrom<Kilolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+004)]
        public void Should_cast_from_Decalitre(double decalitreValue, double expectedValue) {
            var decalitreInstance = new SystemOfUnits.Volume.Litre.Decalitre(decalitreValue);

            Kilolitre actual = decalitreInstance;
            Assert.IsAssignableFrom<Kilolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+003)]
        public void Should_cast_from_Litre(double litreValue, double expectedValue) {
            var litreInstance = new SystemOfUnits.Volume.Litre.Litre(litreValue);

            Kilolitre actual = litreInstance;
            Assert.IsAssignableFrom<Kilolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+002)]
        public void Should_cast_from_Decilitre(double decilitreValue, double expectedValue) {
            var decilitreInstance = new SystemOfUnits.Volume.Litre.Decilitre(decilitreValue);

            Kilolitre actual = decilitreInstance;
            Assert.IsAssignableFrom<Kilolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+001)]
        public void Should_cast_from_Centilitre(double centilitreValue, double expectedValue) {
            var centilitreInstance = new SystemOfUnits.Volume.Litre.Centilitre(centilitreValue);

            Kilolitre actual = centilitreInstance;
            Assert.IsAssignableFrom<Kilolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+000)]
        public void Should_cast_from_Millilitre(double millilitreValue, double expectedValue) {
            var millilitreInstance = new SystemOfUnits.Volume.Litre.Millilitre(millilitreValue);

            Kilolitre actual = millilitreInstance;
            Assert.IsAssignableFrom<Kilolitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
