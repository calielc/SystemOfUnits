using NUnit.Framework;
using System;

namespace SystemOfUnitsTests.Time {
    using Minute = SystemOfUnits.Time.Minute;

    public partial class MinuteTest {
        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_from_TimeSpan(double value) {
            var expected = new Minute(value);

            var instance = TimeSpan.FromMinutes(value);
            Minute actual = instance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_to_TimeSpan(double value) {
            var expected = TimeSpan.FromMinutes(value);

            var instance = new Minute(value);
            TimeSpan actual = instance;

            Assert.AreEqual(expected, actual);
        }
    }
}
