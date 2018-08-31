﻿using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class JouleClassesGenerator : AbstractMetricClassesGenerator {
        protected override string GetBaseUnit() => "joule";
        protected override string GetBaseSymbol() => "J";
        protected override NamespaceDefinition GetNamespace() => Resource.NamespaceJoule;
    }
}