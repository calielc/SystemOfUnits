using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class GramClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "gram";
        protected override string GetBaseSymbol() => "g";
        protected override NamespaceDefinition GetNamespace() => Resource.NamespaceGram;
    }
}