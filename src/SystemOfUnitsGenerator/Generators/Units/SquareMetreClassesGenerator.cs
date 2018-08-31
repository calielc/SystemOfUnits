using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.BuildersCollection;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class SquareMetreClassesGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceUnit = Resource.NamespaceSquareMetre;

        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + NamespaceUnit;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + NamespaceUnit;

        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();

            return new ContextWithCastByPowerBuilderCollection(contexts, "Casting");
        }

        public IReadOnlyCollection<ContextWithCastByPower> BuildContexts() {
            var builder = new ContextWithCastByPowerBuilder(10);


            builder.Add(+36, new Context(NamespaceCode, NamespaceTest, "square exametre", "Em²"));
            builder.Add(+30, new Context(NamespaceCode, NamespaceTest, "square petametre", "Pm²"));
            builder.Add(+24, new Context(NamespaceCode, NamespaceTest, "square terametre", "Tm²"));
            builder.Add(+18, new Context(NamespaceCode, NamespaceTest, "square gigametre", "Gm²"));
            builder.Add(+12, new Context(NamespaceCode, NamespaceTest, "square megametre", "Mm²"));
            builder.Add(+06, new Context(NamespaceCode, NamespaceTest, "square kilometre", "km²"));
            builder.Add(+04, new Context(NamespaceCode, NamespaceTest, "square hectometre", "hm²"));
            builder.Add(+02, new Context(NamespaceCode, NamespaceTest, "square decametre", "dam²"));
            builder.Add(000, new Context(NamespaceCode, NamespaceTest, "square metre", "m²"));
            builder.Add(-02, new Context(NamespaceCode, NamespaceTest, "square decimetre", "dm²"));
            builder.Add(-04, new Context(NamespaceCode, NamespaceTest, "square centimetre", "cm²"));
            builder.Add(-06, new Context(NamespaceCode, NamespaceTest, "square millimetre", "mm²"));
            builder.Add(-12, new Context(NamespaceCode, NamespaceTest, "square micrometre", "μm²"));
            builder.Add(-18, new Context(NamespaceCode, NamespaceTest, "square nanometre", "nm²"));
            builder.Add(-24, new Context(NamespaceCode, NamespaceTest, "square picometre", "pm²"));
            builder.Add(-30, new Context(NamespaceCode, NamespaceTest, "square femtometre", "fm²"));
            builder.Add(-36, new Context(NamespaceCode, NamespaceTest, "square attometre", "am²"));

            builder.TestCases = new[]
            {
                //           Em,      Pm,      Tm,      Gm,      Mm,     km,     hm,    dam,      m,      dm,      cm,      mm,       um,       nm,       pm,       fm,       am
                //       10e+36,  10e+30,  10e+24,  10e+18,  10e+12,  10e+6,  10e+4,  10e+2,   10e0,   10e-2,   10e-4,   10e-6,   10e-12,   10e-18,   10e-24,   10e-30,   10e-36
                new[] {      0d,      0d,      0d,      0d,      0d,     0d,     0d,     0d,     0d,      0d,      0d,      0d,       0d,       0d,       0d,       0d,       0d },
                new[] {   -5e36,   -5e30,   -5e24,   -5e18,   -5e12,   -5e6,   -5e4,   -5e2,   -5e0,   -5e-2,   -5e-4,   -5e-6,   -5e-12,   -5e-18,   -5e-24,   -5e-30,   -5e-36 },
                new[] { 13.7e36, 13.7e30, 13.7e24, 13.7e18, 13.7e12, 13.7e6, 13.7e4, 13.7e2, 13.7e0, 13.7e-2, 13.7e-4, 13.7e-6, 13.7e-12, 13.7e-18, 13.7e-24, 13.7e-30, 13.7e-36 },
                new[] {     1e0,    1e-6,   1e-12,   1e-18,   1e-24,  1e-30,  1e-32,  1e-34,  1e-36,   1e-38,   1e-40,   1e-42,    1e-48,    1e-54,    1e-60,    1e-66,    1e-72 },
                new[] {    1e72,    1e66,    1e60,    1e54,    1e48,   1e42,   1e40,   1e38,   1e36,    1e34,    1e32,    1e30,     1e24,     1e18,     1e12,      1e6,      1e0 }
            };

            return builder.Build();
        }
    }
}