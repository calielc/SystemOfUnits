using NUnit.Framework;

namespace SystemOfUnitsTests.Frequency.Hertz {
    using Kilohertz = SystemOfUnits.Frequency.Hertz.Kilohertz;

    partial class KilohertzTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+005)]
        public void Should_cast_from_Hectohertz(double hectohertzValue, double expectedValue) {
            var hectohertzInstance = new SystemOfUnits.Frequency.Hertz.Hectohertz(hectohertzValue);

            Kilohertz actual = hectohertzInstance;
            Assert.IsAssignableFrom<Kilohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+004)]
        public void Should_cast_from_Decahertz(double decahertzValue, double expectedValue) {
            var decahertzInstance = new SystemOfUnits.Frequency.Hertz.Decahertz(decahertzValue);

            Kilohertz actual = decahertzInstance;
            Assert.IsAssignableFrom<Kilohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+003)]
        public void Should_cast_from_Hertz(double hertzValue, double expectedValue) {
            var hertzInstance = new SystemOfUnits.Frequency.Hertz.Hertz(hertzValue);

            Kilohertz actual = hertzInstance;
            Assert.IsAssignableFrom<Kilohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+002)]
        public void Should_cast_from_Decihertz(double decihertzValue, double expectedValue) {
            var decihertzInstance = new SystemOfUnits.Frequency.Hertz.Decihertz(decihertzValue);

            Kilohertz actual = decihertzInstance;
            Assert.IsAssignableFrom<Kilohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+001)]
        public void Should_cast_from_Centihertz(double centihertzValue, double expectedValue) {
            var centihertzInstance = new SystemOfUnits.Frequency.Hertz.Centihertz(centihertzValue);

            Kilohertz actual = centihertzInstance;
            Assert.IsAssignableFrom<Kilohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+000)]
        public void Should_cast_from_Millihertz(double millihertzValue, double expectedValue) {
            var millihertzInstance = new SystemOfUnits.Frequency.Hertz.Millihertz(millihertzValue);

            Kilohertz actual = millihertzInstance;
            Assert.IsAssignableFrom<Kilohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
