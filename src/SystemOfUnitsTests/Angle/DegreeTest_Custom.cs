using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace SystemOfUnitsTests.Angle {
    using Degree = SystemOfUnits.Angle.Degree;

    public partial class DegreeTest {
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
            var expected = new Degree(expectedValue);

            var actual = new Degree(originalValue).Normalize();

            Assert.AreEqual(expected, actual);
        }

        internal static IEnumerable<TestCaseData> CasesDefaultValues() {
            yield return new TestCaseData(Degree.Degrees0, 0d);
            yield return new TestCaseData(Degree.Degrees30, 30d);
            yield return new TestCaseData(Degree.Degrees45, 45d);
            yield return new TestCaseData(Degree.Degrees60, 60d);
            yield return new TestCaseData(Degree.Degrees90, 90d);
            yield return new TestCaseData(Degree.Degrees180, 180d);
            yield return new TestCaseData(Degree.Degrees270, 270d);
        }

        [TestCaseSource(nameof(CasesDefaultValues))]
        public void Should_have_default_value(Degree actual, double expectedValue) {
            var expected = new Degree(expectedValue);

            Assert.AreEqual(expected, actual);
        }

        internal static double[] DefaultAngles = { 0, 30, 45, 60, 90, 180, 270 };

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Sin(double angle) {
            var expected = Math.Sin(angle * Math.PI / 180d);

            var degree = new Degree(angle);
            var actual = degree.Sin();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Cos(double angle) {
            var expected = Math.Cos(angle * Math.PI / 180d);

            var degree = new Degree(angle);
            var actual = degree.Cos();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Tan(double angle) {
            var expected = Math.Tan(angle * Math.PI / 180d);

            var degree = new Degree(angle);
            var actual = degree.Tan();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Acos(double angle) {
            var expected = Math.Acos(angle * Math.PI / 180d);

            var degree = new Degree(angle);
            var actual = degree.Acos();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Asin(double angle) {
            var expected = Math.Asin(angle * Math.PI / 180d);

            var degree = new Degree(angle);
            var actual = degree.Asin();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }

        [TestCaseSource(nameof(DefaultAngles))]
        public void Should_calculate_Atan(double angle) {
            var expected = Math.Atan(angle * Math.PI / 180d);

            var degree = new Degree(angle);
            var actual = degree.Atan();

            Assert.AreEqual(expected, actual, Consts.DeltaAssert);
        }
    }
}
