using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Bit {
    using Kilobit = SystemOfUnits.DigitalInformation.Bit.Kilobit;

    partial class KilobitTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+006)]
        [TestCase( 1.000000000000000e-009,  1.000000000000000e+000)]
        public void Should_cast_from_Terabit(double terabitValue, double expectedValue) {
            var terabitInstance = new SystemOfUnits.DigitalInformation.Bit.Terabit(terabitValue);

            Kilobit actual = terabitInstance;
            Assert.IsAssignableFrom<Kilobit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+010)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e-009,  1.000000000000000e-003)]
        public void Should_cast_from_Gigabit(double gigabitValue, double expectedValue) {
            var gigabitInstance = new SystemOfUnits.DigitalInformation.Bit.Gigabit(gigabitValue);

            Kilobit actual = gigabitInstance;
            Assert.IsAssignableFrom<Kilobit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-009,  1.000000000000000e-006)]
        public void Should_cast_from_Megabit(double megabitValue, double expectedValue) {
            var megabitInstance = new SystemOfUnits.DigitalInformation.Bit.Megabit(megabitValue);

            Kilobit actual = megabitInstance;
            Assert.IsAssignableFrom<Kilobit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+004,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e-003, -5.000000000000000e-006)]
        [TestCase( 1.000000000000000e-009,  1.000000000000000e-012)]
        public void Should_cast_from_Bit(double bitValue, double expectedValue) {
            var bitInstance = new SystemOfUnits.DigitalInformation.Bit.Bit(bitValue);

            Kilobit actual = bitInstance;
            Assert.IsAssignableFrom<Kilobit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
