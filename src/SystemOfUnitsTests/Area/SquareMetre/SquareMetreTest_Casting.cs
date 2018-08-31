using NUnit.Framework;

namespace SystemOfUnitsTests.Area.SquareMetre {
    using SquareMetre = SystemOfUnits.Area.SquareMetre.SquareMetre;

    partial class SquareMetreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+036)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+037)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e+000)]
        [TestCase( 1.000000000000000e+036,  9.999999999999999e+071)]
        public void Should_cast_from_SquareExametre(double squareExametreValue, double expectedValue) {
            var squareExametreInstance = new SystemOfUnits.Area.SquareMetre.SquareExametre(squareExametreValue);

            SquareMetre actual = squareExametreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+030)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+031)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-006)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+066)]
        public void Should_cast_from_SquarePetametre(double squarePetametreValue, double expectedValue) {
            var squarePetametreInstance = new SystemOfUnits.Area.SquareMetre.SquarePetametre(squarePetametreValue);

            SquareMetre actual = squarePetametreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000001e+024)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+025)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+060)]
        public void Should_cast_from_SquareTerametre(double squareTerametreValue, double expectedValue) {
            var squareTerametreInstance = new SystemOfUnits.Area.SquareMetre.SquareTerametre(squareTerametreValue);

            SquareMetre actual = squareTerametreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+018)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+019)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-018)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+054)]
        public void Should_cast_from_SquareGigametre(double squareGigametreValue, double expectedValue) {
            var squareGigametreInstance = new SystemOfUnits.Area.SquareMetre.SquareGigametre(squareGigametreValue);

            SquareMetre actual = squareGigametreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+012)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+013)]
        [TestCase( 9.999999999999999e-037,  9.999999999999999e-025)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+048)]
        public void Should_cast_from_SquareMegametre(double squareMegametreValue, double expectedValue) {
            var squareMegametreInstance = new SystemOfUnits.Area.SquareMetre.SquareMegametre(squareMegametreValue);

            SquareMetre actual = squareMegametreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+006)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+007)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-030)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+042)]
        public void Should_cast_from_SquareKilometre(double squareKilometreValue, double expectedValue) {
            var squareKilometreInstance = new SystemOfUnits.Area.SquareMetre.SquareKilometre(squareKilometreValue);

            SquareMetre actual = squareKilometreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+004)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+005)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-032)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+040)]
        public void Should_cast_from_SquareHectometre(double squareHectometreValue, double expectedValue) {
            var squareHectometreInstance = new SystemOfUnits.Area.SquareMetre.SquareHectometre(squareHectometreValue);

            SquareMetre actual = squareHectometreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+002)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+003)]
        [TestCase( 9.999999999999999e-037,  9.999999999999999e-035)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+038)]
        public void Should_cast_from_SquareDecametre(double squareDecametreValue, double expectedValue) {
            var squareDecametreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecametre(squareDecametreValue);

            SquareMetre actual = squareDecametreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-002)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-001)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-038)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+034)]
        public void Should_cast_from_SquareDecimetre(double squareDecimetreValue, double expectedValue) {
            var squareDecimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareDecimetre(squareDecimetreValue);

            SquareMetre actual = squareDecimetreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-004)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-003)]
        [TestCase( 9.999999999999999e-037,  9.999999999999999e-041)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+032)]
        public void Should_cast_from_SquareCentimetre(double squareCentimetreValue, double expectedValue) {
            var squareCentimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareCentimetre(squareCentimetreValue);

            SquareMetre actual = squareCentimetreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-006)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-005)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-042)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+030)]
        public void Should_cast_from_SquareMillimetre(double squareMillimetreValue, double expectedValue) {
            var squareMillimetreInstance = new SystemOfUnits.Area.SquareMetre.SquareMillimetre(squareMillimetreValue);

            SquareMetre actual = squareMillimetreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-012)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-011)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-048)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+024)]
        public void Should_cast_from_SquareMicrometre(double squareMicrometreValue, double expectedValue) {
            var squareMicrometreInstance = new SystemOfUnits.Area.SquareMetre.SquareMicrometre(squareMicrometreValue);

            SquareMetre actual = squareMicrometreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-018)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-017)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-054)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+018)]
        public void Should_cast_from_SquareNanometre(double squareNanometreValue, double expectedValue) {
            var squareNanometreInstance = new SystemOfUnits.Area.SquareMetre.SquareNanometre(squareNanometreValue);

            SquareMetre actual = squareNanometreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-024)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-023)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-060)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+012)]
        public void Should_cast_from_SquarePicometre(double squarePicometreValue, double expectedValue) {
            var squarePicometreInstance = new SystemOfUnits.Area.SquareMetre.SquarePicometre(squarePicometreValue);

            SquareMetre actual = squarePicometreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-030)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-029)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-066)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+006)]
        public void Should_cast_from_SquareFemtometre(double squareFemtometreValue, double expectedValue) {
            var squareFemtometreInstance = new SystemOfUnits.Area.SquareMetre.SquareFemtometre(squareFemtometreValue);

            SquareMetre actual = squareFemtometreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-036)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-035)]
        [TestCase( 9.999999999999999e-037,  1.000000000000000e-072)]
        [TestCase( 1.000000000000000e+036,  1.000000000000000e+000)]
        public void Should_cast_from_SquareAttometre(double squareAttometreValue, double expectedValue) {
            var squareAttometreInstance = new SystemOfUnits.Area.SquareMetre.SquareAttometre(squareAttometreValue);

            SquareMetre actual = squareAttometreInstance;
            Assert.IsAssignableFrom<SquareMetre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
