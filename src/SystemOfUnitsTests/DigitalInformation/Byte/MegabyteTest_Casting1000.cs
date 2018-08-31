using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Byte {
    using Megabyte = SystemOfUnits.DigitalInformation.Byte.Megabyte;

    partial class MegabyteTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+025)]
        [TestCase(-5.000000000000000e+006, -5.000000000000001e+024)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e+000)]
        public void Should_cast_from_Yottabyte(double yottabyteValue, double expectedValue) {
            var yottabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Yottabyte(yottabyteValue);

            Megabyte actual = yottabyteInstance;
            Assert.IsAssignableFrom<Megabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+022)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+021)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-003)]
        public void Should_cast_from_Zettabyte(double zettabyteValue, double expectedValue) {
            var zettabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Zettabyte(zettabyteValue);

            Megabyte actual = zettabyteInstance;
            Assert.IsAssignableFrom<Megabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+019)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+018)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-006)]
        public void Should_cast_from_Exabyte(double exabyteValue, double expectedValue) {
            var exabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Exabyte(exabyteValue);

            Megabyte actual = exabyteInstance;
            Assert.IsAssignableFrom<Megabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+016)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+015)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-009)]
        public void Should_cast_from_Petabyte(double petabyteValue, double expectedValue) {
            var petabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Petabyte(petabyteValue);

            Megabyte actual = petabyteInstance;
            Assert.IsAssignableFrom<Megabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+012)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-012)]
        public void Should_cast_from_Terabyte(double terabyteValue, double expectedValue) {
            var terabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Terabyte(terabyteValue);

            Megabyte actual = terabyteInstance;
            Assert.IsAssignableFrom<Megabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+010)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+009)]
        [TestCase( 1.000000000000000e-018,  1.000000000000000e-015)]
        public void Should_cast_from_Gigabyte(double gigabyteValue, double expectedValue) {
            var gigabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Gigabyte(gigabyteValue);

            Megabyte actual = gigabyteInstance;
            Assert.IsAssignableFrom<Megabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-018,  9.999999999999999e-022)]
        public void Should_cast_from_Kilobyte(double kilobyteValue, double expectedValue) {
            var kilobyteInstance = new SystemOfUnits.DigitalInformation.Byte.Kilobyte(kilobyteValue);

            Megabyte actual = kilobyteInstance;
            Assert.IsAssignableFrom<Megabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-018,  9.999999999999999e-025)]
        public void Should_cast_from_Byte(double byteValue, double expectedValue) {
            var byteInstance = new SystemOfUnits.DigitalInformation.Byte.Byte(byteValue);

            Megabyte actual = byteInstance;
            Assert.IsAssignableFrom<Megabyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
