using NUnit.Framework;
using System;

namespace SystemOfUnitsTests.Time {
    using Hour = SystemOfUnits.Time.Hour;

    public partial class HourTest {
        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_from_TimeSpan(double value) {
            var expected = new Hour(value);

            var instance = TimeSpan.FromHours(value);
            Hour actual = instance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_to_TimeSpan(double value) {
            var expected = TimeSpan.FromHours(value);

            var instance = new Hour(value);
            TimeSpan actual = instance;

            Assert.AreEqual(expected, actual);
        }
    }
}
