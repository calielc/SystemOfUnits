using NUnit.Framework;
using System;

namespace SystemOfUnitsTests.Time {
    using Millisecond = SystemOfUnits.Time.Millisecond;

    public partial class MillisecondTest {
        [TestCase(-7)]
        [TestCase(0d)]
        [TestCase(1.76e2)]
        public void Should_convert_from_TimeSpan(double value) {
            var expected = new Millisecond(value);

            var instance = TimeSpan.FromMilliseconds(value);
            Millisecond actual = instance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7)]
        [TestCase(0d)]
        [TestCase(1.76e2)]
        public void Should_convert_to_TimeSpan(double value) {
            var expected = TimeSpan.FromMilliseconds(value);

            var instance = new Millisecond(value);
            TimeSpan actual = instance;

            Assert.AreEqual(expected, actual);
        }
    }
}
