namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class WattClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "watt";
        protected override string GetBaseSymbol() => "W";
        protected override string GetNamespace() => Resource.NamespaceWatt;
    }
}