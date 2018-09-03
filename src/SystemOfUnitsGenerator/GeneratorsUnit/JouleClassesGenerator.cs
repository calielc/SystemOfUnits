namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class JouleClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "joule";
        protected override string GetBaseSymbol() => "J";
        protected override string GetNamespace() => Resource.NamespaceJoule;
    }
}