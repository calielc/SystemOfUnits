using NUnit.Framework;

namespace SystemOfUnitsTests.Volume.CubicMetre {
    using CubicKilometre = SystemOfUnits.Volume.CubicMetre.CubicKilometre;

    partial class CubicKilometreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+006)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+007)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-003)]
        [TestCase( 1.000000000000000e+018,  1.000000000000000e+015)]
        public void Should_cast_from_CubicHectometre(double cubicHectometreValue, double expectedValue) {
            var cubicHectometreInstance = new SystemOfUnits.Volume.CubicMetre.CubicHectometre(cubicHectometreValue);

            CubicKilometre actual = cubicHectometreInstance;
            Assert.IsAssignableFrom<CubicKilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+003)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+004)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-006)]
        [TestCase( 1.000000000000000e+018,  1.000000000000000e+012)]
        public void Should_cast_from_CubicDecametre(double cubicDecametreValue, double expectedValue) {
            var cubicDecametreInstance = new SystemOfUnits.Volume.CubicMetre.CubicDecametre(cubicDecametreValue);

            CubicKilometre actual = cubicDecametreInstance;
            Assert.IsAssignableFrom<CubicKilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-009)]
        [TestCase( 1.000000000000000e+018,  1.000000000000000e+009)]
        public void Should_cast_from_CubicMetre(double cubicMetreValue, double expectedValue) {
            var cubicMetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicMetre(cubicMetreValue);

            CubicKilometre actual = cubicMetreInstance;
            Assert.IsAssignableFrom<CubicKilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e-003)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e-002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+018,  1.000000000000000e+006)]
        public void Should_cast_from_CubicDecimetre(double cubicDecimetreValue, double expectedValue) {
            var cubicDecimetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicDecimetre(cubicDecimetreValue);

            CubicKilometre actual = cubicDecimetreInstance;
            Assert.IsAssignableFrom<CubicKilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e-006)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e-005)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-015)]
        [TestCase( 1.000000000000000e+018,  1.000000000000000e+003)]
        public void Should_cast_from_CubicCentimetre(double cubicCentimetreValue, double expectedValue) {
            var cubicCentimetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicCentimetre(cubicCentimetreValue);

            CubicKilometre actual = cubicCentimetreInstance;
            Assert.IsAssignableFrom<CubicKilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e-009)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e-008)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-018)]
        [TestCase( 1.000000000000000e+018,  1.000000000000000e+000)]
        public void Should_cast_from_CubicMillimetre(double cubicMillimetreValue, double expectedValue) {
            var cubicMillimetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicMillimetre(cubicMillimetreValue);

            CubicKilometre actual = cubicMillimetreInstance;
            Assert.IsAssignableFrom<CubicKilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
