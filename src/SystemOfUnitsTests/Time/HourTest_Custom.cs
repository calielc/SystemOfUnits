using NUnit.Framework;
using System;

namespace SystemOfUnitsTests.Time {
    using Day = SystemOfUnits.Time.Day;

    public partial class DayTest {
        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_from_TimeSpan(double value) {
            var expected = new Day(value);

            var instance = TimeSpan.FromDays(value);
            Day actual = instance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_to_TimeSpan(double value) {
            var expected = TimeSpan.FromDays(value);

            var instance = new Day(value);
            TimeSpan actual = instance;

            Assert.AreEqual(expected, actual);
        }
    }
}
