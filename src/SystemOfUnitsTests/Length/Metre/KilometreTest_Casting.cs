using NUnit.Framework;

namespace SystemOfUnitsTests.Length.Metre {
    using Kilometre = SystemOfUnits.Length.Metre.Kilometre;

    partial class KilometreTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+019)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+018)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e+000)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+036)]
        public void Should_cast_from_Exametre(double exametreValue, double expectedValue) {
            var exametreInstance = new SystemOfUnits.Length.Metre.Exametre(exametreValue);

            Kilometre actual = exametreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+016)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+015)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-003)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+033)]
        public void Should_cast_from_Petametre(double petametreValue, double expectedValue) {
            var petametreInstance = new SystemOfUnits.Length.Metre.Petametre(petametreValue);

            Kilometre actual = petametreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+012)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-006)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+030)]
        public void Should_cast_from_Terametre(double terametreValue, double expectedValue) {
            var terametreInstance = new SystemOfUnits.Length.Metre.Terametre(terametreValue);

            Kilometre actual = terametreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+010)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+009)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-009)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+027)]
        public void Should_cast_from_Gigametre(double gigametreValue, double expectedValue) {
            var gigametreInstance = new SystemOfUnits.Length.Metre.Gigametre(gigametreValue);

            Kilometre actual = gigametreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+006)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-012)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+024)]
        public void Should_cast_from_Megametre(double megametreValue, double expectedValue) {
            var megametreInstance = new SystemOfUnits.Length.Metre.Megametre(megametreValue);

            Kilometre actual = megametreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-016)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+020)]
        public void Should_cast_from_Hectometre(double hectometreValue, double expectedValue) {
            var hectometreInstance = new SystemOfUnits.Length.Metre.Hectometre(hectometreValue);

            Kilometre actual = hectometreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-017)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+019)]
        public void Should_cast_from_Decametre(double decametreValue, double expectedValue) {
            var decametreInstance = new SystemOfUnits.Length.Metre.Decametre(decametreValue);

            Kilometre actual = decametreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-018)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+018)]
        public void Should_cast_from_Metre(double metreValue, double expectedValue) {
            var metreInstance = new SystemOfUnits.Length.Metre.Metre(metreValue);

            Kilometre actual = metreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-019)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+017)]
        public void Should_cast_from_Decimetre(double decimetreValue, double expectedValue) {
            var decimetreInstance = new SystemOfUnits.Length.Metre.Decimetre(decimetreValue);

            Kilometre actual = decimetreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-020)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+016)]
        public void Should_cast_from_Centimetre(double centimetreValue, double expectedValue) {
            var centimetreInstance = new SystemOfUnits.Length.Metre.Centimetre(centimetreValue);

            Kilometre actual = centimetreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-015,  9.999999999999999e-022)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+015)]
        public void Should_cast_from_Millimetre(double millimetreValue, double expectedValue) {
            var millimetreInstance = new SystemOfUnits.Length.Metre.Millimetre(millimetreValue);

            Kilometre actual = millimetreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-005)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-006)]
        [TestCase( 1.000000000000000e-015,  9.999999999999999e-025)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+012)]
        public void Should_cast_from_Micrometre(double micrometreValue, double expectedValue) {
            var micrometreInstance = new SystemOfUnits.Length.Metre.Micrometre(micrometreValue);

            Kilometre actual = micrometreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-008)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-009)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-027)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+009)]
        public void Should_cast_from_Nanometre(double nanometreValue, double expectedValue) {
            var nanometreInstance = new SystemOfUnits.Length.Metre.Nanometre(nanometreValue);

            Kilometre actual = nanometreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-011)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-012)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-030)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+006)]
        public void Should_cast_from_Picometre(double picometreValue, double expectedValue) {
            var picometreInstance = new SystemOfUnits.Length.Metre.Picometre(picometreValue);

            Kilometre actual = picometreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-014)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-015)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-033)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+003)]
        public void Should_cast_from_Femtometre(double femtometreValue, double expectedValue) {
            var femtometreInstance = new SystemOfUnits.Length.Metre.Femtometre(femtometreValue);

            Kilometre actual = femtometreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-017)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-018)]
        [TestCase( 1.000000000000000e-015,  9.999999999999999e-037)]
        [TestCase( 1.000000000000000e+021,  1.000000000000000e+000)]
        public void Should_cast_from_Attometre(double attometreValue, double expectedValue) {
            var attometreInstance = new SystemOfUnits.Length.Metre.Attometre(attometreValue);

            Kilometre actual = attometreInstance;
            Assert.IsAssignableFrom<Kilometre>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}