using System;
using NUnit.Framework;
using SystemOfUnits;

namespace SystemOfUnitsTests.Area.SquareMetre {
    using SquareMegametre = SystemOfUnits.Area.SquareMetre.SquareMegametre;

    [Parallelizable(ParallelScope.Default)]
    public sealed partial class SquareMegametreTest {
        [Test]
        public void Should_have_symbol_on_class() {
            Assert.AreEqual("Mm²", SquareMegametre.Symbol);
        }

        public static readonly double[] CasesValues = { -7.65d, 0d, 1.757899e2 };

        [TestCaseSource(nameof(CasesValues))]
        public void Should_initialize_instance(double value) {
            var actual = new SquareMegametre(value);

            Assert.IsAssignableFrom<SquareMegametre>(actual);
            Assert.AreEqual(value, actual.Value, nameof(actual.Value));
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_have_a_symbol(double value) {
            IUnit actual = new SquareMegametre(value);

            Assert.AreEqual(SquareMegametre.Symbol, actual.Symbol);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_clone(double value) {
            var expected = new SquareMegametre(value);

            ICloneable cloneable = new SquareMegametre(value);
            var actual = cloneable.Clone();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_cast_from_double(double value) {
            var expected = new SquareMegametre(value);

            var actual = (SquareMegametre)value;

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_cast_to_double(double value) {
            var instance = new SquareMegametre(value);

            var actual = (double)instance;

            Assert.AreEqual(value, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_compare_with_same_value(double value) {
            var baseInstance = new SquareMegametre(value);
            var otherInstance = new SquareMegametre(value);

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
            var baseInstance = new SquareMegametre(baseValue);
            var smallerInstance = new SquareMegametre(smallerValue);

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
            var baseInstance = new SquareMegametre(baseValue);
            var biggerInstance = new SquareMegametre(biggerValue);

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
        public void Should_compare_with_null_instance(double value) {
            var instance = new SquareMegametre(value);

            Assert.IsFalse(instance.Equals(null), "Equals");
            Assert.AreEqual(1, instance.CompareTo(null), "CompareTo");
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_compare_with_another_type_of_instance(double value) {
            var instance1 = new SquareMegametre(value);
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
            var expected = new SquareMegametre(expectedValue);

            var leftInstance = new SquareMegametre(leftValue);
            var rightInstance = new SquareMegametre(rightValue);
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
            var expected = new SquareMegametre(expectedValue);

            var leftInstance = new SquareMegametre(leftValue);
            var rightInstance = new SquareMegametre(rightValue);
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
        public void Should_multiply_instance_by_double(double leftValue, double rightValue, double expectedValue) {
            var expected = new SquareMegametre(expectedValue);

            var instance = new SquareMegametre(leftValue);

            var actual = instance * rightValue;
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
        public void Should_multiply_double_by_instance(double leftValue, double rightValue, double expectedValue) {
            var expected = new SquareMegametre(expectedValue);

            var instance = new SquareMegametre(rightValue);

            var actual = leftValue * instance;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0d, -7.65d, 0d)]
        [TestCase(0d, 1.757899e2, 0d)]
        [TestCase(123.87d, 0.25d, 495.48d)]
        [TestCase(578.78d, -32.34d, -1.78967223252938010000e+001)]
        [TestCase(578.78d, 32.34d, 1.78967223252938010000e+001)]
        [TestCase(-32.34d, 578.78d, -5.58761532879505150000e-002)]
        [TestCase(32.34d, 578.78d, 5.58761532879505150000e-002)]
        public void Should_divide_instance_by_double(double leftValue, double rightValue, double expectedValue) {
            var expected = new SquareMegametre(expectedValue);

            var instance = new SquareMegametre(leftValue);
            var actual = instance / rightValue;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d, double.NegativeInfinity)]
        [TestCase(1.757899e2, double.PositiveInfinity)]
        [TestCase(0d, double.NaN)]
        public void Should_not_throw_exception_on_division_by_zero(double value, double expectedValue) {
            var instance = new SquareMegametre(value);
            var actual = instance / 0d;

            Assert.AreEqual(expectedValue, actual.Value);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_convert_to_string(double value) {
            var expected = $"{value:e} Mm²";

            var instance = new SquareMegametre(value);
            var actual = instance.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, "{0} Mm²")]
        [TestCase("", "")]
        [TestCase("{0:000000}", "{0:000000}")]
        [TestCase("{0:00} k", "{0:00} k")]
        [TestCase("({0:#,##0})", "({0:#,##0})")]
        public void Should_format_string(string format, string mask) {
            var expected = string.Format(Consts.CultureEnUS, mask, 1.757899e2);

            var instance = new SquareMegametre(1.757899e2);
            var actual = instance.ToString(format, Consts.CultureEnUS);

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(CasesValues))]
        public void Should_own_a_HashCode(double value) {
            var expected = value.GetHashCode();

            var instance = new SquareMegametre(value);
            var actual = instance.GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}
