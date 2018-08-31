using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Byte {
    using Gigabyte = SystemOfUnits.DigitalInformation.Byte.Gigabyte;

    partial class GigabyteTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+025)]
        [TestCase(-5.000000000000000e+009, -5.000000000000001e+024)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e+000)]
        public void Should_cast_from_Yottabyte(double yottabyteValue, double expectedValue) {
            var yottabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Yottabyte(yottabyteValue);

            Gigabyte actual = yottabyteInstance;
            Assert.IsAssignableFrom<Gigabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+022)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+021)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-003)]
        public void Should_cast_from_Zettabyte(double zettabyteValue, double expectedValue) {
            var zettabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Zettabyte(zettabyteValue);

            Gigabyte actual = zettabyteInstance;
            Assert.IsAssignableFrom<Gigabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+019)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+018)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-006)]
        public void Should_cast_from_Exabyte(double exabyteValue, double expectedValue) {
            var exabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Exabyte(exabyteValue);

            Gigabyte actual = exabyteInstance;
            Assert.IsAssignableFrom<Gigabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+016)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+015)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-009)]
        public void Should_cast_from_Petabyte(double petabyteValue, double expectedValue) {
            var petabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Petabyte(petabyteValue);

            Gigabyte actual = petabyteInstance;
            Assert.IsAssignableFrom<Gigabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+012)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-012)]
        public void Should_cast_from_Terabyte(double terabyteValue, double expectedValue) {
            var terabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Terabyte(terabyteValue);

            Gigabyte actual = terabyteInstance;
            Assert.IsAssignableFrom<Gigabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+006)]
        [TestCase( 1.000000000000000e-015,  1.000000000000000e-018)]
        public void Should_cast_from_Megabyte(double megabyteValue, double expectedValue) {
            var megabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Megabyte(megabyteValue);

            Gigabyte actual = megabyteInstance;
            Assert.IsAssignableFrom<Gigabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-015,  9.999999999999999e-022)]
        public void Should_cast_from_Kilobyte(double kilobyteValue, double expectedValue) {
            var kilobyteInstance = new SystemOfUnits.DigitalInformation.Byte.Kilobyte(kilobyteValue);

            Gigabyte actual = kilobyteInstance;
            Assert.IsAssignableFrom<Gigabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+009, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-015,  9.999999999999999e-025)]
        public void Should_cast_from_Byte(double byteValue, double expectedValue) {
            var byteInstance = new SystemOfUnits.DigitalInformation.Byte.Byte(byteValue);

            Gigabyte actual = byteInstance;
            Assert.IsAssignableFrom<Gigabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
