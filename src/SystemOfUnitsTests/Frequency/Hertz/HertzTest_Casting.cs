using NUnit.Framework;

namespace SystemOfUnitsTests.Frequency.Hertz {
    using Hertz = SystemOfUnits.Frequency.Hertz.Hertz;

    partial class HertzTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+006)]
        public void Should_cast_from_Kilohertz(double kilohertzValue, double expectedValue) {
            var kilohertzInstance = new SystemOfUnits.Frequency.Hertz.Kilohertz(kilohertzValue);

            Hertz actual = kilohertzInstance;
            Assert.IsAssignableFrom<Hertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+005)]
        public void Should_cast_from_Hectohertz(double hectohertzValue, double expectedValue) {
            var hectohertzInstance = new SystemOfUnits.Frequency.Hertz.Hectohertz(hectohertzValue);

            Hertz actual = hectohertzInstance;
            Assert.IsAssignableFrom<Hertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+004)]
        public void Should_cast_from_Decahertz(double decahertzValue, double expectedValue) {
            var decahertzInstance = new SystemOfUnits.Frequency.Hertz.Decahertz(decahertzValue);

            Hertz actual = decahertzInstance;
            Assert.IsAssignableFrom<Hertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+002)]
        public void Should_cast_from_Decihertz(double decihertzValue, double expectedValue) {
            var decihertzInstance = new SystemOfUnits.Frequency.Hertz.Decihertz(decihertzValue);

            Hertz actual = decihertzInstance;
            Assert.IsAssignableFrom<Hertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+001)]
        public void Should_cast_from_Centihertz(double centihertzValue, double expectedValue) {
            var centihertzInstance = new SystemOfUnits.Frequency.Hertz.Centihertz(centihertzValue);

            Hertz actual = centihertzInstance;
            Assert.IsAssignableFrom<Hertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+000)]
        public void Should_cast_from_Millihertz(double millihertzValue, double expectedValue) {
            var millihertzInstance = new SystemOfUnits.Frequency.Hertz.Millihertz(millihertzValue);

            Hertz actual = millihertzInstance;
            Assert.IsAssignableFrom<Hertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
