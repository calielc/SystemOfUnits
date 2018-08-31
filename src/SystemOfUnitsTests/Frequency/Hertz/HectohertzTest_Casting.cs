using NUnit.Framework;

namespace SystemOfUnitsTests.Frequency.Hertz {
    using Hectohertz = SystemOfUnits.Frequency.Hertz.Hectohertz;

    partial class HectohertzTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+006)]
        public void Should_cast_from_Kilohertz(double kilohertzValue, double expectedValue) {
            var kilohertzInstance = new SystemOfUnits.Frequency.Hertz.Kilohertz(kilohertzValue);

            Hectohertz actual = kilohertzInstance;
            Assert.IsAssignableFrom<Hectohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+004)]
        public void Should_cast_from_Decahertz(double decahertzValue, double expectedValue) {
            var decahertzInstance = new SystemOfUnits.Frequency.Hertz.Decahertz(decahertzValue);

            Hectohertz actual = decahertzInstance;
            Assert.IsAssignableFrom<Hectohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+003)]
        public void Should_cast_from_Hertz(double hertzValue, double expectedValue) {
            var hertzInstance = new SystemOfUnits.Frequency.Hertz.Hertz(hertzValue);

            Hectohertz actual = hertzInstance;
            Assert.IsAssignableFrom<Hectohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+002)]
        public void Should_cast_from_Decihertz(double decihertzValue, double expectedValue) {
            var decihertzInstance = new SystemOfUnits.Frequency.Hertz.Decihertz(decihertzValue);

            Hectohertz actual = decihertzInstance;
            Assert.IsAssignableFrom<Hectohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+001)]
        public void Should_cast_from_Centihertz(double centihertzValue, double expectedValue) {
            var centihertzInstance = new SystemOfUnits.Frequency.Hertz.Centihertz(centihertzValue);

            Hectohertz actual = centihertzInstance;
            Assert.IsAssignableFrom<Hectohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+000)]
        public void Should_cast_from_Millihertz(double millihertzValue, double expectedValue) {
            var millihertzInstance = new SystemOfUnits.Frequency.Hertz.Millihertz(millihertzValue);

            Hectohertz actual = millihertzInstance;
            Assert.IsAssignableFrom<Hectohertz>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
