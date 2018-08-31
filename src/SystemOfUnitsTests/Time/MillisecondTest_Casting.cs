using NUnit.Framework;

namespace SystemOfUnitsTests.Time {
    using Millisecond = SystemOfUnits.Time.Millisecond;

    partial class MillisecondTest {
        [TestCase(0d, 0d)]
        [TestCase(3.16887385068114E-11d, 1d)]
        [TestCase(0.000114079458624521d, 3600000d)]
        public void Should_cast_from_Year(double yearValue, double expectedValue) {
            var yearInstance = new SystemOfUnits.Time.Year(yearValue);

            Millisecond actual = yearInstance;
            Assert.IsAssignableFrom<Millisecond>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(3.80264862081737E-10d, 1d)]
        [TestCase(0.00136895350349425d, 3600000d)]
        public void Should_cast_from_Month(double monthValue, double expectedValue) {
            var monthInstance = new SystemOfUnits.Time.Month(monthValue);

            Millisecond actual = monthInstance;
            Assert.IsAssignableFrom<Millisecond>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1.65343915343915E-09d, 1d)]
        [TestCase(0.00595238095238095d, 3600000d)]
        public void Should_cast_from_Week(double weekValue, double expectedValue) {
            var weekInstance = new SystemOfUnits.Time.Week(weekValue);

            Millisecond actual = weekInstance;
            Assert.IsAssignableFrom<Millisecond>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1.15740740740741E-08d, 1d)]
        [TestCase(0.0416666666666667d, 3600000d)]
        public void Should_cast_from_Day(double dayValue, double expectedValue) {
            var dayInstance = new SystemOfUnits.Time.Day(dayValue);

            Millisecond actual = dayInstance;
            Assert.IsAssignableFrom<Millisecond>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(2.77777777777778E-07d, 1d)]
        [TestCase(1d, 3600000d)]
        public void Should_cast_from_Hour(double hourValue, double expectedValue) {
            var hourInstance = new SystemOfUnits.Time.Hour(hourValue);

            Millisecond actual = hourInstance;
            Assert.IsAssignableFrom<Millisecond>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(1.66666666666667E-05d, 1d)]
        [TestCase(60d, 3600000d)]
        public void Should_cast_from_Minute(double minuteValue, double expectedValue) {
            var minuteInstance = new SystemOfUnits.Time.Minute(minuteValue);

            Millisecond actual = minuteInstance;
            Assert.IsAssignableFrom<Millisecond>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.001d, 1d)]
        [TestCase(3600d, 3600000d)]
        public void Should_cast_from_Second(double secondValue, double expectedValue) {
            var secondInstance = new SystemOfUnits.Time.Second(secondValue);

            Millisecond actual = secondInstance;
            Assert.IsAssignableFrom<Millisecond>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
