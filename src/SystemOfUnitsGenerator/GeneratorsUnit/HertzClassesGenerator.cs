namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class HertzClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "hertz";
        protected override string GetBaseSymbol() => "Hz";
        protected override string GetNamespace() => Resource.NamespaceHertz;
    }
}