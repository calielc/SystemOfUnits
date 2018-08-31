using NUnit.Framework;

namespace SystemOfUnitsTests.Frequency.Hertz {
    using Millihertz = SystemOfUnits.Frequency.Hertz.Millihertz;

    partial class MillihertzTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+006)]
        public void Should_cast_from_Kilohertz(double kilohertzValue, double expectedValue) {
            var kilohertzInstance = new SystemOfUnits.Frequency.Hertz.Kilohertz(kilohertzValue);

            Millihertz actual = kilohertzInstance;
            Assert.IsAssignableFrom<Millihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+005)]
        public void Should_cast_from_Hectohertz(double hectohertzValue, double expectedValue) {
            var hectohertzInstance = new SystemOfUnits.Frequency.Hertz.Hectohertz(hectohertzValue);

            Millihertz actual = hectohertzInstance;
            Assert.IsAssignableFrom<Millihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+004)]
        public void Should_cast_from_Decahertz(double decahertzValue, double expectedValue) {
            var decahertzInstance = new SystemOfUnits.Frequency.Hertz.Decahertz(decahertzValue);

            Millihertz actual = decahertzInstance;
            Assert.IsAssignableFrom<Millihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+003)]
        public void Should_cast_from_Hertz(double hertzValue, double expectedValue) {
            var hertzInstance = new SystemOfUnits.Frequency.Hertz.Hertz(hertzValue);

            Millihertz actual = hertzInstance;
            Assert.IsAssignableFrom<Millihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+002)]
        public void Should_cast_from_Decihertz(double decihertzValue, double expectedValue) {
            var decihertzInstance = new SystemOfUnits.Frequency.Hertz.Decihertz(decihertzValue);

            Millihertz actual = decihertzInstance;
            Assert.IsAssignableFrom<Millihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-002,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+000,  2.000000000000000e+001)]
        public void Should_cast_from_Centihertz(double centihertzValue, double expectedValue) {
            var centihertzInstance = new SystemOfUnits.Frequency.Hertz.Centihertz(centihertzValue);

            Millihertz actual = centihertzInstance;
            Assert.IsAssignableFrom<Millihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
