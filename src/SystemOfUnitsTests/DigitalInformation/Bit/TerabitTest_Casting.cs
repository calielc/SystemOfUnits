using NUnit.Framework;

namespace SystemOfUnitsTests.DigitalInformation.Bit {
    using Terabit = SystemOfUnits.DigitalInformation.Bit.Terabit;

    partial class TerabitTest {
        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+013,  1.370000000000000e+010)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+003)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-003)]
        public void Should_cast_from_Gigabit(double gigabitValue, double expectedValue) {
            var gigabitInstance = new SystemOfUnits.DigitalInformation.Bit.Gigabit(gigabitValue);

            Terabit actual = gigabitInstance;
            Assert.IsAssignableFrom<Terabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+013,  1.370000000000000e+007)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e+000)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-006)]
        public void Should_cast_from_Megabit(double megabitValue, double expectedValue) {
            var megabitInstance = new SystemOfUnits.DigitalInformation.Bit.Megabit(megabitValue);

            Terabit actual = megabitInstance;
            Assert.IsAssignableFrom<Terabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+013,  1.370000000000000e+004)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e-003)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-009)]
        public void Should_cast_from_Kilobit(double kilobitValue, double expectedValue) {
            var kilobitInstance = new SystemOfUnits.DigitalInformation.Bit.Kilobit(kilobitValue);

            Terabit actual = kilobitInstance;
            Assert.IsAssignableFrom<Terabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }

        [TestCase( 0.000000000000000e+000,  0.000000000000000e+000)]
        [TestCase( 1.370000000000000e+013,  1.370000000000000e+001)]
        [TestCase(-5.000000000000000e+006, -5.000000000000000e-006)]
        [TestCase( 1.000000000000000e+000,  1.000000000000000e-012)]
        public void Should_cast_from_Bit(double bitValue, double expectedValue) {
            var bitInstance = new SystemOfUnits.DigitalInformation.Bit.Bit(bitValue);

            Terabit actual = bitInstance;
            Assert.IsAssignableFrom<Terabit>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue.ToString("E"), actualValue.ToString("E"));
        }
   }
}
