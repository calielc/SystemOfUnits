using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal class TemperatureClassesGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceUnit = Resource.NamespaceTemperature;

        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + NamespaceUnit;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + NamespaceUnit;

        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();

            return new ClassesBuilder(contexts);
        }

        private static IEnumerable<Context> BuildContexts() {
            yield return new Context(NamespaceCode, NamespaceTest, "Kelvin", "K");
            yield return new Context(NamespaceCode, NamespaceTest, "Celsius", "°C");
            yield return new Context(NamespaceCode, NamespaceTest, "Fahrenheit", "°F");
        }
    }
}