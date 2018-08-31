using NUnit.Framework;

namespace SystemOfUnitsTests.Time {
    using Day = SystemOfUnits.Time.Day;

    partial class DayTest {
        [TestCase(0d, 0d)]
        [TestCase(0.00273790700698851d, 1d)]
        [TestCase(0.0833333333333333d, 30.436875d)]
        [TestCase(1d, 365.2425d)]
        public void Should_cast_from_Year(double yearValue, double expectedValue) {
            var yearInstance = new SystemOfUnits.Time.Year(yearValue);

            Day actual = yearInstance;
            Assert.IsAssignableFrom<Day>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.0328548840838621d, 1d)]
        [TestCase(1d, 30.436875d)]
        [TestCase(12d, 365.2425d)]
        public void Should_cast_from_Month(double monthValue, double expectedValue) {
            var monthInstance = new SystemOfUnits.Time.Month(monthValue);

            Day actual = monthInstance;
            Assert.IsAssignableFrom<Day>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.142857142857143d, 1d)]
        [TestCase(4.348125d, 30.436875d)]
        [TestCase(52.1775d, 365.2425d)]
        public void Should_cast_from_Week(double weekValue, double expectedValue) {
            var weekInstance = new SystemOfUnits.Time.Week(weekValue);

            Day actual = weekInstance;
            Assert.IsAssignableFrom<Day>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(24d, 1d)]
        [TestCase(730.485d, 30.436875d)]
        [TestCase(8765.82d, 365.2425d)]
        public void Should_cast_from_Hour(double hourValue, double expectedValue) {
            var hourInstance = new SystemOfUnits.Time.Hour(hourValue);

            Day actual = hourInstance;
            Assert.IsAssignableFrom<Day>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1440d, 1d)]
        [TestCase(43829.1d, 30.436875d)]
        [TestCase(525949.2d, 365.2425d)]
        public void Should_cast_from_Minute(double minuteValue, double expectedValue) {
            var minuteInstance = new SystemOfUnits.Time.Minute(minuteValue);

            Day actual = minuteInstance;
            Assert.IsAssignableFrom<Day>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(86400d, 1d)]
        [TestCase(2629746d, 30.436875d)]
        [TestCase(31556952d, 365.2425d)]
        public void Should_cast_from_Second(double secondValue, double expectedValue) {
            var secondInstance = new SystemOfUnits.Time.Second(secondValue);

            Day actual = secondInstance;
            Assert.IsAssignableFrom<Day>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(86400000d, 1d)]
        [TestCase(2629746000d, 30.436875d)]
        [TestCase(31556952000d, 365.2425d)]
        public void Should_cast_from_Millisecond(double millisecondValue, double expectedValue) {
            var millisecondInstance = new SystemOfUnits.Time.Millisecond(millisecondValue);

            Day actual = millisecondInstance;
            Assert.IsAssignableFrom<Day>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
