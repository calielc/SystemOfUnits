using System.Collections.Generic;
using System.Diagnostics;
using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Generators.Engine {
    [DebuggerDisplay("{Name} ({Symbol})")]
    internal struct ContextWithCastByPower : IContext {
        public ContextWithCastByPower(Context context, CastPower power, IEnumerable<CastPowerTestCase> testCases) {
            Name = context.Name;
            Symbol = context.Symbol;
            XmlDoc = context.XmlDoc;

            CodeClass = context.CodeClass;
            TestClass = context.TestClass;

            Power = power;

            TestCases = testCases;
        }

        public string Name { get; }
        public string Symbol { get; }

        public XmlDoc XmlDoc { get; }

        public FullQualifiedClass CodeClass { get; }
        public FullQualifiedClass TestClass { get; }

        public CastPower Power { get; }

        public IEnumerable<CastPowerTestCase> TestCases { get; }
    }

    [DebuggerDisplay("{BaseNumber} ^ {Exponent}")]
    internal struct CastPower {
        public CastPower(int baseNumber, int exponent) {
            BaseNumber = baseNumber;
            Exponent = exponent;
        }

        public int BaseNumber { get; }
        public int Exponent { get; }
    }

    internal struct CastPowerTestCase {
        public CastPowerTestCase(double input, params double[] expected) {
            Input = input;
            Expected = expected;
        }

        public double Input { get; }
        public double[] Expected { get; }
    }
}