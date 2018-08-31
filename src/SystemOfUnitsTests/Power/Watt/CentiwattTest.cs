using System;
using NUnit.Framework;
using SystemOfUnits;

namespace SystemOfUnitsTests.Power.Watt {
    using Centiwatt = SystemOfUnits.Power.Watt.Centiwatt;

    [Parallelizable(ParallelScope.Default)]
    public sealed partial class CentiwattTest {
        [Test]
        public void Should_have_symbol_on_class() {
            Assert.AreEqual("cW", Centiwatt.Symbol);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_initialize_instance(double value) {
            var actual = new Centiwatt(value);

            Assert.IsAssignableFrom<Centiwatt>(actual);
            Assert.AreEqual(value, actual.Value, nameof(actual.Value));
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_have_a_symbol(double value) {
            IUnit actual = new Centiwatt(value);

            Assert.AreEqual(Centiwatt.Symbol, actual.Symbol);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_clone(double value) {
            var expected = new Centiwatt(value);

            ICloneable cloneable = new Centiwatt(value);
            var actual = cloneable.Clone();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_cast_from_double(double value) {
            var expected = new Centiwatt(value);

            var actual = (Centiwatt)value;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_cast_to_double(double value) {
            var instance = new Centiwatt(value);

            var actual = (double)instance;

            Assert.AreEqual(value, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_compare_with_same_value(double value) {
            var baseInstance = new Centiwatt(value);
            var otherInstance = new Centiwatt(value);

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
            var baseInstance = new Centiwatt(baseValue);
            var smallerInstance = new Centiwatt(smallerValue);

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
            var baseInstance = new Centiwatt(baseValue);
            var biggerInstance = new Centiwatt(biggerValue);

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

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_compare_with_null_instance(double value) {
            var instance = new Centiwatt(value);

            Assert.IsFalse(instance.Equals(null), "Equals");
            Assert.AreEqual(1, instance.CompareTo(null), "CompareTo");
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_compare_with_another_type_of_instance(double value) {
            var instance1 = new Centiwatt(value);
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
            var expected = new Centiwatt(expectedValue);

            var leftInstance = new Centiwatt(leftValue);
            var rightInstance = new Centiwatt(rightValue);
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
            var expected = new Centiwatt(expectedValue);

            var leftInstance = new Centiwatt(leftValue);
            var rightInstance = new Centiwatt(rightValue);
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
            var expected = new Centiwatt(expectedValue);

            var instance = new Centiwatt(leftValue);

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
            var expected = new Centiwatt(expectedValue);

            var instance = new Centiwatt(rightValue);

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
            var expected = new Centiwatt(expectedValue);

            var instance = new Centiwatt(leftValue);
            var actual = instance / rightValue;

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d, double.NegativeInfinity)]
        [TestCase(1.757899e2, double.PositiveInfinity)]
        [TestCase(0d, double.NaN)]
        public void Should_not_throw_exception_on_division_by_zero(double value, double expectedValue) {
            var instance = new Centiwatt(value);
            var actual = instance / 0d;

            Assert.AreEqual(expectedValue, actual.Value);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_convert_to_string(double value) {
            var expected = $"{value:e} cW";

            var instance = new Centiwatt(value);
            var actual = instance.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(null, "{0} cW")]
        [TestCase("", "")]
        [TestCase("{0:000000}", "{0:000000}")]
        [TestCase("{0:00} k", "{0:00} k")]
        [TestCase("({0:#,##0})", "({0:#,##0})")]
        public void Should_format_string(string format, string mask) {
            var expected = string.Format(Consts.CultureEnUS, mask, 1.757899e2);

            var instance = new Centiwatt(1.757899e2);
            var actual = instance.ToString(format, Consts.CultureEnUS);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-7.65d)]
        [TestCase(0d)]
        [TestCase(1.757899e2)]
        public void Should_own_a_HashCode(double value) {
            var expected = value.GetHashCode();

            var instance = new Centiwatt(value);
            var actual = instance.GetHashCode();

            Assert.AreEqual(expected, actual);
        }
    }
}