using NUnit.Framework;

namespace SystemOfUnitsTests.Volume.Litre {
    using Centilitre = SystemOfUnits.Volume.Litre.Centilitre;

    partial class CentilitreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+006)]
        public void Should_cast_from_Kilolitre(double kilolitreValue, double expectedValue) {
            var kilolitreInstance = new SystemOfUnits.Volume.Litre.Kilolitre(kilolitreValue);

            Centilitre actual = kilolitreInstance;
            Assert.IsAssignableFrom<Centilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+005)]
        public void Should_cast_from_Hectolitre(double hectolitreValue, double expectedValue) {
            var hectolitreInstance = new SystemOfUnits.Volume.Litre.Hectolitre(hectolitreValue);

            Centilitre actual = hectolitreInstance;
            Assert.IsAssignableFrom<Centilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+004)]
        public void Should_cast_from_Decalitre(double decalitreValue, double expectedValue) {
            var decalitreInstance = new SystemOfUnits.Volume.Litre.Decalitre(decalitreValue);

            Centilitre actual = decalitreInstance;
            Assert.IsAssignableFrom<Centilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+003)]
        public void Should_cast_from_Litre(double litreValue, double expectedValue) {
            var litreInstance = new SystemOfUnits.Volume.Litre.Litre(litreValue);

            Centilitre actual = litreInstance;
            Assert.IsAssignableFrom<Centilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+002)]
        public void Should_cast_from_Decilitre(double decilitreValue, double expectedValue) {
            var decilitreInstance = new SystemOfUnits.Volume.Litre.Decilitre(decilitreValue);

            Centilitre actual = decilitreInstance;
            Assert.IsAssignableFrom<Centilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+000)]
        public void Should_cast_from_Millilitre(double millilitreValue, double expectedValue) {
            var millilitreInstance = new SystemOfUnits.Volume.Litre.Millilitre(millilitreValue);

            Centilitre actual = millilitreInstance;
            Assert.IsAssignableFrom<Centilitre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
