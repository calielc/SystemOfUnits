using System;
using NUnit.Framework;
using SystemOfUnits;

namespace SystemOfUnitsTests.Currency {
    using ZAR = SystemOfUnits.Currency.ZAR;

    [Parallelizable(ParallelScope.Default)]
    public sealed partial class ZARTest {
        [Test]
        public void Should_have_symbol_on_class() {
            Assert.AreEqual("R", ZAR.Symbol);
        }

        public static readonly decimal[] CasesValues = { -7.65m, 0m, 1.7578m };

        [TestCaseSource(nameof(CasesValues))]
        public void Should_initialize_instance(decimal value) {
            var actual = new ZAR(value);

            Assert.IsAssignableFrom<ZAR>(actual);
            Assert.AreEqual(value, actual.Value, nameof(actual.Value));
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_have_a_symbol(decimal value) {
            ICurrency actual = new ZAR(value);

            Assert.AreEqual(ZAR.Symbol, actual.Symbol);
        }

        [TestCase(-8.9d, -9d)]
        [TestCase(-7.1d, -8d)]
        [TestCase(-6.0d, -6d)]
        [TestCase(0d, 0d)]
        [TestCase(12.0d, 12d)]
        [TestCase(13.1d, 13d)]
        [TestCase(14.9d, 14d)]
        public void Should_floor_value(double value, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)value);
            var actual = instance.Floor();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.9d, -8d)]
        [TestCase(-6.6d, -7d)]
        [TestCase(-5.5d, -6d)]
        [TestCase(-4.1d, -4d)]
        [TestCase(-3.0d, -3d)]
        [TestCase(0d, 0d)]
        [TestCase(12.0d, 12d)]
        [TestCase(13.1d, 13d)]
        [TestCase(14.5d, 14d)]
        [TestCase(15.6d, 16d)]
        [TestCase(16.9d, 17d)]
        public void Should_round_value(double value, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)value);
            var actual = instance.Round();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.59d, -7.6d)]
        [TestCase(-6.46d, -6.5d)]
        [TestCase(-5.35d, -5.4d)]
        [TestCase(-4.21d, -4.2d)]
        [TestCase(-3.10d, -3.1d)]
        [TestCase(0d, 0d)]
        [TestCase(12.30d, 12.3d)]
        [TestCase(13.41d, 13.4d)]
        [TestCase(14.55d, 14.6d)]
        [TestCase(15.66d, 15.7d)]
        [TestCase(16.79d, 16.8d)]
        public void Should_round_value_withDigit(double value, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)value);
            var actual = instance.Round(1);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(MidpointRounding.AwayFromZero, -7.9d, -8d)]
        [TestCase(MidpointRounding.AwayFromZero, -6.6d, -7d)]
        [TestCase(MidpointRounding.AwayFromZero, -5.5d, -6d)]
        [TestCase(MidpointRounding.AwayFromZero, -4.1d, -4d)]
        [TestCase(MidpointRounding.AwayFromZero, -3.0d, -3d)]
        [TestCase(MidpointRounding.AwayFromZero, 0d, 0d)]
        [TestCase(MidpointRounding.AwayFromZero, 12.0d, 12d)]
        [TestCase(MidpointRounding.AwayFromZero, 13.1d, 13d)]
        [TestCase(MidpointRounding.AwayFromZero, 14.5d, 15d)]
        [TestCase(MidpointRounding.AwayFromZero, 15.6d, 16d)]
        [TestCase(MidpointRounding.AwayFromZero, 16.9d, 17d)]
        [TestCase(MidpointRounding.ToEven, -7.9d, -8d)]
        [TestCase(MidpointRounding.ToEven, -6.6d, -7d)]
        [TestCase(MidpointRounding.ToEven, -5.5d, -6d)]
        [TestCase(MidpointRounding.ToEven, -4.1d, -4d)]
        [TestCase(MidpointRounding.ToEven, -3.0d, -3d)]
        [TestCase(MidpointRounding.ToEven, 0d, 0d)]
        [TestCase(MidpointRounding.ToEven, 12.0d, 12d)]
        [TestCase(MidpointRounding.ToEven, 13.1d, 13d)]
        [TestCase(MidpointRounding.ToEven, 14.5d, 14d)]
        [TestCase(MidpointRounding.ToEven, 15.6d, 16d)]
        [TestCase(MidpointRounding.ToEven, 16.9d, 17d)]
        public void Should_roundvalue_withMode(MidpointRounding mode, double value, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)value);
            var actual = instance.Round(mode);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-8.9d, -8d)]
        [TestCase(-7.1d, -7d)]
        [TestCase(-6.0d, -6d)]
        [TestCase(0d, 0d)]
        [TestCase(12.0d, 12d)]
        [TestCase(13.1d, 14d)]
        [TestCase(14.9d, 15d)]
        public void Should_ceiling_value(double value, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)value);
            var actual = instance.Ceiling();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.9d, -7d)]
        [TestCase(-6.6d, -6d)]
        [TestCase(-5.5d, -5d)]
        [TestCase(-4.1d, -4d)]
        [TestCase(-3.0d, -3d)]
        [TestCase(0d, 0d)]
        [TestCase(12.0d, 12d)]
        [TestCase(13.1d, 13d)]
        [TestCase(14.5d, 14d)]
        [TestCase(15.6d, 15d)]
        [TestCase(16.9d, 16d)]
        public void Should_truncate_value(double value, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)value);
            var actual = instance.Truncate();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-8.9d, 8.9d)]
        [TestCase(-7.1d, 7.1d)]
        [TestCase(-6.0d, 6.0d)]
        [TestCase(0d, 0d)]
        [TestCase(12.0d, 12.0d)]
        [TestCase(13.1d, 13.1d)]
        [TestCase(14.9d, 14.9d)]
        public void Should_absolute_value(double value, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)value);
            var actual = instance.Abs();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_cast_from_decimal(decimal value) {
            var expected = new ZAR(value);

            var actual = (ZAR)value;

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_cast_to_decimal(decimal value) {
            var instance = new ZAR(value);

            var actual = (decimal)instance;

            Assert.AreEqual(value, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_compare_with_same_value(decimal value) {
            var baseInstance = new ZAR(value);
            var otherInstance = new ZAR(value);

            Assert.IsTrue(baseInstance.Equals(otherInstance), "Equals");
            Assert.IsTrue(baseInstance.Equals((object)otherInstance), "Equals object");

            Assert.IsTrue(baseInstance == otherInstance, "==");
            Assert.IsFalse(baseInstance != otherInstance, "!=");

            Assert.AreEqual(0, baseInstance.CompareTo(otherInstance), "CompareTo");
            Assert.AreEqual(0, baseInstance.CompareTo((object)otherInstance), "CompareTo object");

            Assert.IsFalse(baseInstance < otherInstance, "<");
            Assert.IsFalse(baseInstance > otherInstance, ">");

            Assert.IsTrue(baseInstance <= otherInstance, "<=");
            Assert.IsTrue(baseInstance >= otherInstance, ">=");
        }

        [TestCase(-7.65d, -1000)]
        [TestCase(-7.65d, -7.66d)]
        [TestCase(0d, -0.9999)]
        [TestCase(0d, -100)]
        [TestCase(1.757899e2, 1.757898e2)]
        [TestCase(1.757899e2, 0)]
        public void Should_compare_with_smaller_value(double baseValue, double smallerValue) {
            var baseInstance = new ZAR((decimal)baseValue);
            var smallerInstance = new ZAR((decimal)smallerValue);

            Assert.IsFalse(baseInstance.Equals(smallerInstance), "Equals");
            Assert.IsFalse(baseInstance.Equals((object)smallerInstance), "Equals object");

            Assert.IsFalse(baseInstance == smallerInstance, "==");
            Assert.IsTrue(baseInstance != smallerInstance, "!=");

            Assert.AreEqual(+1, baseInstance.CompareTo(smallerInstance), "CompareTo");
            Assert.AreEqual(+1, baseInstance.CompareTo((object)smallerInstance), "CompareTo object");

            Assert.IsFalse(baseInstance < smallerInstance, "<");
            Assert.IsTrue(baseInstance > smallerInstance, ">");

            Assert.IsFalse(baseInstance <= smallerInstance, "<=");
            Assert.IsTrue(baseInstance >= smallerInstance, ">=");
        }

        [TestCase(-7.65d, 1000)]
        [TestCase(-7.65d, -7.64d)]
        [TestCase(0d, 0.00001)]
        [TestCase(0d, 100)]
        [TestCase(1.757899e2, 1.7578991e2)]
        [TestCase(1.757899e2, 1000000)]
        public void Should_compare_with_bigger_value(double baseValue, double biggerValue) {
            var baseInstance = new ZAR((decimal)baseValue);
            var biggerInstance = new ZAR((decimal)biggerValue);

            Assert.IsFalse(baseInstance.Equals(biggerInstance), "Equals");
            Assert.IsFalse(baseInstance.Equals((object)biggerInstance), "Equals object");

            Assert.IsFalse(baseInstance == biggerInstance, "==");
            Assert.IsTrue(baseInstance != biggerInstance, "!=");

            Assert.AreEqual(-1, baseInstance.CompareTo(biggerInstance), "CompareTo");
            Assert.AreEqual(-1, baseInstance.CompareTo((object)biggerInstance), "CompareTo object");

            Assert.IsTrue(baseInstance < biggerInstance, "<");
            Assert.IsFalse(baseInstance > biggerInstance, ">");

            Assert.IsTrue(baseInstance <= biggerInstance, "<=");
            Assert.IsFalse(baseInstance >= biggerInstance, ">=");
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_compare_with_null_instance(decimal value) {
            var instance = new ZAR(value);

            Assert.IsFalse(instance.Equals(null), "Equals");
            Assert.AreEqual(1, instance.CompareTo(null), "CompareTo");
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_compare_with_another_type_of_instance(decimal value) {
            var instance1 = new ZAR(value);
            object instance2 = value;

            Assert.IsFalse(instance1.Equals(instance2), "Equals");
            Assert.Throws<ArgumentException>(() => instance1.CompareTo(instance2), "CompareTo");
        }

        [TestCase(0d, -7.65d, -7.65d)]
        [TestCase(0d, 0d, 0d)]
        [TestCase(0d, 1.757899e2, 1.757899e2)]
        [TestCase(1.757899e2, 0d, 1.757899e2)]
        [TestCase(578.78d, -32.34d, 546.44d)]
        [TestCase(578.78d, 32.34d, 611.12d)]
        public void Should_sum_two_instances(double leftValue, double rightValue, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var leftInstance = new ZAR((decimal)leftValue);
            var rightInstance = new ZAR((decimal)rightValue);
            var actual = leftInstance + rightInstance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, -7.65d, +7.65d)]
        [TestCase(0d, 0d, 0d)]
        [TestCase(0d, 1.757899e2, -1.757899e2)]
        [TestCase(1.757899e2, 0d, 1.757899e2)]
        [TestCase(578.78d, -32.34d, 611.12d)]
        [TestCase(578.78d, 32.34d, 546.44d)]
        public void Should_subtract_two_instances(double leftValue, double rightValue, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var leftInstance = new ZAR((decimal)leftValue);
            var rightInstance = new ZAR((decimal)rightValue);
            var actual = leftInstance - rightInstance;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, -7.65d, 0d)]
        [TestCase(0d, 0d, 0d)]
        [TestCase(0d, 1.757899e2, 0d)]
        [TestCase(1.757899e2, 0d, 0d)]
        [TestCase(123.87d, 0.25d, 30.9675d)]
        [TestCase(578.78d, -32.34d, -18717.7452d)]
        [TestCase(-32.34d, 578.78d, -18717.7452d)]
        [TestCase(578.78d, 32.34d, 18717.7452d)]
        public void Should_multiply_instance_by_decimal(double leftValue, double rightValue, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)leftValue);

            var actual = instance * (decimal)rightValue;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, -7.65d, 0d)]
        [TestCase(0d, 0d, 0d)]
        [TestCase(0d, 1.757899e2, 0d)]
        [TestCase(1.757899e2, 0d, 0d)]
        [TestCase(123.87d, 0.25d, 30.9675d)]
        [TestCase(578.78d, -32.34d, -18717.7452d)]
        [TestCase(-32.34d, 578.78d, -18717.7452d)]
        [TestCase(578.78d, 32.34d, 18717.7452d)]
        public void Should_multiply_decimal_by_instance(double leftValue, double rightValue, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)rightValue);

            var actual = (decimal)leftValue * instance;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, -7.65d, 0d)]
        [TestCase(0d, 1.757899e2, 0d)]
        [TestCase(123.87d, 0.25d, 495.48d)]
        [TestCase(500d, -2.5d, -200d)]
        [TestCase(500d, 2.5d, 200d)]
        [TestCase(-2.5d, 500d, -0.005d)]
        [TestCase(2.5d, 500d, 0.005d)]
        public void Should_divide_instance_by_decimal(double leftValue, double rightValue, double expectedValue) {
            var expected = new ZAR((decimal)expectedValue);

            var instance = new ZAR((decimal)leftValue);
            var actual = instance / (decimal)rightValue;

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_throw_exception_on_division_by_zero(decimal value) {
            var instance = new ZAR(value);

            Assert.Throws<DivideByZeroException>(() => {
                var unused = instance / 0;
            });
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_convert_to_string(decimal value) {
            var expected = $"R {value:0.00}";

            var instance = new ZAR(value);
            var actual = instance.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, "R {0}")]
        [TestCase("", "")]
        [TestCase("{0:000000}", "{0:000000}")]
        [TestCase("{0:00} k", "{0:00} k")]
        [TestCase("({0:#,##0})", "({0:#,##0})")]
        public void Should_format_string(string format, string mask) {
            var expected = string.Format(Consts.CultureEnUS, mask, 1.7578m);

            var instance = new ZAR(1.7578m);
            var actual = instance.ToString(format, Consts.CultureEnUS);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_own_a_HashCode(decimal value) {
            var expected = value.GetHashCode();

            var instance = new ZAR(value);
            var actual = instance.GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
