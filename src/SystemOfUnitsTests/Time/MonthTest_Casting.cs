using NUnit.Framework;

namespace SystemOfUnitsTests.Time {
    using Month = SystemOfUnits.Time.Month;

    partial class MonthTest {
        [TestCase(0d, 0d)]
        [TestCase(0.0833333333333333d, 1d)]
        [TestCase(1d, 12d)]
        public void Should_cast_from_Year(double yearValue, double expectedValue) {
            var yearInstance = new SystemOfUnits.Time.Year(yearValue);

            Month actual = yearInstance;
            Assert.IsAssignableFrom<Month>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(4.348125d, 1d)]
        [TestCase(52.1775d, 12d)]
        public void Should_cast_from_Week(double weekValue, double expectedValue) {
            var weekInstance = new SystemOfUnits.Time.Week(weekValue);

            Month actual = weekInstance;
            Assert.IsAssignableFrom<Month>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(30.436875d, 1d)]
        [TestCase(365.2425d, 12d)]
        public void Should_cast_from_Day(double dayValue, double expectedValue) {
            var dayInstance = new SystemOfUnits.Time.Day(dayValue);

            Month actual = dayInstance;
            Assert.IsAssignableFrom<Month>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(730.485d, 1d)]
        [TestCase(8765.82d, 12d)]
        public void Should_cast_from_Hour(double hourValue, double expectedValue) {
            var hourInstance = new SystemOfUnits.Time.Hour(hourValue);

            Month actual = hourInstance;
            Assert.IsAssignableFrom<Month>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(43829.1d, 1d)]
        [TestCase(525949.2d, 12d)]
        public void Should_cast_from_Minute(double minuteValue, double expectedValue) {
            var minuteInstance = new SystemOfUnits.Time.Minute(minuteValue);

            Month actual = minuteInstance;
            Assert.IsAssignableFrom<Month>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(2629746d, 1d)]
        [TestCase(31556952d, 12d)]
        public void Should_cast_from_Second(double secondValue, double expectedValue) {
            var secondInstance = new SystemOfUnits.Time.Second(secondValue);

            Month actual = secondInstance;
            Assert.IsAssignableFrom<Month>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(2629746000d, 1d)]
        [TestCase(31556952000d, 12d)]
        public void Should_cast_from_Millisecond(double millisecondValue, double expectedValue) {
            var millisecondInstance = new SystemOfUnits.Time.Millisecond(millisecondValue);

            Month actual = millisecondInstance;
            Assert.IsAssignableFrom<Month>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
