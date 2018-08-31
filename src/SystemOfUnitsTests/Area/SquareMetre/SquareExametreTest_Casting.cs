using NUnit.Framework;

namespace SystemOfUnitsTests.Area.SquareMetre {
    using SquareExametre = SystemOfUnits.Area.SquareMetre.SquareExametre;

    partial class SquareExametreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e+030)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e+031)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-006)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+066)]
        public void Should_cast_from_SquarePetametre(double squarePetametreValue, double expectedValue) {
            var squarePetametreInstance = new SystemOfUnits.Area.SquareMetre.SquarePetametre(squarePetametreValue);

            SquareExametre actual = squarePetametreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000001e+024)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e+025)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-012)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+060)]
        public void Should_cast_from_SquareTerametre(double squareTerametreValue, double expectedValue) {
            var squareTerametreInstance = new SystemOfUnits.Area.SquareMetre.SquareTerametre(squareTerametreValue);

            SquareExametre actual = squareTerametreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e+018)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e+019)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-018)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+054)]
        public void Should_cast_from_SquareGigametre(double squareGigametreValue, double expectedValue) {
            var squareGigametreInstance = new SystemOfUnits.Area.SquareMetre.SquareGigametre(squareGigametreValue);

            SquareExametre actual = squareGigametreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e+012)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e+013)]
        [TestCase( 1.000000000000000e+000,  9.999999999999999e-025)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+048)]
        public void Should_cast_from_SquareMegametre(double squareMegametreValue, double expectedValue) {
            var squareMegametreInstance = new SystemOfUnits.Area.SquareMetre.SquareMegametre(squareMegametreValue);

            SquareExametre actual = squareMegametreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e+006)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e+007)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-030)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+042)]
        public void Should_cast_from_SquareKilometre(double squareKilometreValue, double expectedValue) {
            var squareKilometreInstance = new SystemOfUnits.Area.SquareMetre.SquareKilometre(squareKilometreValue);

            SquareExametre actual = squareKilometreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e+004)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e+005)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-032)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+040)]
        public void Should_cast_from_SquareHectometre(double squareHectometreValue, double expectedValue) {
            var squareHectometreInstance = new SystemOfUnits.Area.SquareMetre.SquareHectometre(squareHectometreValue);

            SquareExametre actual = squareHectometreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e+002)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e+003)]
        [TestCase( 1.000000000000000e+000,  9.999999999999999e-035)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+038)]
        public void Should_cast_from_SquareDecametre(double squareDecametreValue, double expectedValue) {
            var squareDecametreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecametre(squareDecametreValue);

            SquareExametre actual = squareDecametreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e+000)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e+001)]
        [TestCase( 1.000000000000000e+000,  9.999999999999999e-037)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+036)]
        public void Should_cast_from_SquareMetre(double squareMetreValue, double expectedValue) {
            var squareMetreInstance = new SystemOfUnits.Area.SquareMetre.SquareMetre(squareMetreValue);

            SquareExametre actual = squareMetreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e-002)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e-001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-038)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+034)]
        public void Should_cast_from_SquareDecimetre(double squareDecimetreValue, double expectedValue) {
            var squareDecimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecimetre(squareDecimetreValue);

            SquareExametre actual = squareDecimetreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e-004)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e-003)]
        [TestCase( 1.000000000000000e+000,  9.999999999999999e-041)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+032)]
        public void Should_cast_from_SquareCentimetre(double squareCentimetreValue, double expectedValue) {
            var squareCentimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareCentimetre(squareCentimetreValue);

            SquareExametre actual = squareCentimetreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e-006)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e-005)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-042)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+030)]
        public void Should_cast_from_SquareMillimetre(double squareMillimetreValue, double expectedValue) {
            var squareMillimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareMillimetre(squareMillimetreValue);

            SquareExametre actual = squareMillimetreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e-012)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e-011)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-048)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+024)]
        public void Should_cast_from_SquareMicrometre(double squareMicrometreValue, double expectedValue) {
            var squareMicrometreInstance = new SystemOfUnits.Area.SquareMetre.SquareMicrometre(squareMicrometreValue);

            SquareExametre actual = squareMicrometreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e-018)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e-017)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-054)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+018)]
        public void Should_cast_from_SquareNanometre(double squareNanometreValue, double expectedValue) {
            var squareNanometreInstance = new SystemOfUnits.Area.SquareMetre.SquareNanometre(squareNanometreValue);

            SquareExametre actual = squareNanometreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e-024)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e-023)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-060)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+012)]
        public void Should_cast_from_SquarePicometre(double squarePicometreValue, double expectedValue) {
            var squarePicometreInstance = new SystemOfUnits.Area.SquareMetre.SquarePicometre(squarePicometreValue);

            SquareExametre actual = squarePicometreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e-030)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e-029)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-066)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+006)]
        public void Should_cast_from_SquareFemtometre(double squareFemtometreValue, double expectedValue) {
            var squareFemtometreInstance = new SystemOfUnits.Area.SquareMetre.SquareFemtometre(squareFemtometreValue);

            SquareExametre actual = squareFemtometreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+036, -5.000000000000000e-036)]
        [TestCase( 1.370000000000000e+037,  1.370000000000000e-035)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-072)]
        [TestCase( 9.999999999999999e+071,  1.000000000000000e+000)]
        public void Should_cast_from_SquareAttometre(double squareAttometreValue, double expectedValue) {
            var squareAttometreInstance = new SystemOfUnits.Area.SquareMetre.SquareAttometre(squareAttometreValue);

            SquareExametre actual = squareAttometreInstance;
            Assert.IsAssignableFrom<SquareExametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
