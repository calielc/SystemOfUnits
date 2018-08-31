using NUnit.Framework;

namespace SystemOfUnitsTests.Time {
    using Second = SystemOfUnits.Time.Second;

    partial class SecondTest {
        [TestCase(0d, 0d)]
        [TestCase(3.16887385068114E-08d, 1d)]
        [TestCase(0.00273790700698851d, 86400d)]
        public void Should_cast_from_Year(double yearValue, double expectedValue) {
            var yearInstance = new SystemOfUnits.Time.Year(yearValue);

            Second actual = yearInstance;
            Assert.IsAssignableFrom<Second>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(3.80264862081737E-07d, 1d)]
        [TestCase(0.0328548840838621d, 86400d)]
        public void Should_cast_from_Month(double monthValue, double expectedValue) {
            var monthInstance = new SystemOfUnits.Time.Month(monthValue);

            Second actual = monthInstance;
            Assert.IsAssignableFrom<Second>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1.65343915343915E-06d, 1d)]
        [TestCase(0.142857142857143d, 86400d)]
        public void Should_cast_from_Week(double weekValue, double expectedValue) {
            var weekInstance = new SystemOfUnits.Time.Week(weekValue);

            Second actual = weekInstance;
            Assert.IsAssignableFrom<Second>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1.15740740740741E-05d, 1d)]
        [TestCase(1d, 86400d)]
        public void Should_cast_from_Day(double dayValue, double expectedValue) {
            var dayInstance = new SystemOfUnits.Time.Day(dayValue);

            Second actual = dayInstance;
            Assert.IsAssignableFrom<Second>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.000277777777777778d, 1d)]
        [TestCase(24d, 86400d)]
        public void Should_cast_from_Hour(double hourValue, double expectedValue) {
            var hourInstance = new SystemOfUnits.Time.Hour(hourValue);

            Second actual = hourInstance;
            Assert.IsAssignableFrom<Second>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.0166666666666667d, 1d)]
        [TestCase(1440d, 86400d)]
        public void Should_cast_from_Minute(double minuteValue, double expectedValue) {
            var minuteInstance = new SystemOfUnits.Time.Minute(minuteValue);

            Second actual = minuteInstance;
            Assert.IsAssignableFrom<Second>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1000d, 1d)]
        [TestCase(86400000d, 86400d)]
        public void Should_cast_from_Millisecond(double millisecondValue, double expectedValue) {
            var millisecondInstance = new SystemOfUnits.Time.Millisecond(millisecondValue);

            Second actual = millisecondInstance;
            Assert.IsAssignableFrom<Second>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
