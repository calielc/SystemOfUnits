using NUnit.Framework;

namespace SystemOfUnitsTests.Area.SquareMetre {
    using SquareDecametre = SystemOfUnits.Area.SquareMetre.SquareDecametre;

    partial class SquareDecametreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+036)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+037)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e+000)]
        [TestCase( 1.000000000000000e+038,  9.999999999999999e+071)]
        public void Should_cast_from_SquareExametre(double squareExametreValue, double expectedValue) {
            var squareExametreInstance = new SystemOfUnits.Area.SquareMetre.SquareExametre(squareExametreValue);

            SquareDecametre actual = squareExametreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+030)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+031)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-006)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+066)]
        public void Should_cast_from_SquarePetametre(double squarePetametreValue, double expectedValue) {
            var squarePetametreInstance = new SystemOfUnits.Area.SquareMetre.SquarePetametre(squarePetametreValue);

            SquareDecametre actual = squarePetametreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000001e+024)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+025)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+060)]
        public void Should_cast_from_SquareTerametre(double squareTerametreValue, double expectedValue) {
            var squareTerametreInstance = new SystemOfUnits.Area.SquareMetre.SquareTerametre(squareTerametreValue);

            SquareDecametre actual = squareTerametreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+018)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+019)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-018)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+054)]
        public void Should_cast_from_SquareGigametre(double squareGigametreValue, double expectedValue) {
            var squareGigametreInstance = new SystemOfUnits.Area.SquareMetre.SquareGigametre(squareGigametreValue);

            SquareDecametre actual = squareGigametreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+012)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+013)]
        [TestCase( 9.999999999999999e-035,  9.999999999999999e-025)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+048)]
        public void Should_cast_from_SquareMegametre(double squareMegametreValue, double expectedValue) {
            var squareMegametreInstance = new SystemOfUnits.Area.SquareMetre.SquareMegametre(squareMegametreValue);

            SquareDecametre actual = squareMegametreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+006)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+007)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-030)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+042)]
        public void Should_cast_from_SquareKilometre(double squareKilometreValue, double expectedValue) {
            var squareKilometreInstance = new SystemOfUnits.Area.SquareMetre.SquareKilometre(squareKilometreValue);

            SquareDecametre actual = squareKilometreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+004)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+005)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-032)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+040)]
        public void Should_cast_from_SquareHectometre(double squareHectometreValue, double expectedValue) {
            var squareHectometreInstance = new SystemOfUnits.Area.SquareMetre.SquareHectometre(squareHectometreValue);

            SquareDecametre actual = squareHectometreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+001)]
        [TestCase( 9.999999999999999e-035,  9.999999999999999e-037)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+036)]
        public void Should_cast_from_SquareMetre(double squareMetreValue, double expectedValue) {
            var squareMetreInstance = new SystemOfUnits.Area.SquareMetre.SquareMetre(squareMetreValue);

            SquareDecametre actual = squareMetreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-002)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-001)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-038)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+034)]
        public void Should_cast_from_SquareDecimetre(double squareDecimetreValue, double expectedValue) {
            var squareDecimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecimetre(squareDecimetreValue);

            SquareDecametre actual = squareDecimetreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-004)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-003)]
        [TestCase( 9.999999999999999e-035,  9.999999999999999e-041)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+032)]
        public void Should_cast_from_SquareCentimetre(double squareCentimetreValue, double expectedValue) {
            var squareCentimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareCentimetre(squareCentimetreValue);

            SquareDecametre actual = squareCentimetreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-006)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-005)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-042)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+030)]
        public void Should_cast_from_SquareMillimetre(double squareMillimetreValue, double expectedValue) {
            var squareMillimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareMillimetre(squareMillimetreValue);

            SquareDecametre actual = squareMillimetreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-012)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-011)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-048)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+024)]
        public void Should_cast_from_SquareMicrometre(double squareMicrometreValue, double expectedValue) {
            var squareMicrometreInstance = new SystemOfUnits.Area.SquareMetre.SquareMicrometre(squareMicrometreValue);

            SquareDecametre actual = squareMicrometreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-018)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-017)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-054)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+018)]
        public void Should_cast_from_SquareNanometre(double squareNanometreValue, double expectedValue) {
            var squareNanometreInstance = new SystemOfUnits.Area.SquareMetre.SquareNanometre(squareNanometreValue);

            SquareDecametre actual = squareNanometreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-024)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-023)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-060)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+012)]
        public void Should_cast_from_SquarePicometre(double squarePicometreValue, double expectedValue) {
            var squarePicometreInstance = new SystemOfUnits.Area.SquareMetre.SquarePicometre(squarePicometreValue);

            SquareDecametre actual = squarePicometreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-030)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-029)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-066)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+006)]
        public void Should_cast_from_SquareFemtometre(double squareFemtometreValue, double expectedValue) {
            var squareFemtometreInstance = new SystemOfUnits.Area.SquareMetre.SquareFemtometre(squareFemtometreValue);

            SquareDecametre actual = squareFemtometreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-036)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-035)]
        [TestCase( 9.999999999999999e-035,  1.000000000000000e-072)]
        [TestCase( 1.000000000000000e+038,  1.000000000000000e+000)]
        public void Should_cast_from_SquareAttometre(double squareAttometreValue, double expectedValue) {
            var squareAttometreInstance = new SystemOfUnits.Area.SquareMetre.SquareAttometre(squareAttometreValue);

            SquareDecametre actual = squareAttometreInstance;
            Assert.IsAssignableFrom<SquareDecametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
