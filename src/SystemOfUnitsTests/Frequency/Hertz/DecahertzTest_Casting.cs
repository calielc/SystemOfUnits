using NUnit.Framework;

namespace SystemOfUnitsTests.Frequency.Hertz {
    using Decahertz = SystemOfUnits.Frequency.Hertz.Decahertz;

    partial class DecahertzTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+006)]
        public void Should_cast_from_Kilohertz(double kilohertzValue, double expectedValue) {
            var kilohertzInstance = new SystemOfUnits.Frequency.Hertz.Kilohertz(kilohertzValue);

            Decahertz actual = kilohertzInstance;
            Assert.IsAssignableFrom<Decahertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+005)]
        public void Should_cast_from_Hectohertz(double hectohertzValue, double expectedValue) {
            var hectohertzInstance = new SystemOfUnits.Frequency.Hertz.Hectohertz(hectohertzValue);

            Decahertz actual = hectohertzInstance;
            Assert.IsAssignableFrom<Decahertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+003)]
        public void Should_cast_from_Hertz(double hertzValue, double expectedValue) {
            var hertzInstance = new SystemOfUnits.Frequency.Hertz.Hertz(hertzValue);

            Decahertz actual = hertzInstance;
            Assert.IsAssignableFrom<Decahertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+002)]
        public void Should_cast_from_Decihertz(double decihertzValue, double expectedValue) {
            var decihertzInstance = new SystemOfUnits.Frequency.Hertz.Decihertz(decihertzValue);

            Decahertz actual = decihertzInstance;
            Assert.IsAssignableFrom<Decahertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+001)]
        public void Should_cast_from_Centihertz(double centihertzValue, double expectedValue) {
            var centihertzInstance = new SystemOfUnits.Frequency.Hertz.Centihertz(centihertzValue);

            Decahertz actual = centihertzInstance;
            Assert.IsAssignableFrom<Decahertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+000)]
        public void Should_cast_from_Millihertz(double millihertzValue, double expectedValue) {
            var millihertzInstance = new SystemOfUnits.Frequency.Hertz.Millihertz(millihertzValue);

            Decahertz actual = millihertzInstance;
            Assert.IsAssignableFrom<Decahertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
