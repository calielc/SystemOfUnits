using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.BuildersCollection;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal class PercentageGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + "Others";
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + "Others";

        public IContentFileBuilderCollection Generate() {
            var contexts = new[]
            {
                new Context(NamespaceCode, NamespaceTest, "Percentage", "%")
            };

            return new ContextBuilderCollection(contexts);
        }
    }
}