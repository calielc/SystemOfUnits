using System;
using NUnit.Framework;
using SystemOfUnits;

namespace SystemOfUnitsTests.Currency {
    using HKD = SystemOfUnits.Currency.HKD;

    [Parallelizable(ParallelScope.Default)]
    public sealed partial class HKDTest {
        [Test]
        public void Should_have_symbol_on_class() {
            Assert.AreEqual("HK$", HKD.Symbol);
        }

        public static readonly decimal[] CasesValues = { -7.65m, 0m, 1.7578m };

        [TestCaseSource(nameof(CasesValues))]
        public void Should_initialize_instance(decimal value) {
            var actual = new HKD(value);

            Assert.IsAssignableFrom<HKD>(actual);
            Assert.AreEqual(value, actual.Value, nameof(actual.Value));
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_have_a_symbol(decimal value) {
            ICurrency actual = new HKD(value);

            Assert.AreEqual(HKD.Symbol, actual.Symbol);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_clone(decimal value) {
            var expected = new HKD(value);

            ICloneable cloneable = new HKD(value);
            var actual = cloneable.Clone();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_cast_from_decimal(decimal value) {
            var expected = new HKD(value);

            var actual = (HKD)value;

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_cast_to_decimal(decimal value) {
            var instance = new HKD(value);

            var actual = (decimal)instance;

            Assert.AreEqual(value, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_compare_with_same_value(decimal value) {
            var baseInstance = new HKD(value);
            var otherInstance = new HKD(value);

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
            var baseInstance = new HKD((decimal)baseValue);
            var smallerInstance = new HKD((decimal)smallerValue);

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
            var baseInstance = new HKD((decimal)baseValue);
            var biggerInstance = new HKD((decimal)biggerValue);

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
            var instance = new HKD(value);

            Assert.IsFalse(instance.Equals(null), "Equals");
            Assert.AreEqual(1, instance.CompareTo(null), "CompareTo");
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_compare_with_another_type_of_instance(decimal value) {
            var instance1 = new HKD(value);
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
            var expected = new HKD((decimal)expectedValue);

            var leftInstance = new HKD((decimal)leftValue);
            var rightInstance = new HKD((decimal)rightValue);
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
            var expected = new HKD((decimal)expectedValue);

            var leftInstance = new HKD((decimal)leftValue);
            var rightInstance = new HKD((decimal)rightValue);
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
            var expected = new HKD((decimal)expectedValue);

            var instance = new HKD((decimal)leftValue);

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
            var expected = new HKD((decimal)expectedValue);

            var instance = new HKD((decimal)rightValue);

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
            var expected = new HKD((decimal)expectedValue);

            var instance = new HKD((decimal)leftValue);
            var actual = instance / (decimal)rightValue;

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_throw_exception_on_division_by_zero(decimal value) {
            var instance = new HKD(value);

            Assert.Throws<DivideByZeroException>(() => {
                var unused = instance / 0;
            });
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_convert_to_string(decimal value) {
            var expected = $"HK$ {value:0.00}";

            var instance = new HKD(value);
            var actual = instance.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, "HK$ {0}")]
        [TestCase("", "")]
        [TestCase("{0:000000}", "{0:000000}")]
        [TestCase("{0:00} k", "{0:00} k")]
        [TestCase("({0:#,##0})", "({0:#,##0})")]
        public void Should_format_string(string format, string mask) {
            var expected = string.Format(Consts.CultureEnUS, mask, 1.7578m);

            var instance = new HKD(1.7578m);
            var actual = instance.ToString(format, Consts.CultureEnUS);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_own_a_HashCode(decimal value) {
            var expected = value.GetHashCode();

            var instance = new HKD(value);
            var actual = instance.GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
