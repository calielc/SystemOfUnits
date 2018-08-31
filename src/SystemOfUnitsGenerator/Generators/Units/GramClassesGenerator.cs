using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class GramClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "gram";
        protected override string GetBaseSymbol() => "g";
        protected override NamespaceDefinition GetNamespace() => Resource.NamespaceGram;
    }
}