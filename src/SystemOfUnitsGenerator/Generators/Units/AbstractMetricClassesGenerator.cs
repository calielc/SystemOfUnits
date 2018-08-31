using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.BuildersCollection;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal abstract class AbstractMetricClassesGenerator : IGenerator {
        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();

            return new ContextWithCastByPowerBuilderCollection(contexts, "Casting");
        }

        protected IReadOnlyCollection<ContextWithCastByPower> BuildContexts() {
            var builder = new ContextWithCastByPowerBuilder(10);

            var baseUnit = GetBaseUnit();
            var baseSymbol = GetBaseSymbol();
            var namespaceCode = NamespaceDefinition.SystemOfUnits + GetNamespace();
            var namespaceTest = NamespaceDefinition.SystemOfUnitsTests + GetNamespace();

            builder.Add(+3, new Context(namespaceCode, namespaceTest, $"kilo{baseUnit}", $"k{baseSymbol}"));
            builder.Add(+2, new Context(namespaceCode, namespaceTest, $"hecto{baseUnit}", $"h{baseSymbol}"));
            builder.Add(+1, new Context(namespaceCode, namespaceTest, $"deca{baseUnit}", $"da{baseSymbol}"));
            builder.Add(00, new Context(namespaceCode, namespaceTest, $"{baseUnit}", $"{baseSymbol}"));
            builder.Add(-1, new Context(namespaceCode, namespaceTest, $"deci{baseUnit}", $"d{baseSymbol}"));
            builder.Add(-2, new Context(namespaceCode, namespaceTest, $"centi{baseUnit}", $"c{baseSymbol}"));
            builder.Add(-3, new Context(namespaceCode, namespaceTest, $"milli{baseUnit}", $"m{baseSymbol}"));

            builder.TestCases = new[]
            {
                //          kX,     hX,    daX,      X,      dX,      cX,      mX 
                //       10e+3,  10e+2,  10e+1,   10e0,   10e-1,   10e-2,   10e-3
                new[] {     0d,     0d,     0d,     0d,      0d,      0d,      0d },
                new[] { 13.7e3, 13.7e2, 13.7e1, 13.7e0, 13.7e-1, 13.7e-2, 13.7e-3 },
                new[] {   -5e3,   -5e2,   -5e1,   -5e0,   -5e-1,   -5e-2,   -5e-3 },
                new[] {    1e0,   1e-1,   1e-2,   1e-3,    1e-4,    1e-5,    1e-6 },
                new[] {    2e6,    2e5,    2e4,    2e3,     2e2    , 2e1,     2e0 },
            };

            return builder.Build();
        }

        protected abstract NamespaceDefinition GetNamespace();
        protected abstract string GetBaseSymbol();
        protected abstract string GetBaseUnit();
    }
}