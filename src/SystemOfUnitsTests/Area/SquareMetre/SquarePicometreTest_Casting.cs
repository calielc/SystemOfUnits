using NUnit.Framework;

namespace SystemOfUnitsTests.Area.SquareMetre {
    using SquarePicometre = SystemOfUnits.Area.SquareMetre.SquarePicometre;

    partial class SquarePicometreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e+036)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+037)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e+000)]
        [TestCase( 1.000000000000000e+012,  9.999999999999999e+071)]
        public void Should_cast_from_SquareExametre(double squareExametreValue, double expectedValue) {
            var squareExametreInstance = new SystemOfUnits.Area.SquareMetre.SquareExametre(squareExametreValue);

            SquarePicometre actual = squareExametreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e+030)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+031)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-006)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+066)]
        public void Should_cast_from_SquarePetametre(double squarePetametreValue, double expectedValue) {
            var squarePetametreInstance = new SystemOfUnits.Area.SquareMetre.SquarePetametre(squarePetametreValue);

            SquarePicometre actual = squarePetametreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000001e+024)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+025)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+060)]
        public void Should_cast_from_SquareTerametre(double squareTerametreValue, double expectedValue) {
            var squareTerametreInstance = new SystemOfUnits.Area.SquareMetre.SquareTerametre(squareTerametreValue);

            SquarePicometre actual = squareTerametreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e+018)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+019)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-018)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+054)]
        public void Should_cast_from_SquareGigametre(double squareGigametreValue, double expectedValue) {
            var squareGigametreInstance = new SystemOfUnits.Area.SquareMetre.SquareGigametre(squareGigametreValue);

            SquarePicometre actual = squareGigametreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e+012)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+013)]
        [TestCase( 1.000000000000000e-060,  9.999999999999999e-025)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+048)]
        public void Should_cast_from_SquareMegametre(double squareMegametreValue, double expectedValue) {
            var squareMegametreInstance = new SystemOfUnits.Area.SquareMetre.SquareMegametre(squareMegametreValue);

            SquarePicometre actual = squareMegametreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e+006)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+007)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-030)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+042)]
        public void Should_cast_from_SquareKilometre(double squareKilometreValue, double expectedValue) {
            var squareKilometreInstance = new SystemOfUnits.Area.SquareMetre.SquareKilometre(squareKilometreValue);

            SquarePicometre actual = squareKilometreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e+004)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+005)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-032)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+040)]
        public void Should_cast_from_SquareHectometre(double squareHectometreValue, double expectedValue) {
            var squareHectometreInstance = new SystemOfUnits.Area.SquareMetre.SquareHectometre(squareHectometreValue);

            SquarePicometre actual = squareHectometreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e+002)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+003)]
        [TestCase( 1.000000000000000e-060,  9.999999999999999e-035)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+038)]
        public void Should_cast_from_SquareDecametre(double squareDecametreValue, double expectedValue) {
            var squareDecametreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecametre(squareDecametreValue);

            SquarePicometre actual = squareDecametreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e+000)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e+001)]
        [TestCase( 1.000000000000000e-060,  9.999999999999999e-037)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+036)]
        public void Should_cast_from_SquareMetre(double squareMetreValue, double expectedValue) {
            var squareMetreInstance = new SystemOfUnits.Area.SquareMetre.SquareMetre(squareMetreValue);

            SquarePicometre actual = squareMetreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e-002)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e-001)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-038)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+034)]
        public void Should_cast_from_SquareDecimetre(double squareDecimetreValue, double expectedValue) {
            var squareDecimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecimetre(squareDecimetreValue);

            SquarePicometre actual = squareDecimetreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e-004)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e-003)]
        [TestCase( 1.000000000000000e-060,  9.999999999999999e-041)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+032)]
        public void Should_cast_from_SquareCentimetre(double squareCentimetreValue, double expectedValue) {
            var squareCentimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareCentimetre(squareCentimetreValue);

            SquarePicometre actual = squareCentimetreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e-006)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e-005)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-042)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+030)]
        public void Should_cast_from_SquareMillimetre(double squareMillimetreValue, double expectedValue) {
            var squareMillimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareMillimetre(squareMillimetreValue);

            SquarePicometre actual = squareMillimetreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e-012)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e-011)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-048)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+024)]
        public void Should_cast_from_SquareMicrometre(double squareMicrometreValue, double expectedValue) {
            var squareMicrometreInstance = new SystemOfUnits.Area.SquareMetre.SquareMicrometre(squareMicrometreValue);

            SquarePicometre actual = squareMicrometreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e-018)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e-017)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-054)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+018)]
        public void Should_cast_from_SquareNanometre(double squareNanometreValue, double expectedValue) {
            var squareNanometreInstance = new SystemOfUnits.Area.SquareMetre.SquareNanometre(squareNanometreValue);

            SquarePicometre actual = squareNanometreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e-030)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e-029)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-066)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+006)]
        public void Should_cast_from_SquareFemtometre(double squareFemtometreValue, double expectedValue) {
            var squareFemtometreInstance = new SystemOfUnits.Area.SquareMetre.SquareFemtometre(squareFemtometreValue);

            SquarePicometre actual = squareFemtometreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-024, -5.000000000000000e-036)]
        [TestCase( 1.370000000000000e-023,  1.370000000000000e-035)]
        [TestCase( 1.000000000000000e-060,  1.000000000000000e-072)]
        [TestCase( 1.000000000000000e+012,  1.000000000000000e+000)]
        public void Should_cast_from_SquareAttometre(double squareAttometreValue, double expectedValue) {
            var squareAttometreInstance = new SystemOfUnits.Area.SquareMetre.SquareAttometre(squareAttometreValue);

            SquarePicometre actual = squareAttometreInstance;
            Assert.IsAssignableFrom<SquarePicometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
