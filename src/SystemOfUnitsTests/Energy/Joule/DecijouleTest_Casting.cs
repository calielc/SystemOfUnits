using NUnit.Framework;

namespace SystemOfUnitsTests.Energy.Joule {
    using Decijoule = SystemOfUnits.Energy.Joule.Decijoule;

    partial class DecijouleTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+006)]
        public void Should_cast_from_Kilojoule(double kilojouleValue, double expectedValue) {
            var kilojouleInstance = new SystemOfUnits.Energy.Joule.Kilojoule(kilojouleValue);

            Decijoule actual = kilojouleInstance;
            Assert.IsAssignableFrom<Decijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+005)]
        public void Should_cast_from_Hectojoule(double hectojouleValue, double expectedValue) {
            var hectojouleInstance = new SystemOfUnits.Energy.Joule.Hectojoule(hectojouleValue);

            Decijoule actual = hectojouleInstance;
            Assert.IsAssignableFrom<Decijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+002)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+001)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-002)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+004)]
        public void Should_cast_from_Decajoule(double decajouleValue, double expectedValue) {
            var decajouleInstance = new SystemOfUnits.Energy.Joule.Decajoule(decajouleValue);

            Decijoule actual = decajouleInstance;
            Assert.IsAssignableFrom<Decijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+003)]
        public void Should_cast_from_Joule(double jouleValue, double expectedValue) {
            var jouleInstance = new SystemOfUnits.Energy.Joule.Joule(jouleValue);

            Decijoule actual = jouleInstance;
            Assert.IsAssignableFrom<Decijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+001)]
        public void Should_cast_from_Centijoule(double centijouleValue, double expectedValue) {
            var centijouleInstance = new SystemOfUnits.Energy.Joule.Centijoule(centijouleValue);

            Decijoule actual = centijouleInstance;
            Assert.IsAssignableFrom<Decijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+000,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e-001, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-004,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+002,  2.000000000000000e+000)]
        public void Should_cast_from_Millijoule(double millijouleValue, double expectedValue) {
            var millijouleInstance = new SystemOfUnits.Energy.Joule.Millijoule(millijouleValue);

            Decijoule actual = millijouleInstance;
            Assert.IsAssignableFrom<Decijoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
