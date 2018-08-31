using NUnit.Framework;

namespace SystemOfUnitsTests.Energy.Joule {
    using Kilojoule = SystemOfUnits.Energy.Joule.Kilojoule;

    partial class KilojouleTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+005)]
        public void Should_cast_from_Hectojoule(double hectojouleValue, double expectedValue) {
            var hectojouleInstance = new SystemOfUnits.Energy.Joule.Hectojoule(hectojouleValue);

            Kilojoule actual = hectojouleInstance;
            Assert.IsAssignableFrom<Kilojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+004)]
        public void Should_cast_from_Decajoule(double decajouleValue, double expectedValue) {
            var decajouleInstance = new SystemOfUnits.Energy.Joule.Decajoule(decajouleValue);

            Kilojoule actual = decajouleInstance;
            Assert.IsAssignableFrom<Kilojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+003)]
        public void Should_cast_from_Joule(double jouleValue, double expectedValue) {
            var jouleInstance = new SystemOfUnits.Energy.Joule.Joule(jouleValue);

            Kilojoule actual = jouleInstance;
            Assert.IsAssignableFrom<Kilojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+002)]
        public void Should_cast_from_Decijoule(double decijouleValue, double expectedValue) {
            var decijouleInstance = new SystemOfUnits.Energy.Joule.Decijoule(decijouleValue);

            Kilojoule actual = decijouleInstance;
            Assert.IsAssignableFrom<Kilojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+001)]
        public void Should_cast_from_Centijoule(double centijouleValue, double expectedValue) {
            var centijouleInstance = new SystemOfUnits.Energy.Joule.Centijoule(centijouleValue);

            Kilojoule actual = centijouleInstance;
            Assert.IsAssignableFrom<Kilojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+006,  2.000000000000000e+000)]
        public void Should_cast_from_Millijoule(double millijouleValue, double expectedValue) {
            var millijouleInstance = new SystemOfUnits.Energy.Joule.Millijoule(millijouleValue);

            Kilojoule actual = millijouleInstance;
            Assert.IsAssignableFrom<Kilojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
