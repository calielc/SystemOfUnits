using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal class TemperatureClassesGenerator : IGenerator {
        public IContentFileBuilderCollection Generate() {
            var namespaces = new UnitNamespaces(Resource.NamespaceTemperature);
            
            var contexts = new[] {
                namespaces + new UnitDefinition("Kelvin", "K"),
                namespaces + new UnitDefinition("Celsius", "°C"),
                namespaces + new UnitDefinition("Fahrenheit", "°F")
            };

            return new ClassesBuilder(contexts);
        }
    }
}