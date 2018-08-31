using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Byte {
    using Pebibyte = SystemOfUnits.DigitalInformation.Byte.Pebibyte;

    partial class PebibyteTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.125899906842624e+015,  1.208925819614629e+024)]
        [TestCase(-5.629499534213120e+015, -6.044629098073146e+024)]
        [TestCase( 2.793967723846436e-009,  3.000000000000000e+000)]
        [TestCase( 1.542482872374395e+016,  1.656228372872042e+025)]
        public void Should_cast_from_Yobibyte(double yobibyteValue, double expectedValue) {
            var yobibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Yobibyte(yobibyteValue);

            Pebibyte actual = yobibyteInstance;
            Assert.IsAssignableFrom<Pebibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.125899906842624e+015,  1.180591620717411e+021)]
        [TestCase(-5.629499534213120e+015, -5.902958103587057e+021)]
        [TestCase( 2.793967723846436e-009,  2.929687500000000e-003)]
        [TestCase( 1.542482872374395e+016,  1.617410520382853e+022)]
        public void Should_cast_from_Zebibyte(double zebibyteValue, double expectedValue) {
            var zebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Zebibyte(zebibyteValue);

            Pebibyte actual = zebibyteInstance;
            Assert.IsAssignableFrom<Pebibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.125899906842624e+015,  1.152921504606847e+018)]
        [TestCase(-5.629499534213120e+015, -5.764607523034235e+018)]
        [TestCase( 2.793967723846436e-009,  2.861022949218750e-006)]
        [TestCase( 1.542482872374395e+016,  1.579502461311380e+019)]
        public void Should_cast_from_Exbibyte(double exbibyteValue, double expectedValue) {
            var exbibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Exbibyte(exbibyteValue);

            Pebibyte actual = exbibyteInstance;
            Assert.IsAssignableFrom<Pebibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.125899906842624e+015,  1.099511627776000e+012)]
        [TestCase(-5.629499534213120e+015, -5.497558138880000e+012)]
        [TestCase( 2.793967723846436e-009,  2.728484105318785e-012)]
        [TestCase( 1.542482872374395e+016,  1.506330930053120e+013)]
        public void Should_cast_from_Tebibyte(double tebibyteValue, double expectedValue) {
            var tebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Tebibyte(tebibyteValue);

            Pebibyte actual = tebibyteInstance;
            Assert.IsAssignableFrom<Pebibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.125899906842624e+015,  1.073741824000000e+009)]
        [TestCase(-5.629499534213120e+015, -5.368709120000000e+009)]
        [TestCase( 2.793967723846436e-009,  2.664535259100376e-015)]
        [TestCase( 1.542482872374395e+016,  1.471026298880000e+010)]
        public void Should_cast_from_Gibibyte(double gibibyteValue, double expectedValue) {
            var gibibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Gibibyte(gibibyteValue);

            Pebibyte actual = gibibyteInstance;
            Assert.IsAssignableFrom<Pebibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.125899906842624e+015,  1.048576000000000e+006)]
        [TestCase(-5.629499534213120e+015, -5.242880000000000e+006)]
        [TestCase( 2.793967723846436e-009,  2.602085213965211e-018)]
        [TestCase( 1.542482872374395e+016,  1.436549120000000e+007)]
        public void Should_cast_from_Mebibyte(double mebibyteValue, double expectedValue) {
            var mebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Mebibyte(mebibyteValue);

            Pebibyte actual = mebibyteInstance;
            Assert.IsAssignableFrom<Pebibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.125899906842624e+015,  1.024000000000000e+003)]
        [TestCase(-5.629499534213120e+015, -5.120000000000000e+003)]
        [TestCase( 2.793967723846436e-009,  2.541098841762901e-021)]
        [TestCase( 1.542482872374395e+016,  1.402880000000000e+004)]
        public void Should_cast_from_Kibibyte(double kibibyteValue, double expectedValue) {
            var kibibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Kibibyte(kibibyteValue);

            Pebibyte actual = kibibyteInstance;
            Assert.IsAssignableFrom<Pebibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.125899906842624e+015,  1.000000000000000e+000)]
        [TestCase(-5.629499534213120e+015, -5.000000000000000e+000)]
        [TestCase( 2.793967723846436e-009,  2.481541837659083e-024)]
        [TestCase( 1.542482872374395e+016,  1.370000000000000e+001)]
        public void Should_cast_from_Byte(double byteValue, double expectedValue) {
            var byteInstance = new SystemOfUnits.DigitalInformation.Byte.Byte(byteValue);

            Pebibyte actual = byteInstance;
            Assert.IsAssignableFrom<Pebibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
