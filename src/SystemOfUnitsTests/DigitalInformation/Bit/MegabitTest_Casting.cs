using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Bit {
    using Megabit = SystemOfUnits.DigitalInformation.Bit.Megabit;

    partial class MegabitTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+006)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e+000)]
        public void Should_cast_from_Terabit(double terabitValue, double expectedValue) {
            var terabitInstance = new SystemOfUnits.DigitalInformation.Bit.Terabit(terabitValue);

            Megabit actual = terabitInstance;
            Assert.IsAssignableFrom<Megabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+010)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-003)]
        public void Should_cast_from_Gigabit(double gigabitValue, double expectedValue) {
            var gigabitInstance = new SystemOfUnits.DigitalInformation.Bit.Gigabit(gigabitValue);

            Megabit actual = gigabitInstance;
            Assert.IsAssignableFrom<Megabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-009)]
        public void Should_cast_from_Kilobit(double kilobitValue, double expectedValue) {
            var kilobitInstance = new SystemOfUnits.DigitalInformation.Bit.Kilobit(kilobitValue);

            Megabit actual = kilobitInstance;
            Assert.IsAssignableFrom<Megabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+007,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+000, -5.000000000000000e-006)]
        [TestCase( 1.000000000000000e-006,  1.000000000000000e-012)]
        public void Should_cast_from_Bit(double bitValue, double expectedValue) {
            var bitInstance = new SystemOfUnits.DigitalInformation.Bit.Bit(bitValue);

            Megabit actual = bitInstance;
            Assert.IsAssignableFrom<Megabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
