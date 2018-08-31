using NUnit.Framework;

namespace SystemOfUnitsTests.Energy.Joule {
    using Centijoule = SystemOfUnits.Energy.Joule.Centijoule;

    partial class CentijouleTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+006)]
        public void Should_cast_from_Kilojoule(double kilojouleValue, double expectedValue) {
            var kilojouleInstance = new SystemOfUnits.Energy.Joule.Kilojoule(kilojouleValue);

            Centijoule actual = kilojouleInstance;
            Assert.IsAssignableFrom<Centijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+005)]
        public void Should_cast_from_Hectojoule(double hectojouleValue, double expectedValue) {
            var hectojouleInstance = new SystemOfUnits.Energy.Joule.Hectojoule(hectojouleValue);

            Centijoule actual = hectojouleInstance;
            Assert.IsAssignableFrom<Centijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+004)]
        public void Should_cast_from_Decajoule(double decajouleValue, double expectedValue) {
            var decajouleInstance = new SystemOfUnits.Energy.Joule.Decajoule(decajouleValue);

            Centijoule actual = decajouleInstance;
            Assert.IsAssignableFrom<Centijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+003)]
        public void Should_cast_from_Joule(double jouleValue, double expectedValue) {
            var jouleInstance = new SystemOfUnits.Energy.Joule.Joule(jouleValue);

            Centijoule actual = jouleInstance;
            Assert.IsAssignableFrom<Centijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+002)]
        public void Should_cast_from_Decijoule(double decijouleValue, double expectedValue) {
            var decijouleInstance = new SystemOfUnits.Energy.Joule.Decijoule(decijouleValue);

            Centijoule actual = decijouleInstance;
            Assert.IsAssignableFrom<Centijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e-001,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e-002, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-005,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+001,  2.000000000000000e+000)]
        public void Should_cast_from_Millijoule(double millijouleValue, double expectedValue) {
            var millijouleInstance = new SystemOfUnits.Energy.Joule.Millijoule(millijouleValue);

            Centijoule actual = millijouleInstance;
            Assert.IsAssignableFrom<Centijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
