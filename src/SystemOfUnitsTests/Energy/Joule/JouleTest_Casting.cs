using NUnit.Framework;

namespace SystemOfUnitsTests.Energy.Joule {
    using Joule = SystemOfUnits.Energy.Joule.Joule;

    partial class JouleTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+006)]
        public void Should_cast_from_Kilojoule(double kilojouleValue, double expectedValue) {
            var kilojouleInstance = new SystemOfUnits.Energy.Joule.Kilojoule(kilojouleValue);

            Joule actual = kilojouleInstance;
            Assert.IsAssignableFrom<Joule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+005)]
        public void Should_cast_from_Hectojoule(double hectojouleValue, double expectedValue) {
            var hectojouleInstance = new SystemOfUnits.Energy.Joule.Hectojoule(hectojouleValue);

            Joule actual = hectojouleInstance;
            Assert.IsAssignableFrom<Joule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+004)]
        public void Should_cast_from_Decajoule(double decajouleValue, double expectedValue) {
            var decajouleInstance = new SystemOfUnits.Energy.Joule.Decajoule(decajouleValue);

            Joule actual = decajouleInstance;
            Assert.IsAssignableFrom<Joule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+002)]
        public void Should_cast_from_Decijoule(double decijouleValue, double expectedValue) {
            var decijouleInstance = new SystemOfUnits.Energy.Joule.Decijoule(decijouleValue);

            Joule actual = decijouleInstance;
            Assert.IsAssignableFrom<Joule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+001)]
        public void Should_cast_from_Centijoule(double centijouleValue, double expectedValue) {
            var centijouleInstance = new SystemOfUnits.Energy.Joule.Centijoule(centijouleValue);

            Joule actual = centijouleInstance;
            Assert.IsAssignableFrom<Joule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+003,  2.000000000000000e+000)]
        public void Should_cast_from_Millijoule(double millijouleValue, double expectedValue) {
            var millijouleInstance = new SystemOfUnits.Energy.Joule.Millijoule(millijouleValue);

            Joule actual = millijouleInstance;
            Assert.IsAssignableFrom<Joule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
