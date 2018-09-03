namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class LitreClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "litre";
        protected override string GetBaseSymbol() => "l";
        protected override string GetNamespace() => Resource.NamespaceLitre;
    }
}