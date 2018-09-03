using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class PixelClassesGenerator : IGenerator {
        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();

            return new ClassesWithCastByPowerBuilder(contexts, "Casting");
        }

        private static IReadOnlyCollection<ContextWithCastByPower> BuildContexts() {
            var builder = new ContextWithCastByPowerBuilder(10);

            var namespaces = new UnitNamespaces(Resource.NamespacePixel);
            builder.Add(06, namespaces + new UnitDefinition("megapixel", "MP", "Represents a Megapixel (symbol MP).\nIt is a multiple of the unit <c>Pixel</c>, where:\n- 1 Megapixel = 1,000,000 Pixels"));
            builder.Add(00, namespaces + new UnitDefinition("pixel", "px"));

            builder.TestCases = new[] {
                //     megapixel,  pixel
                //         10e+6,   10e0
                new[] {       0d,     0d },
                new[] {   13.7e6, 13.7e0 },
                new[] {     -5e0,  -5e-6 },
                new[] {     1e-6,  1e-12 }
            };

            return builder.Build();
        }
    }
}