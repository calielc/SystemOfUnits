using NUnit.Framework;

namespace SystemOfUnitsTests.Area.SquareMetre {
    using SquareMillimetre = SystemOfUnits.Area.SquareMetre.SquareMillimetre;

    partial class SquareMillimetreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+036)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+037)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e+000)]
        [TestCase( 1.000000000000000e+030,  9.999999999999999e+071)]
        public void Should_cast_from_SquareExametre(double squareExametreValue, double expectedValue) {
            var squareExametreInstance = new SystemOfUnits.Area.SquareMetre.SquareExametre(squareExametreValue);

            SquareMillimetre actual = squareExametreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+030)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+031)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-006)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+066)]
        public void Should_cast_from_SquarePetametre(double squarePetametreValue, double expectedValue) {
            var squarePetametreInstance = new SystemOfUnits.Area.SquareMetre.SquarePetametre(squarePetametreValue);

            SquareMillimetre actual = squarePetametreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000001e+024)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+025)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+060)]
        public void Should_cast_from_SquareTerametre(double squareTerametreValue, double expectedValue) {
            var squareTerametreInstance = new SystemOfUnits.Area.SquareMetre.SquareTerametre(squareTerametreValue);

            SquareMillimetre actual = squareTerametreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+018)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+019)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-018)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+054)]
        public void Should_cast_from_SquareGigametre(double squareGigametreValue, double expectedValue) {
            var squareGigametreInstance = new SystemOfUnits.Area.SquareMetre.SquareGigametre(squareGigametreValue);

            SquareMillimetre actual = squareGigametreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+012)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+013)]
        [TestCase( 1.000000000000000e-042,  9.999999999999999e-025)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+048)]
        public void Should_cast_from_SquareMegametre(double squareMegametreValue, double expectedValue) {
            var squareMegametreInstance = new SystemOfUnits.Area.SquareMetre.SquareMegametre(squareMegametreValue);

            SquareMillimetre actual = squareMegametreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+006)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+007)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-030)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+042)]
        public void Should_cast_from_SquareKilometre(double squareKilometreValue, double expectedValue) {
            var squareKilometreInstance = new SystemOfUnits.Area.SquareMetre.SquareKilometre(squareKilometreValue);

            SquareMillimetre actual = squareKilometreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+004)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+005)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-032)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+040)]
        public void Should_cast_from_SquareHectometre(double squareHectometreValue, double expectedValue) {
            var squareHectometreInstance = new SystemOfUnits.Area.SquareMetre.SquareHectometre(squareHectometreValue);

            SquareMillimetre actual = squareHectometreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+002)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+003)]
        [TestCase( 1.000000000000000e-042,  9.999999999999999e-035)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+038)]
        public void Should_cast_from_SquareDecametre(double squareDecametreValue, double expectedValue) {
            var squareDecametreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecametre(squareDecametreValue);

            SquareMillimetre actual = squareDecametreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+000)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e+001)]
        [TestCase( 1.000000000000000e-042,  9.999999999999999e-037)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+036)]
        public void Should_cast_from_SquareMetre(double squareMetreValue, double expectedValue) {
            var squareMetreInstance = new SystemOfUnits.Area.SquareMetre.SquareMetre(squareMetreValue);

            SquareMillimetre actual = squareMetreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e-002)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e-001)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-038)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+034)]
        public void Should_cast_from_SquareDecimetre(double squareDecimetreValue, double expectedValue) {
            var squareDecimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecimetre(squareDecimetreValue);

            SquareMillimetre actual = squareDecimetreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e-004)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e-003)]
        [TestCase( 1.000000000000000e-042,  9.999999999999999e-041)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+032)]
        public void Should_cast_from_SquareCentimetre(double squareCentimetreValue, double expectedValue) {
            var squareCentimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareCentimetre(squareCentimetreValue);

            SquareMillimetre actual = squareCentimetreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e-012)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e-011)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-048)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+024)]
        public void Should_cast_from_SquareMicrometre(double squareMicrometreValue, double expectedValue) {
            var squareMicrometreInstance = new SystemOfUnits.Area.SquareMetre.SquareMicrometre(squareMicrometreValue);

            SquareMillimetre actual = squareMicrometreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e-018)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e-017)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-054)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+018)]
        public void Should_cast_from_SquareNanometre(double squareNanometreValue, double expectedValue) {
            var squareNanometreInstance = new SystemOfUnits.Area.SquareMetre.SquareNanometre(squareNanometreValue);

            SquareMillimetre actual = squareNanometreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e-024)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e-023)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-060)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+012)]
        public void Should_cast_from_SquarePicometre(double squarePicometreValue, double expectedValue) {
            var squarePicometreInstance = new SystemOfUnits.Area.SquareMetre.SquarePicometre(squarePicometreValue);

            SquareMillimetre actual = squarePicometreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e-030)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e-029)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-066)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+006)]
        public void Should_cast_from_SquareFemtometre(double squareFemtometreValue, double expectedValue) {
            var squareFemtometreInstance = new SystemOfUnits.Area.SquareMetre.SquareFemtometre(squareFemtometreValue);

            SquareMillimetre actual = squareFemtometreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e-036)]
        [TestCase( 1.370000000000000e-005,  1.370000000000000e-035)]
        [TestCase( 1.000000000000000e-042,  1.000000000000000e-072)]
        [TestCase( 1.000000000000000e+030,  1.000000000000000e+000)]
        public void Should_cast_from_SquareAttometre(double squareAttometreValue, double expectedValue) {
            var squareAttometreInstance = new SystemOfUnits.Area.SquareMetre.SquareAttometre(squareAttometreValue);

            SquareMillimetre actual = squareAttometreInstance;
            Assert.IsAssignableFrom<SquareMillimetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
