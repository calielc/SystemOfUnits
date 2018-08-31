using NUnit.Framework;
using System;

namespace SystemOfUnitsTests.Time {
    using Month = SystemOfUnits.Time.Month;

    public partial class MonthTest {
        private const double DaysPerMonth = 365.2425d / 12;

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_from_TimeSpan(double value) {
            var expected = new Month(value);

            var instance = TimeSpan.FromDays(DaysPerMonth * value);
            Month actual = instance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_to_TimeSpan(double value) {
            var expected = TimeSpan.FromDays(DaysPerMonth * value);

            var instance = new Month(value);
            TimeSpan actual = instance;

            Assert.AreEqual(expected, actual);
        }
    }
}
