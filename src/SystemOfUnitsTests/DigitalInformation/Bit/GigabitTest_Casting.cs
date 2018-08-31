using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Bit {
    using Gigabit = SystemOfUnits.DigitalInformation.Bit.Gigabit;

    partial class GigabitTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+013)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+006)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e+000)]
        public void Should_cast_from_Terabit(double terabitValue, double expectedValue) {
            var terabitInstance = new SystemOfUnits.DigitalInformation.Bit.Terabit(terabitValue);

            Gigabit actual = terabitInstance;
            Assert.IsAssignableFrom<Gigabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-006)]
        public void Should_cast_from_Megabit(double megabitValue, double expectedValue) {
            var megabitInstance = new SystemOfUnits.DigitalInformation.Bit.Megabit(megabitValue);

            Gigabit actual = megabitInstance;
            Assert.IsAssignableFrom<Gigabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-009)]
        public void Should_cast_from_Kilobit(double kilobitValue, double expectedValue) {
            var kilobitInstance = new SystemOfUnits.DigitalInformation.Bit.Kilobit(kilobitValue);

            Gigabit actual = kilobitInstance;
            Assert.IsAssignableFrom<Gigabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+010,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+003, -5.000000000000000e-006)]
        [TestCase( 1.000000000000000e-003,  1.000000000000000e-012)]
        public void Should_cast_from_Bit(double bitValue, double expectedValue) {
            var bitInstance = new SystemOfUnits.DigitalInformation.Bit.Bit(bitValue);

            Gigabit actual = bitInstance;
            Assert.IsAssignableFrom<Gigabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
