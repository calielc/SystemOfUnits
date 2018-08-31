using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Byte {
    using Yobibyte = SystemOfUnits.DigitalInformation.Byte.Yobibyte;

    partial class YobibyteTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.208925819614629e+024,  1.180591620717411e+021)]
        [TestCase(-6.044629098073146e+024, -5.902958103587057e+021)]
        [TestCase( 3.000000000000000e+000,  2.929687500000000e-003)]
        [TestCase( 1.656228372872042e+025,  1.617410520382853e+022)]
        public void Should_cast_from_Zebibyte(double zebibyteValue, double expectedValue) {
            var zebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Zebibyte(zebibyteValue);

            Yobibyte actual = zebibyteInstance;
            Assert.IsAssignableFrom<Yobibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.208925819614629e+024,  1.152921504606847e+018)]
        [TestCase(-6.044629098073146e+024, -5.764607523034235e+018)]
        [TestCase( 3.000000000000000e+000,  2.861022949218750e-006)]
        [TestCase( 1.656228372872042e+025,  1.579502461311380e+019)]
        public void Should_cast_from_Exbibyte(double exbibyteValue, double expectedValue) {
            var exbibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Exbibyte(exbibyteValue);

            Yobibyte actual = exbibyteInstance;
            Assert.IsAssignableFrom<Yobibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.208925819614629e+024,  1.125899906842624e+015)]
        [TestCase(-6.044629098073146e+024, -5.629499534213120e+015)]
        [TestCase( 3.000000000000000e+000,  2.793967723846436e-009)]
        [TestCase( 1.656228372872042e+025,  1.542482872374395e+016)]
        public void Should_cast_from_Pebibyte(double pebibyteValue, double expectedValue) {
            var pebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Pebibyte(pebibyteValue);

            Yobibyte actual = pebibyteInstance;
            Assert.IsAssignableFrom<Yobibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.208925819614629e+024,  1.099511627776000e+012)]
        [TestCase(-6.044629098073146e+024, -5.497558138880000e+012)]
        [TestCase( 3.000000000000000e+000,  2.728484105318785e-012)]
        [TestCase( 1.656228372872042e+025,  1.506330930053120e+013)]
        public void Should_cast_from_Tebibyte(double tebibyteValue, double expectedValue) {
            var tebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Tebibyte(tebibyteValue);

            Yobibyte actual = tebibyteInstance;
            Assert.IsAssignableFrom<Yobibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.208925819614629e+024,  1.073741824000000e+009)]
        [TestCase(-6.044629098073146e+024, -5.368709120000000e+009)]
        [TestCase( 3.000000000000000e+000,  2.664535259100376e-015)]
        [TestCase( 1.656228372872042e+025,  1.471026298880000e+010)]
        public void Should_cast_from_Gibibyte(double gibibyteValue, double expectedValue) {
            var gibibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Gibibyte(gibibyteValue);

            Yobibyte actual = gibibyteInstance;
            Assert.IsAssignableFrom<Yobibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.208925819614629e+024,  1.048576000000000e+006)]
        [TestCase(-6.044629098073146e+024, -5.242880000000000e+006)]
        [TestCase( 3.000000000000000e+000,  2.602085213965211e-018)]
        [TestCase( 1.656228372872042e+025,  1.436549120000000e+007)]
        public void Should_cast_from_Mebibyte(double mebibyteValue, double expectedValue) {
            var mebibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Mebibyte(mebibyteValue);

            Yobibyte actual = mebibyteInstance;
            Assert.IsAssignableFrom<Yobibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.208925819614629e+024,  1.024000000000000e+003)]
        [TestCase(-6.044629098073146e+024, -5.120000000000000e+003)]
        [TestCase( 3.000000000000000e+000,  2.541098841762901e-021)]
        [TestCase( 1.656228372872042e+025,  1.402880000000000e+004)]
        public void Should_cast_from_Kibibyte(double kibibyteValue, double expectedValue) {
            var kibibyteInstance = new SystemOfUnits.DigitalInformation.Byte.Kibibyte(kibibyteValue);

            Yobibyte actual = kibibyteInstance;
            Assert.IsAssignableFrom<Yobibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.208925819614629e+024,  1.000000000000000e+000)]
        [TestCase(-6.044629098073146e+024, -5.000000000000000e+000)]
        [TestCase( 3.000000000000000e+000,  2.481541837659083e-024)]
        [TestCase( 1.656228372872042e+025,  1.370000000000000e+001)]
        public void Should_cast_from_Byte(double byteValue, double expectedValue) {
            var byteInstance = new SystemOfUnits.DigitalInformation.Byte.Byte(byteValue);

            Yobibyte actual = byteInstance;
            Assert.IsAssignableFrom<Yobibyte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
