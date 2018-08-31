using NUnit.Framework;

namespace SystemOfUnitsTests.Frequency.Hertz {
    using Centihertz = SystemOfUnits.Frequency.Hertz.Centihertz;

    partial class CentihertzTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+006)]
        public void Should_cast_from_Kilohertz(double kilohertzValue, double expectedValue) {
            var kilohertzInstance = new SystemOfUnits.Frequency.Hertz.Kilohertz(kilohertzValue);

            Centihertz actual = kilohertzInstance;
            Assert.IsAssignableFrom<Centihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+005)]
        public void Should_cast_from_Hectohertz(double hectohertzValue, double expectedValue) {
            var hectohertzInstance = new SystemOfUnits.Frequency.Hertz.Hectohertz(hectohertzValue);

            Centihertz actual = hectohertzInstance;
            Assert.IsAssignableFrom<Centihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+004)]
        public void Should_cast_from_Decahertz(double decahertzValue, double expectedValue) {
            var decahertzInstance = new SystemOfUnits.Frequency.Hertz.Decahertz(decahertzValue);

            Centihertz actual = decahertzInstance;
            Assert.IsAssignableFrom<Centihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+003)]
        public void Should_cast_from_Hertz(double hertzValue, double expectedValue) {
            var hertzInstance = new SystemOfUnits.Frequency.Hertz.Hertz(hertzValue);

            Centihertz actual = hertzInstance;
            Assert.IsAssignableFrom<Centihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+002)]
        public void Should_cast_from_Decihertz(double decihertzValue, double expectedValue) {
            var decihertzInstance = new SystemOfUnits.Frequency.Hertz.Decihertz(decihertzValue);

            Centihertz actual = decihertzInstance;
            Assert.IsAssignableFrom<Centihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+000)]
        public void Should_cast_from_Millihertz(double millihertzValue, double expectedValue) {
            var millihertzInstance = new SystemOfUnits.Frequency.Hertz.Millihertz(millihertzValue);

            Centihertz actual = millihertzInstance;
            Assert.IsAssignableFrom<Centihertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
