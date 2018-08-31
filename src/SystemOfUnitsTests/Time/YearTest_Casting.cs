using NUnit.Framework;

namespace SystemOfUnitsTests.Time {
    using Year = SystemOfUnits.Time.Year;

    partial class YearTest {
        [TestCase(0d, 0d)]
        [TestCase(12d, 1d)]
        [TestCase(48d, 4d)]
        public void Should_cast_from_Month(double monthValue, double expectedValue) {
            var monthInstance = new SystemOfUnits.Time.Month(monthValue);

            Year actual = monthInstance;
            Assert.IsAssignableFrom<Year>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(52.1775d, 1d)]
        [TestCase(208.71d, 4d)]
        public void Should_cast_from_Week(double weekValue, double expectedValue) {
            var weekInstance = new SystemOfUnits.Time.Week(weekValue);

            Year actual = weekInstance;
            Assert.IsAssignableFrom<Year>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(365.2425d, 1d)]
        [TestCase(1461d, 4d)]
        public void Should_cast_from_Day(double dayValue, double expectedValue) {
            var dayInstance = new SystemOfUnits.Time.Day(dayValue);

            Year actual = dayInstance;
            Assert.IsAssignableFrom<Year>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(8765.82d, 1d)]
        [TestCase(35064d, 4d)]
        public void Should_cast_from_Hour(double hourValue, double expectedValue) {
            var hourInstance = new SystemOfUnits.Time.Hour(hourValue);

            Year actual = hourInstance;
            Assert.IsAssignableFrom<Year>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(525949.2d, 1d)]
        [TestCase(2103840d, 4d)]
        public void Should_cast_from_Minute(double minuteValue, double expectedValue) {
            var minuteInstance = new SystemOfUnits.Time.Minute(minuteValue);

            Year actual = minuteInstance;
            Assert.IsAssignableFrom<Year>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(31556952d, 1d)]
        [TestCase(126230400d, 4d)]
        public void Should_cast_from_Second(double secondValue, double expectedValue) {
            var secondInstance = new SystemOfUnits.Time.Second(secondValue);

            Year actual = secondInstance;
            Assert.IsAssignableFrom<Year>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(31556952000d, 1d)]
        [TestCase(126230400000d, 4d)]
        public void Should_cast_from_Millisecond(double millisecondValue, double expectedValue) {
            var millisecondInstance = new SystemOfUnits.Time.Millisecond(millisecondValue);

            Year actual = millisecondInstance;
            Assert.IsAssignableFrom<Year>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
