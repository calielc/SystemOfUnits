using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Byte {
    using Exbibyte = SystemOfUnits.DigitalInformation.Byte.Exbibyte;

    partial class ExbibyteTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.152921504606847e+018,  1.208925819614629e+024)]
        [TestCase(-5.764607523034235e+018, -6.044629098073146e+024)]
        [TestCase( 2.861022949218750e-006,  3.000000000000000e+000)]
        [TestCase( 1.579502461311380e+019,  1.656228372872042e+025)]
        public void Should_cast_from_Yobibyte(double yobibyteValue, double expectedValue) {
            var yobibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Yobibyte(yobibyteValue);

            Exbibyte actual = yobibyteInstance;
            Assert.IsAssignableFrom<Exbibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.152921504606847e+018,  1.180591620717411e+021)]
        [TestCase(-5.764607523034235e+018, -5.902958103587057e+021)]
        [TestCase( 2.861022949218750e-006,  2.929687500000000e-003)]
        [TestCase( 1.579502461311380e+019,  1.617410520382853e+022)]
        public void Should_cast_from_Zebibyte(double zebibyteValue, double expectedValue) {
            var zebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Zebibyte(zebibyteValue);

            Exbibyte actual = zebibyteInstance;
            Assert.IsAssignableFrom<Exbibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.152921504606847e+018,  1.125899906842624e+015)]
        [TestCase(-5.764607523034235e+018, -5.629499534213120e+015)]
        [TestCase( 2.861022949218750e-006,  2.793967723846436e-009)]
        [TestCase( 1.579502461311380e+019,  1.542482872374395e+016)]
        public void Should_cast_from_Pebibyte(double pebibyteValue, double expectedValue) {
            var pebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Pebibyte(pebibyteValue);

            Exbibyte actual = pebibyteInstance;
            Assert.IsAssignableFrom<Exbibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.152921504606847e+018,  1.099511627776000e+012)]
        [TestCase(-5.764607523034235e+018, -5.497558138880000e+012)]
        [TestCase( 2.861022949218750e-006,  2.728484105318785e-012)]
        [TestCase( 1.579502461311380e+019,  1.506330930053120e+013)]
        public void Should_cast_from_Tebibyte(double tebibyteValue, double expectedValue) {
            var tebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Tebibyte(tebibyteValue);

            Exbibyte actual = tebibyteInstance;
            Assert.IsAssignableFrom<Exbibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.152921504606847e+018,  1.073741824000000e+009)]
        [TestCase(-5.764607523034235e+018, -5.368709120000000e+009)]
        [TestCase( 2.861022949218750e-006,  2.664535259100376e-015)]
        [TestCase( 1.579502461311380e+019,  1.471026298880000e+010)]
        public void Should_cast_from_Gibibyte(double gibibyteValue, double expectedValue) {
            var gibibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Gibibyte(gibibyteValue);

            Exbibyte actual = gibibyteInstance;
            Assert.IsAssignableFrom<Exbibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.152921504606847e+018,  1.048576000000000e+006)]
        [TestCase(-5.764607523034235e+018, -5.242880000000000e+006)]
        [TestCase( 2.861022949218750e-006,  2.602085213965211e-018)]
        [TestCase( 1.579502461311380e+019,  1.436549120000000e+007)]
        public void Should_cast_from_Mebibyte(double mebibyteValue, double expectedValue) {
            var mebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Mebibyte(mebibyteValue);

            Exbibyte actual = mebibyteInstance;
            Assert.IsAssignableFrom<Exbibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.152921504606847e+018,  1.024000000000000e+003)]
        [TestCase(-5.764607523034235e+018, -5.120000000000000e+003)]
        [TestCase( 2.861022949218750e-006,  2.541098841762901e-021)]
        [TestCase( 1.579502461311380e+019,  1.402880000000000e+004)]
        public void Should_cast_from_Kibibyte(double kibibyteValue, double expectedValue) {
            var kibibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Kibibyte(kibibyteValue);

            Exbibyte actual = kibibyteInstance;
            Assert.IsAssignableFrom<Exbibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.152921504606847e+018,  1.000000000000000e+000)]
        [TestCase(-5.764607523034235e+018, -5.000000000000000e+000)]
        [TestCase( 2.861022949218750e-006,  2.481541837659083e-024)]
        [TestCase( 1.579502461311380e+019,  1.370000000000000e+001)]
        public void Should_cast_from_Byte(double byteValue, double expectedValue) {
            var byteInstance = new SystemOfUnits.DigitalInformation.Byte.Byte(byteValue);

            Exbibyte actual = byteInstance;
            Assert.IsAssignableFrom<Exbibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
