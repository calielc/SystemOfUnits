using NUnit.Framework;

namespace SystemOfUnitsTests.Time {
    using Minute = SystemOfUnits.Time.Minute;

    partial class MinuteTest {
        [TestCase(0d, 0d)]
        [TestCase(1.90132431040869E-06d, 1d)]
        [TestCase(0.000114079458624521d, 60d)]
        public void Should_cast_from_Year(double yearValue, double expectedValue) {
            var yearInstance = new SystemOfUnits.Time.Year(yearValue);

            Minute actual = yearInstance;
            Assert.IsAssignableFrom<Minute>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(2.28158917249042E-05d, 1d)]
        [TestCase(0.00136895350349425d, 60d)]
        public void Should_cast_from_Month(double monthValue, double expectedValue) {
            var monthInstance = new SystemOfUnits.Time.Month(monthValue);

            Minute actual = monthInstance;
            Assert.IsAssignableFrom<Minute>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(9.92063492063492E-05d, 1d)]
        [TestCase(0.00595238095238095d, 60d)]
        public void Should_cast_from_Week(double weekValue, double expectedValue) {
            var weekInstance = new SystemOfUnits.Time.Week(weekValue);

            Minute actual = weekInstance;
            Assert.IsAssignableFrom<Minute>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.000694444444444444d, 1d)]
        [TestCase(0.0416666666666667d, 60d)]
        public void Should_cast_from_Day(double dayValue, double expectedValue) {
            var dayInstance = new SystemOfUnits.Time.Day(dayValue);

            Minute actual = dayInstance;
            Assert.IsAssignableFrom<Minute>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(0.0166666666666667d, 1d)]
        [TestCase(1d, 60d)]
        public void Should_cast_from_Hour(double hourValue, double expectedValue) {
            var hourInstance = new SystemOfUnits.Time.Hour(hourValue);

            Minute actual = hourInstance;
            Assert.IsAssignableFrom<Minute>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(60d, 1d)]
        [TestCase(3600d, 60d)]
        public void Should_cast_from_Second(double secondValue, double expectedValue) {
            var secondInstance = new SystemOfUnits.Time.Second(secondValue);

            Minute actual = secondInstance;
            Assert.IsAssignableFrom<Minute>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }

        [TestCase(0d, 0d)]
        [TestCase(60000d, 1d)]
        [TestCase(3600000d, 60d)]
        public void Should_cast_from_Millisecond(double millisecondValue, double expectedValue) {
            var millisecondInstance = new SystemOfUnits.Time.Millisecond(millisecondValue);

            Minute actual = millisecondInstance;
            Assert.IsAssignableFrom<Minute>(actual);

            var actualValue = actual.Value;
            Assert.AreEqual(expectedValue, actualValue, Consts.DeltaAssert);
        }
    }
}
