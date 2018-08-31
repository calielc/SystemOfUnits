using NUnit.Framework;

namespace SystemOfUnitsTests.Volume.Litre {
    using Decilitre = SystemOfUnits.Volume.Litre.Decilitre;

    partial class DecilitreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+006)]
        public void Should_cast_from_Kilolitre(double kilolitreValue, double expectedValue) {
            var kilolitreInstance = new SystemOfUnits.Volume.Litre.Kilolitre(kilolitreValue);

            Decilitre actual = kilolitreInstance;
            Assert.IsAssignableFrom<Decilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+005)]
        public void Should_cast_from_Hectolitre(double hectolitreValue, double expectedValue) {
            var hectolitreInstance = new SystemOfUnits.Volume.Litre.Hectolitre(hectolitreValue);

            Decilitre actual = hectolitreInstance;
            Assert.IsAssignableFrom<Decilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+004)]
        public void Should_cast_from_Decalitre(double decalitreValue, double expectedValue) {
            var decalitreInstance = new SystemOfUnits.Volume.Litre.Decalitre(decalitreValue);

            Decilitre actual = decalitreInstance;
            Assert.IsAssignableFrom<Decilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+003)]
        public void Should_cast_from_Litre(double litreValue, double expectedValue) {
            var litreInstance = new SystemOfUnits.Volume.Litre.Litre(litreValue);

            Decilitre actual = litreInstance;
            Assert.IsAssignableFrom<Decilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+001)]
        public void Should_cast_from_Centilitre(double centilitreValue, double expectedValue) {
            var centilitreInstance = new SystemOfUnits.Volume.Litre.Centilitre(centilitreValue);

            Decilitre actual = centilitreInstance;
            Assert.IsAssignableFrom<Decilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+000)]
        public void Should_cast_from_Millilitre(double millilitreValue, double expectedValue) {
            var millilitreInstance = new SystemOfUnits.Volume.Litre.Millilitre(millilitreValue);

            Decilitre actual = millilitreInstance;
            Assert.IsAssignableFrom<Decilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
