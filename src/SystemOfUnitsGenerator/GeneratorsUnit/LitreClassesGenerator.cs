using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class LitreClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "litre";
        protected override string GetBaseSymbol() => "l";
        protected override NamespaceDefinition GetNamespace() => Resource.NamespaceLitre;
    }
}