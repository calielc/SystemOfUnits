using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SystemOfUnitsTests.Angle {
    using Degree = SystemOfUnits.Angle.Degree;
    using Radian = SystemOfUnits.Angle.Radian;

    public partial class RadianTest {
        [TestCase(-720d, 0d)]
        [TestCase(-360.0001d, 359.9999d)]
        [TestCase(-360d, 0d)]
        [TestCase(-359.9999d, 0.0001d)]
        [TestCase(-270d, 90d)]
        [TestCase(-180d, 180d)]
        [TestCase(-90d, 270d)]
        [TestCase(0d, 0d)]
        [TestCase(90d, 90d)]
        [TestCase(180d, 180d)]
        [TestCase(270d, 270d)]
        [TestCase(359.9999d, 359.9999d)]
        [TestCase(360d, 0d)]
        [TestCase(360.0001d, 0.0001d)]
        [TestCase(720d, 0d)]
        public void Should_normalize_angle(double originalValue, double expectedValue) {
            Radian expected = new Degree(expectedValue);

            Radian original = new Degree(originalValue);
            var actual = original.Normalize();

            Assert.AreEqual(expected, actual);
        }

        internal static IEnumerable<TestCaseData> CasesDefaultValues() {
            yield return new TestCaseData(Radian.Degrees0, 0d);
            yield return new TestCaseData(Radian.Degrees30, Math.PI / 6d);
            yield return new TestCaseData(Radian.Degrees45, Math.PI / 4d);
            yield return new TestCaseData(Radian.Degrees60, Math.PI / 3d);
            yield return new TestCaseData(Radian.Degrees90, Math.PI / 2d);
            yield return new TestCaseData(Radian.Degrees180, Math.PI);
            yield return new TestCaseData(Radian.Degrees270, Math.PI * 3d / 2d);
        }

        [TestCaseSource(nameof(CasesDefaultValues))]
        public void Should_have_default_value(Radian actual, double expectedValue) {
            var expected = new Radian(expectedValue);

            Assert.AreEqual(expected, actual);
        }

        internal static double[] DefaultAngles =
        {
            0,
            Math.PI / 6d,
            Math.PI / 4d,
            Math.PI / 3d,
            Math.PI / 2d,
            Math.PI,
            Math.PI *3d / 2d
        };

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Sin(double angle) {
            var expected = Math.Sin(angle);

            var degree = new Radian(angle);
            var actual = degree.Sin();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Cos(double angle) {
            var expected = Math.Cos(angle);

            var degree = new Radian(angle);
            var actual = degree.Cos();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Tan(double angle) {
            var expected = Math.Tan(angle);

            var degree = new Radian(angle);
            var actual = degree.Tan();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Acos(double angle) {
            var expected = Math.Acos(angle);

            var degree = new Radian(angle);
            var actual = degree.Acos();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Asin(double angle) {
            var expected = Math.Asin(angle);

            var degree = new Radian(angle);
            var actual = degree.Asin();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Atan(double angle) {
            var expected = Math.Atan(angle);

            var degree = new Radian(angle);
            var actual = degree.Atan();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }
    }
}
