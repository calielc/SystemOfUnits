using System.Collections.Generic;

namespace SystemOfUnitsGenerator.Engine {
    internal sealed class ContextWithCastByPowerBuilder {
        private readonly int _baseNumber;
        private readonly List<(int exponent, IContext context)> _items = new List<(int exponent, IContext context)>();

        public ContextWithCastByPowerBuilder(int baseNumber) {
            _baseNumber = baseNumber;
        }

        public double[][] TestCases { get; set; } = new double[0][];

        public void Add(int exponent, IContext context) {
            _items.Add((exponent, context));
        }

        public IReadOnlyCollection<ContextWithCastByPower> Build() {
            var result = new List<ContextWithCastByPower>(_items.Count);

            for (var idxThis = 0; idxThis < _items.Count; idxThis++) {
                var (exponent, context) = _items[idxThis];

                var castPower = new CastPower(_baseNumber, exponent);

                var testCases = BuildTestCases(idxThis);

                result.Add(new ContextWithCastByPower(context, castPower, testCases));
            }

            return result;
        }

        private IEnumerable<CastPowerTestCase> BuildTestCases(int idxThis) {
            foreach (var testCase in TestCases) {
                var expected = new List<double>();

                for (var idxOther = 0; idxOther < _items.Count; idxOther++) {
                    if (idxOther == idxThis) {
                        continue;
                    }
                    expected.Add(testCase[idxOther]);
                }

                yield return new CastPowerTestCase(testCase[idxThis], expected.ToArray());
            }
        }
    }
}