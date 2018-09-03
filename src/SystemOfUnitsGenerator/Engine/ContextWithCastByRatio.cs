using System.Collections.Generic;
using System.Diagnostics;

namespace SystemOfUnitsGenerator.Engine {
    [DebuggerDisplay("{Name} ({Symbol})")]
    internal sealed class ContextWithCastByRatio : Context {
        public ContextWithCastByRatio(IContext context, CastRatio ratio, IEnumerable<CastRatioTestCase> testCases) : base(context) {
            Ratio = ratio;
            TestCases = testCases;
        }

        public CastRatio Ratio { get; }
        public IEnumerable<CastRatioTestCase> TestCases { get; }
    }

    [DebuggerDisplay("{CSharpValue}")]
    public struct CastRatio {
        public CastRatio(double numericalValue, string cSharpValue, string constantName) {
            NumericalValue = numericalValue;
            CSharpValue = cSharpValue;
            ConstantName = constantName;
        }

        public double NumericalValue { get; }
        public string CSharpValue { get; }
        public string ConstantName { get; }
    }

    [DebuggerDisplay("{Expected}")]
    public struct CastRatioTestCase {
        public CastRatioTestCase(double expected, params double[] inputs) {
            Expected = expected;
            Inputs = inputs;
        }

        public double Expected { get; }

        public double[] Inputs { get; }
    }
}