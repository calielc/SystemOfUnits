using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class HertzClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "hertz";
        protected override string GetBaseSymbol() => "Hz";
        protected override NamespaceDefinition GetNamespace() => Resource.NamespaceHertz;
    }
}