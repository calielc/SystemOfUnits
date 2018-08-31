using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Bit {
    using Bit = SystemOfUnits.DigitalInformation.Bit.Bit;

    partial class BitTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+006)]
        [TestCase( 1.000000000000000e-012,  1.000000000000000e+000)]
        public void Should_cast_from_Terabit(double terabitValue, double expectedValue) {
            var terabitInstance = new SystemOfUnits.DigitalInformation.Bit.Terabit(terabitValue);

            Bit actual = terabitInstance;
            Assert.IsAssignableFrom<Bit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+010)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-012,  1.000000000000000e-003)]
        public void Should_cast_from_Gigabit(double gigabitValue, double expectedValue) {
            var gigabitInstance = new SystemOfUnits.DigitalInformation.Bit.Gigabit(gigabitValue);

            Bit actual = gigabitInstance;
            Assert.IsAssignableFrom<Bit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-012,  1.000000000000000e-006)]
        public void Should_cast_from_Megabit(double megabitValue, double expectedValue) {
            var megabitInstance = new SystemOfUnits.DigitalInformation.Bit.Megabit(megabitValue);

            Bit actual = megabitInstance;
            Assert.IsAssignableFrom<Bit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+001,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e-006, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-012,  1.000000000000000e-009)]
        public void Should_cast_from_Kilobit(double kilobitValue, double expectedValue) {
            var kilobitInstance = new SystemOfUnits.DigitalInformation.Bit.Kilobit(kilobitValue);

            Bit actual = kilobitInstance;
            Assert.IsAssignableFrom<Bit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
