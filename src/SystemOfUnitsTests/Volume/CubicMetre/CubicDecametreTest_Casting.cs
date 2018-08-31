using NUnit.Framework;

namespace SystemOfUnitsTests.Volume.CubicMetre {
    using CubicDecametre = SystemOfUnits.Volume.CubicMetre.CubicDecametre;

    partial class CubicDecametreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+009)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+010)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e+000)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+018)]
        public void Should_cast_from_CubicKilometre(double cubicKilometreValue, double expectedValue) {
            var cubicKilometreInstance = new SystemOfUnits.Volume.CubicMetre.CubicKilometre(cubicKilometreValue);

            CubicDecametre actual = cubicKilometreInstance;
            Assert.IsAssignableFrom<CubicDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+006)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+007)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-003)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+015)]
        public void Should_cast_from_CubicHectometre(double cubicHectometreValue, double expectedValue) {
            var cubicHectometreInstance = new SystemOfUnits.Volume.CubicMetre.CubicHectometre(cubicHectometreValue);

            CubicDecametre actual = cubicHectometreInstance;
            Assert.IsAssignableFrom<CubicDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+001)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-009)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+009)]
        public void Should_cast_from_CubicMetre(double cubicMetreValue, double expectedValue) {
            var cubicMetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicMetre(cubicMetreValue);

            CubicDecametre actual = cubicMetreInstance;
            Assert.IsAssignableFrom<CubicDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-003)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-002)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+006)]
        public void Should_cast_from_CubicDecimetre(double cubicDecimetreValue, double expectedValue) {
            var cubicDecimetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicDecimetre(cubicDecimetreValue);

            CubicDecametre actual = cubicDecimetreInstance;
            Assert.IsAssignableFrom<CubicDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-006)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-005)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-015)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+003)]
        public void Should_cast_from_CubicCentimetre(double cubicCentimetreValue, double expectedValue) {
            var cubicCentimetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicCentimetre(cubicCentimetreValue);

            CubicDecametre actual = cubicCentimetreInstance;
            Assert.IsAssignableFrom<CubicDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-009)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-008)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-018)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+000)]
        public void Should_cast_from_CubicMillimetre(double cubicMillimetreValue, double expectedValue) {
            var cubicMillimetreInstance = new SystemOfUnits.Volume.CubicMetre.CubicMillimetre(cubicMillimetreValue);

            CubicDecametre actual = cubicMillimetreInstance;
            Assert.IsAssignableFrom<CubicDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
