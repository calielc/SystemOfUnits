using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class WattClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "watt";
        protected override string GetBaseSymbol() => "W";
        protected override NamespaceDefinition GetNamespace() => Resource.NamespaceWatt;
    }
}