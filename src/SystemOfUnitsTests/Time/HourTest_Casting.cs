using NUnit.Framework;

namespace SystemOfUnitsTests.Time {
    using Hour = SystemOfUnits.Time.Hour;

    partial class HourTest {
        [TestCase(0d, 0d)]
        [TestCase(0.000114079458624521d, 1d)]
        [TestCase(0.00273790700698851d, 24d)]
        public void Should_cast_from_Year(double yearValue, double expectedValue) {
            var yearInstance = new SystemOfUnits.Time.Year(yearValue);

            Hour actual = yearInstance;
            Assert.IsAssignableFrom<Hour>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.00136895350349425d, 1d)]
        [TestCase(0.0328548840838621d, 24d)]
        public void Should_cast_from_Month(double monthValue, double expectedValue) {
            var monthInstance = new SystemOfUnits.Time.Month(monthValue);

            Hour actual = monthInstance;
            Assert.IsAssignableFrom<Hour>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.00595238095238095d, 1d)]
        [TestCase(0.142857142857143d, 24d)]
        public void Should_cast_from_Week(double weekValue, double expectedValue) {
            var weekInstance = new SystemOfUnits.Time.Week(weekValue);

            Hour actual = weekInstance;
            Assert.IsAssignableFrom<Hour>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.0416666666666667d, 1d)]
        [TestCase(1d, 24d)]
        public void Should_cast_from_Day(double dayValue, double expectedValue) {
            var dayInstance = new SystemOfUnits.Time.Day(dayValue);

            Hour actual = dayInstance;
            Assert.IsAssignableFrom<Hour>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(60d, 1d)]
        [TestCase(1440d, 24d)]
        public void Should_cast_from_Minute(double minuteValue, double expectedValue) {
            var minuteInstance = new SystemOfUnits.Time.Minute(minuteValue);

            Hour actual = minuteInstance;
            Assert.IsAssignableFrom<Hour>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(3600d, 1d)]
        [TestCase(86400d, 24d)]
        public void Should_cast_from_Second(double secondValue, double expectedValue) {
            var secondInstance = new SystemOfUnits.Time.Second(secondValue);

            Hour actual = secondInstance;
            Assert.IsAssignableFrom<Hour>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(3600000d, 1d)]
        [TestCase(86400000d, 24d)]
        public void Should_cast_from_Millisecond(double millisecondValue, double expectedValue) {
            var millisecondInstance = new SystemOfUnits.Time.Millisecond(millisecondValue);

            Hour actual = millisecondInstance;
            Assert.IsAssignableFrom<Hour>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
