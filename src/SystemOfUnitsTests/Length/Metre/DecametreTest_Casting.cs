using NUnit.Framework;

namespace SystemOfUnitsTests.Length.Metre {
    using Decametre = SystemOfUnits.Length.Metre.Decametre;

    partial class DecametreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+019)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+018)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e+000)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+036)]
        public void Should_cast_from_Exametre(double exametreValue, double expectedValue) {
            var exametreInstance = new SystemOfUnits.Length.Metre.Exametre(exametreValue);

            Decametre actual = exametreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+016)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+015)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-003)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+033)]
        public void Should_cast_from_Petametre(double petametreValue, double expectedValue) {
            var petametreInstance = new SystemOfUnits.Length.Metre.Petametre(petametreValue);

            Decametre actual = petametreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+012)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-006)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+030)]
        public void Should_cast_from_Terametre(double terametreValue, double expectedValue) {
            var terametreInstance = new SystemOfUnits.Length.Metre.Terametre(terametreValue);

            Decametre actual = terametreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+010)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+009)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-009)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+027)]
        public void Should_cast_from_Gigametre(double gigametreValue, double expectedValue) {
            var gigametreInstance = new SystemOfUnits.Length.Metre.Gigametre(gigametreValue);

            Decametre actual = gigametreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+006)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+024)]
        public void Should_cast_from_Megametre(double megametreValue, double expectedValue) {
            var megametreInstance = new SystemOfUnits.Length.Metre.Megametre(megametreValue);

            Decametre actual = megametreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-015)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+021)]
        public void Should_cast_from_Kilometre(double kilometreValue, double expectedValue) {
            var kilometreInstance = new SystemOfUnits.Length.Metre.Kilometre(kilometreValue);

            Decametre actual = kilometreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-016)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+020)]
        public void Should_cast_from_Hectometre(double hectometreValue, double expectedValue) {
            var hectometreInstance = new SystemOfUnits.Length.Metre.Hectometre(hectometreValue);

            Decametre actual = hectometreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-018)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+018)]
        public void Should_cast_from_Metre(double metreValue, double expectedValue) {
            var metreInstance = new SystemOfUnits.Length.Metre.Metre(metreValue);

            Decametre actual = metreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-019)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+017)]
        public void Should_cast_from_Decimetre(double decimetreValue, double expectedValue) {
            var decimetreInstance = new SystemOfUnits.Length.Metre.Decimetre(decimetreValue);

            Decametre actual = decimetreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-020)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+016)]
        public void Should_cast_from_Centimetre(double centimetreValue, double expectedValue) {
            var centimetreInstance = new SystemOfUnits.Length.Metre.Centimetre(centimetreValue);

            Decametre actual = centimetreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-017,  9.999999999999999e-022)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+015)]
        public void Should_cast_from_Millimetre(double millimetreValue, double expectedValue) {
            var millimetreInstance = new SystemOfUnits.Length.Metre.Millimetre(millimetreValue);

            Decametre actual = millimetreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-005)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-006)]
        [TestCase( 1.000000000000000e-017,  9.999999999999999e-025)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+012)]
        public void Should_cast_from_Micrometre(double micrometreValue, double expectedValue) {
            var micrometreInstance = new SystemOfUnits.Length.Metre.Micrometre(micrometreValue);

            Decametre actual = micrometreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-008)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-009)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-027)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+009)]
        public void Should_cast_from_Nanometre(double nanometreValue, double expectedValue) {
            var nanometreInstance = new SystemOfUnits.Length.Metre.Nanometre(nanometreValue);

            Decametre actual = nanometreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-011)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-012)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-030)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+006)]
        public void Should_cast_from_Picometre(double picometreValue, double expectedValue) {
            var picometreInstance = new SystemOfUnits.Length.Metre.Picometre(picometreValue);

            Decametre actual = picometreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-014)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-015)]
        [TestCase( 1.000000000000000e-017,  1.000000000000000e-033)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+003)]
        public void Should_cast_from_Femtometre(double femtometreValue, double expectedValue) {
            var femtometreInstance = new SystemOfUnits.Length.Metre.Femtometre(femtometreValue);

            Decametre actual = femtometreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-017)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-018)]
        [TestCase( 1.000000000000000e-017,  9.999999999999999e-037)]
        [TestCase( 1.000000000000000e+019,  1.000000000000000e+000)]
        public void Should_cast_from_Attometre(double attometreValue, double expectedValue) {
            var attometreInstance = new SystemOfUnits.Length.Metre.Attometre(attometreValue);

            Decametre actual = attometreInstance;
            Assert.IsAssignableFrom<Decametre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
