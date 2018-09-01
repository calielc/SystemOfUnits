using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal class PercentageGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + "Others";
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + "Others";

        public IContentFileBuilderCollection Generate() {
            var contexts = new[]
            {
                new Context(NamespaceCode, NamespaceTest, "Percentage", "%")
            };

            return new ClassesBuilder(contexts);
        }
    }
}