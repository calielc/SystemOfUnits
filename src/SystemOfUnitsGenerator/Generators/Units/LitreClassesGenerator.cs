using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class LitreClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "litre";
        protected override string GetBaseSymbol() => "l";
        protected override NamespaceDefinition GetNamespace() => Resource.NamespaceLitre;
    }
}