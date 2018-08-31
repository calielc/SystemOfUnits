using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Byte {
    using Byte = SystemOfUnits.DigitalInformation.Byte.Byte;

    partial class ByteTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+025)]
        [TestCase(-5.000000000000000e+000, -5.000000000000001e+024)]
        [TestCase( 9.999999999999999e-025,  1.000000000000000e+000)]
        public void Should_cast_from_Yottabyte(double yottabyteValue, double expectedValue) {
            var yottabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Yottabyte(yottabyteValue);

            Byte actual = yottabyteInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+022)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+021)]
        [TestCase( 9.999999999999999e-025,  1.000000000000000e-003)]
        public void Should_cast_from_Zettabyte(double zettabyteValue, double expectedValue) {
            var zettabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Zettabyte(zettabyteValue);

            Byte actual = zettabyteInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+019)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+018)]
        [TestCase( 9.999999999999999e-025,  1.000000000000000e-006)]
        public void Should_cast_from_Exabyte(double exabyteValue, double expectedValue) {
            var exabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Exabyte(exabyteValue);

            Byte actual = exabyteInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+016)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+015)]
        [TestCase( 9.999999999999999e-025,  1.000000000000000e-009)]
        public void Should_cast_from_Petabyte(double petabyteValue, double expectedValue) {
            var petabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Petabyte(petabyteValue);

            Byte actual = petabyteInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+012)]
        [TestCase( 9.999999999999999e-025,  1.000000000000000e-012)]
        public void Should_cast_from_Terabyte(double terabyteValue, double expectedValue) {
            var terabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Terabyte(terabyteValue);

            Byte actual = terabyteInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+010)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+009)]
        [TestCase( 9.999999999999999e-025,  1.000000000000000e-015)]
        public void Should_cast_from_Gigabyte(double gigabyteValue, double expectedValue) {
            var gigabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Gigabyte(gigabyteValue);

            Byte actual = gigabyteInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+006)]
        [TestCase( 9.999999999999999e-025,  1.000000000000000e-018)]
        public void Should_cast_from_Megabyte(double megabyteValue, double expectedValue) {
            var megabyteInstance = new SystemOfUnits.DigitalInformation.Byte.Megabyte(megabyteValue);

            Byte actual = megabyteInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+003)]
        [TestCase( 9.999999999999999e-025,  9.999999999999999e-022)]
        public void Should_cast_from_Kilobyte(double kilobyteValue, double expectedValue) {
            var kilobyteInstance = new SystemOfUnits.DigitalInformation.Byte.Kilobyte(kilobyteValue);

            Byte actual = kilobyteInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
