using NUnit.Framework;
using System;

namespace SystemOfUnitsTests.Time {
    using Year = SystemOfUnits.Time.Year;

    public partial class YearTest {
        private const double DaysPerYear = 365.2425d;

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_from_TimeSpan(double value) {
            var expected = new Year(value);

            var instance = TimeSpan.FromDays(DaysPerYear * value);
            Year actual = instance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_to_TimeSpan(double value) {
            var expected = TimeSpan.FromDays(DaysPerYear * value);

            var instance = new Year(value);
            TimeSpan actual = instance;

            Assert.AreEqual(expected, actual);
        }
    }
}
