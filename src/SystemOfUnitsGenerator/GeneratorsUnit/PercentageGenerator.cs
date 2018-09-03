using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal class PercentageGenerator : IGenerator {
        public IContentFileBuilderCollection Generate() {
            var contexts = new[] {
                new UnitNamespaces(Resource.NamespaceOthers) + new UnitDefinition("Percentage", "%")
            };

            return new ClassesBuilder(contexts);
        }
    }
}