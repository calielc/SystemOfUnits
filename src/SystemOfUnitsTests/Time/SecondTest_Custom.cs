using NUnit.Framework;
using System;

namespace SystemOfUnitsTests.Time {
    using Second = SystemOfUnits.Time.Second;

    public partial class SecondTest {
        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.7579e2)]
        public void Should_convert_from_TimeSpan(double value) {
            var expected = new Second(value);

            var instance = TimeSpan.FromSeconds(value);
            Second actual = instance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_to_TimeSpan(double value) {
            var expected = TimeSpan.FromSeconds(value);

            var instance = new Second(value);
            TimeSpan actual = instance;

            Assert.AreEqual(expected, actual);
        }
    }
}
