using NUnit.Framework;

namespace SystemOfUnitsTests.Volume.CubicMetre {
    using CubicMillimetre = SystemOfUnits.Volume.CubicMetre.CubicMillimetre;

    partial class CubicMillimetreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-009, -5.000000000000000e+009)]
        [TestCase( 1.370000000000000e-008,  1.370000000000000e+010)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e+000)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e+018)]
        public void Should_cast_from_CubicKilometre(double cubicKilometreValue, double expectedValue) {
            var cubicKilometreInstance = new SystemOfUnits.Volume.CubicMetre.CubicKilometre(cubicKilometreValue);

            CubicMillimetre actual = cubicKilometreInstance;
            Assert.IsAssignableFrom<CubicMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-009, -5.000000000000000e+006)]
        [TestCase( 1.370000000000000e-008,  1.370000000000000e+007)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-003)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e+015)]
        public void Should_cast_from_CubicHectometre(double cubicHectometreValue, double expectedValue) {
            var cubicHectometreInstance = new SystemOfUnits.Volume.CubicMetre.CubicHectometre(cubicHectometreValue);

            CubicMillimetre actual = cubicHectometreInstance;
            Assert.IsAssignableFrom<CubicMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-009, -5.000000000000000e+003)]
        [TestCase( 1.370000000000000e-008,  1.370000000000000e+004)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-006)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e+012)]
        public void Should_cast_from_CubicDecametre(double cubicDecametreValue, double expectedValue) {
            var cubicDecametreInstance = new SystemOfUnits.Volume.CubicMetre.CubicDecametre(cubicDecametreValue);

            CubicMillimetre actual = cubicDecametreInstance;
            Assert.IsAssignableFrom<CubicMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-009, -5.000000000000000e+000)]
        [TestCase( 1.370000000000000e-008,  1.370000000000000e+001)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-009)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e+009)]
        public void Should_cast_from_CubicMetre(double cubicMetreValue, double expectedValue) {
            var cubicMetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicMetre(cubicMetreValue);

            CubicMillimetre actual = cubicMetreInstance;
            Assert.IsAssignableFrom<CubicMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-009, -5.000000000000000e-003)]
        [TestCase( 1.370000000000000e-008,  1.370000000000000e-002)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e+006)]
        public void Should_cast_from_CubicDecimetre(double cubicDecimetreValue, double expectedValue) {
            var cubicDecimetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicDecimetre(cubicDecimetreValue);

            CubicMillimetre actual = cubicDecimetreInstance;
            Assert.IsAssignableFrom<CubicMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-009, -5.000000000000000e-006)]
        [TestCase( 1.370000000000000e-008,  1.370000000000000e-005)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-015)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e+003)]
        public void Should_cast_from_CubicCentimetre(double cubicCentimetreValue, double expectedValue) {
            var cubicCentimetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicCentimetre(cubicCentimetreValue);

            CubicMillimetre actual = cubicCentimetreInstance;
            Assert.IsAssignableFrom<CubicMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
