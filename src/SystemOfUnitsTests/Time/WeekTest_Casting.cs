using NUnit.Framework;

namespace SystemOfUnitsTests.Time {
    using Week = SystemOfUnits.Time.Week;

    partial class WeekTest {
        [TestCase(0d, 0d)]
        [TestCase(0.0191653490489196d, 1d)]
        [TestCase(1d, 52.1775d)]
        public void Should_cast_from_Year(double yearValue, double expectedValue) {
            var yearInstance = new SystemOfUnits.Time.Year(yearValue);

            Week actual = yearInstance;
            Assert.IsAssignableFrom<Week>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.229984188587035d, 1d)]
        [TestCase(12d, 52.1775d)]
        public void Should_cast_from_Month(double monthValue, double expectedValue) {
            var monthInstance = new SystemOfUnits.Time.Month(monthValue);

            Week actual = monthInstance;
            Assert.IsAssignableFrom<Week>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(7d, 1d)]
        [TestCase(365.2425d, 52.1775d)]
        public void Should_cast_from_Day(double dayValue, double expectedValue) {
            var dayInstance = new SystemOfUnits.Time.Day(dayValue);

            Week actual = dayInstance;
            Assert.IsAssignableFrom<Week>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(168d, 1d)]
        [TestCase(8765.82d, 52.1775d)]
        public void Should_cast_from_Hour(double hourValue, double expectedValue) {
            var hourInstance = new SystemOfUnits.Time.Hour(hourValue);

            Week actual = hourInstance;
            Assert.IsAssignableFrom<Week>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(10080d, 1d)]
        [TestCase(525949.2d, 52.1775d)]
        public void Should_cast_from_Minute(double minuteValue, double expectedValue) {
            var minuteInstance = new SystemOfUnits.Time.Minute(minuteValue);

            Week actual = minuteInstance;
            Assert.IsAssignableFrom<Week>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(604800d, 1d)]
        [TestCase(31556952d, 52.1775d)]
        public void Should_cast_from_Second(double secondValue, double expectedValue) {
            var secondInstance = new SystemOfUnits.Time.Second(secondValue);

            Week actual = secondInstance;
            Assert.IsAssignableFrom<Week>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(604800000d, 1d)]
        [TestCase(31556952000d, 52.1775d)]
        public void Should_cast_from_Millisecond(double millisecondValue, double expectedValue) {
            var millisecondInstance = new SystemOfUnits.Time.Millisecond(millisecondValue);

            Week actual = millisecondInstance;
            Assert.IsAssignableFrom<Week>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
