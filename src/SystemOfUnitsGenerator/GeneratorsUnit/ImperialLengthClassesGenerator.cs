using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class ImperialLengthClassesGenerator : IGenerator {
        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts().ToReadOnlyList();

            return new ClassesWithCastByRatioBuilder(contexts, "Casting");
        }

        private static IEnumerable<ContextWithCastByRatio> BuildContexts() {
            var namespaces = new UnitNamespaces(Resource.NamespaceImperialLength);

            var zeroTestCase = new CastRatioTestCase(0d, 0d, 0d, 0d);

            yield return new ContextWithCastByRatio(
                context: namespaces + new UnitDefinition("inch", "in"),
                ratio: new CastRatio(1d / 12, "1d / 12d", "FootRatio"),
                testCases: new[]
                {
                    zeroTestCase,
                    new CastRatioTestCase(1d, 0.0833333d, 0.0277778d, 1.5783e-5d),
                    new CastRatioTestCase(10d, 0.833333d, 0.277778d, 1.5783e-4d),
                    new CastRatioTestCase(-0.5d, -0.0416667d, -0.0138889d, -7.8914204545e-6d),
                });

            yield return new ContextWithCastByRatio(
                context: namespaces + new UnitDefinition("foot", "ft"),
                ratio: new CastRatio(1, "1", "FootRatio"),
                testCases: new[]
                {
                    zeroTestCase,
                    new CastRatioTestCase(1d, 12d, 0.333333d, 0.000189394d),
                    new CastRatioTestCase(10d, 120d, 3.33333d, 0.00189394d),
                    new CastRatioTestCase(-0.5d, -6d, -0.166667d, -9.4697e-5d),
                });

            yield return new ContextWithCastByRatio(
                context: namespaces + new UnitDefinition("yard", "yd"),
                ratio: new CastRatio(3, "3", "FootRatio"),
                testCases: new[]
                {
                    zeroTestCase,
                    new CastRatioTestCase(1d, 36d, 3d, 0.000568182d),
                    new CastRatioTestCase(10d, 360d, 30d, 0.00568182d),
                    new CastRatioTestCase(-0.5d, -18d, -1.5d, -0.000284091d),
                });

            yield return new ContextWithCastByRatio(
                context: namespaces + new UnitDefinition("mile", "mi"),
                ratio: new CastRatio(5_280, "5_280", "FootRatio"),
                testCases: new[]
                {
                    zeroTestCase,
                    new CastRatioTestCase(1d, 63360d, 5280d, 1760d),
                    new CastRatioTestCase(10d, 633600d, 52800d, 17600d),
                    new CastRatioTestCase(-0.5d, -31680d, -2640d, -880d),
                });
        }
    }
}