using NUnit.Framework;

namespace SystemOfUnitsTests.Energy.Joule {
    using Hectojoule = SystemOfUnits.Energy.Joule.Hectojoule;

    partial class HectojouleTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+006)]
        public void Should_cast_from_Kilojoule(double kilojouleValue, double expectedValue) {
            var kilojouleInstance = new SystemOfUnits.Energy.Joule.Kilojoule(kilojouleValue);

            Hectojoule actual = kilojouleInstance;
            Assert.IsAssignableFrom<Hectojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+004)]
        public void Should_cast_from_Decajoule(double decajouleValue, double expectedValue) {
            var decajouleInstance = new SystemOfUnits.Energy.Joule.Decajoule(decajouleValue);

            Hectojoule actual = decajouleInstance;
            Assert.IsAssignableFrom<Hectojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+003)]
        public void Should_cast_from_Joule(double jouleValue, double expectedValue) {
            var jouleInstance = new SystemOfUnits.Energy.Joule.Joule(jouleValue);

            Hectojoule actual = jouleInstance;
            Assert.IsAssignableFrom<Hectojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+002)]
        public void Should_cast_from_Decijoule(double decijouleValue, double expectedValue) {
            var decijouleInstance = new SystemOfUnits.Energy.Joule.Decijoule(decijouleValue);

            Hectojoule actual = decijouleInstance;
            Assert.IsAssignableFrom<Hectojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+001)]
        public void Should_cast_from_Centijoule(double centijouleValue, double expectedValue) {
            var centijouleInstance = new SystemOfUnits.Energy.Joule.Centijoule(centijouleValue);

            Hectojoule actual = centijouleInstance;
            Assert.IsAssignableFrom<Hectojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+003,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-001,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+005,  2.000000000000000e+000)]
        public void Should_cast_from_Millijoule(double millijouleValue, double expectedValue) {
            var millijouleInstance = new SystemOfUnits.Energy.Joule.Millijoule(millijouleValue);

            Hectojoule actual = millijouleInstance;
            Assert.IsAssignableFrom<Hectojoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
