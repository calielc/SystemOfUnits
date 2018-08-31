using NUnit.Framework;
using System;

namespace SystemOfUnitsTests.Time {
    using Week = SystemOfUnits.Time.Week;

    public partial class WeekTest {
        private const double DaysPerWeek = 7d;

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_from_TimeSpan(double value) {
            var expected = new Week(value);

            var instance = TimeSpan.FromDays(DaysPerWeek * value);
            Week actual = instance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_to_TimeSpan(double value) {
            var expected = TimeSpan.FromDays(DaysPerWeek * value);

            var instance = new Week(value);
            TimeSpan actual = instance;

            Assert.AreEqual(expected, actual);
        }
    }
}
