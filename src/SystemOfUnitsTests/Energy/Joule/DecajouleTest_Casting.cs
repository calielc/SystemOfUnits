using NUnit.Framework;

namespace SystemOfUnitsTests.Energy.Joule {
    using Decajoule = SystemOfUnits.Energy.Joule.Decajoule;

    partial class DecajouleTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e+000)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+006)]
        public void Should_cast_from_Kilojoule(double kilojouleValue, double expectedValue) {
            var kilojouleInstance = new SystemOfUnits.Energy.Joule.Kilojoule(kilojouleValue);

            Decajoule actual = kilojouleInstance;
            Assert.IsAssignableFrom<Decajoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+003)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+002)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-001)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+005)]
        public void Should_cast_from_Hectojoule(double hectojouleValue, double expectedValue) {
            var hectojouleInstance = new SystemOfUnits.Energy.Joule.Hectojoule(hectojouleValue);

            Decajoule actual = hectojouleInstance;
            Assert.IsAssignableFrom<Decajoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-003)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+003)]
        public void Should_cast_from_Joule(double jouleValue, double expectedValue) {
            var jouleInstance = new SystemOfUnits.Energy.Joule.Joule(jouleValue);

            Decajoule actual = jouleInstance;
            Assert.IsAssignableFrom<Decajoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e+000)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-001)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-004)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+002)]
        public void Should_cast_from_Decijoule(double decijouleValue, double expectedValue) {
            var decijouleInstance = new SystemOfUnits.Energy.Joule.Decijoule(decijouleValue);

            Decajoule actual = decijouleInstance;
            Assert.IsAssignableFrom<Decajoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-001)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-002)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-005)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+001)]
        public void Should_cast_from_Centijoule(double centijouleValue, double expectedValue) {
            var centijouleInstance = new SystemOfUnits.Energy.Joule.Centijoule(centijouleValue);

            Decajoule actual = centijouleInstance;
            Assert.IsAssignableFrom<Decajoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+002,  1.370000000000000e-002)]
        [TestCase(-5.000000000000000e+001, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-002,  1.000000000000000e-006)]
        [TestCase( 2.000000000000000e+004,  2.000000000000000e+000)]
        public void Should_cast_from_Millijoule(double millijouleValue, double expectedValue) {
            var millijouleInstance = new SystemOfUnits.Energy.Joule.Millijoule(millijouleValue);

            Decajoule actual = millijouleInstance;
            Assert.IsAssignableFrom<Decajoule>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
