using System;
using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class AngleClassesGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceUnit = Resource.NamespaceAngle;

        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + NamespaceUnit;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + NamespaceUnit;

        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts().ToReadOnlyList();

            return new ClassesWithCastByRatioBuilder(contexts, "Casting");
        }

        private static IEnumerable<ContextWithCastByRatio> BuildContexts() {
            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "Radian", "rad"),
                ratio: new CastRatio(1, "1", "RadianRatio"),
                testCases: new[] {
                    new CastRatioTestCase(0d, 0d, 0d),
                    new CastRatioTestCase(Math.PI / 6, 1e3 * Math.PI / 6, 30d),
                    new CastRatioTestCase(Math.PI / 4, 1e3 * Math.PI / 4, 45d),
                    new CastRatioTestCase(Math.PI / 3, 1e3 * Math.PI / 3, 60d),
                    new CastRatioTestCase(Math.PI / 2, 1e3 * Math.PI / 2, 90d),
                    new CastRatioTestCase(Math.PI, 1e3 * Math.PI, 180d),
                    new CastRatioTestCase(Math.PI * 3 / 2d, 1e3 * Math.PI * 3 / 2, 270d),
                    new CastRatioTestCase(Math.PI * 2, 1e3 * Math.PI * 2, 360d),
                    new CastRatioTestCase(-Math.PI, 1e3 * -Math.PI, -180d),
                });

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "Milliradian", "mrad"),
                ratio: new CastRatio(1e-3, "0.001d", "RadianRatio"),
                testCases: new[] {
                    new CastRatioTestCase(0d, 0d, 0d),
                    new CastRatioTestCase(1e3 * Math.PI / 6, Math.PI / 6, 30d),
                    new CastRatioTestCase(1e3 * Math.PI / 4, Math.PI / 4, 45d),
                    new CastRatioTestCase(1e3 * Math.PI / 3, Math.PI / 3, 60d),
                    new CastRatioTestCase(1e3 * Math.PI / 2, Math.PI / 2, 90d),
                    new CastRatioTestCase(1e3 * Math.PI, Math.PI, 180d),
                    new CastRatioTestCase(1e3 * Math.PI * 3 / 2d, Math.PI * 3 / 2, 270d),
                    new CastRatioTestCase(1e3 * Math.PI * 2, Math.PI * 2, 360d),
                    new CastRatioTestCase(1e3 * -Math.PI, -Math.PI, -180d),
                });

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "Degree", "°"),
                ratio: new CastRatio(Math.PI / 180d, "System.Math.PI / 180d", "RadianRatio"),
                testCases: new[] {
                    new CastRatioTestCase(0d, 0d, 0d),
                    new CastRatioTestCase(30d, Math.PI / 6, 1e3 * Math.PI / 6),
                    new CastRatioTestCase(45d, Math.PI / 4, 1e3 * Math.PI / 4),
                    new CastRatioTestCase(60d, Math.PI / 3, 1e3 * Math.PI / 3),
                    new CastRatioTestCase(90d, Math.PI / 2, 1e3 * Math.PI / 2),
                    new CastRatioTestCase(180d, Math.PI, 1e3 * Math.PI),
                    new CastRatioTestCase(270d, Math.PI * 3 / 2, 1e3 * Math.PI * 3 / 2),
                    new CastRatioTestCase(360d, Math.PI * 2, 1e3 * Math.PI * 2),
                    new CastRatioTestCase(-180d, -Math.PI, 1e3 * -Math.PI),
                });
        }
    }
}