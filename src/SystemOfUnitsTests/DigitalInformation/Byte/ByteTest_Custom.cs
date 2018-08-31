using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Byte {
    using Bit = SystemOfUnits.DigitalInformation.Bit.Bit;
    using Byte = SystemOfUnits.DigitalInformation.Byte.Byte;

    public partial class ByteTest {
        [TestCase(0, 0)]
        [TestCase(8, 1)]
        [TestCase(16, 2)]
        [TestCase(-8, -1)]
        [TestCase(64.8d, 8.1d)]
        public void Should_cast_from_Bit(double bitValue, double expectedValue) {
            var bitInstance = new Bit(bitValue);

            Byte actual = bitInstance;
            Assert.IsAssignableFrom<Byte>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase(0, 0)]
        [TestCase(1, 8)]
        [TestCase(2, 16)]
        [TestCase(-1, -8)]
        [TestCase(8.1d, 64.8)]
        public void Should_cast_to_Bit(double byteValue, double expectedValue) {
            var zebibyteInstance = new Byte(byteValue);

            Bit actual = zebibyteInstance;
            Assert.IsAssignableFrom<Bit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
    }
}
