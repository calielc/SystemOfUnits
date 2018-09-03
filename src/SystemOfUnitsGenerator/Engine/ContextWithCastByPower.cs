using System.Collections.Generic;
using System.Diagnostics;

namespace SystemOfUnitsGenerator.Engine {
    [DebuggerDisplay("{Name} ({Symbol})")]
    internal sealed class ContextWithCastByPower : Context {
        public ContextWithCastByPower(IContext context, CastPower power, IEnumerable<CastPowerTestCase> testCases) : base(context) {
            Power = power;
            TestCases = testCases;
        }

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