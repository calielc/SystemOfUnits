using System.Collections.Generic;
using System.Diagnostics;
using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Generators.Engine {
    [DebuggerDisplay("{Name} ({Symbol})")]
    internal struct ContextWithCastByRatio : IContext {
        public ContextWithCastByRatio(IContext context, CastRatio ratio, IEnumerable<CastRatioTestCase> testCases) {
            Name = context.Name;
            Symbol = context.Symbol;

            XmlDoc = context.XmlDoc;

            CodeClass = context.CodeClass;
            TestClass = context.TestClass;

            Ratio = ratio;

            TestCases = testCases;
        }

        public string Name { get; }
        public string Symbol { get; }

        public XmlDoc XmlDoc { get; }

        public FullQualifiedClass CodeClass { get; }
        public FullQualifiedClass TestClass { get; }

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