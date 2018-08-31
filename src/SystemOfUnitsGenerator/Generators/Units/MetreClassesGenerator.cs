using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.BuildersCollection;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class MetreClassesGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceUnit = Resource.NamespaceMetre;

        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + NamespaceUnit;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + NamespaceUnit;

        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();

            return new ContextWithCastByPowerBuilderCollection(contexts, "Casting");
        }

        private static IReadOnlyCollection<ContextWithCastByPower> BuildContexts() {
            var builder = new ContextWithCastByPowerBuilder(10);

            builder.Add(+18, new Context(NamespaceCode, NamespaceTest, "exametre", "Em"));
            builder.Add(+15, new Context(NamespaceCode, NamespaceTest, "petametre", "Pm"));
            builder.Add(+12, new Context(NamespaceCode, NamespaceTest, "terametre", "Tm"));
            builder.Add(+09, new Context(NamespaceCode, NamespaceTest, "gigametre", "Gm"));
            builder.Add(+06, new Context(NamespaceCode, NamespaceTest, "megametre", "Mm"));
            builder.Add(+03, new Context(NamespaceCode, NamespaceTest, "kilometre", "km"));
            builder.Add(+02, new Context(NamespaceCode, NamespaceTest, "hectometre", "hm"));
            builder.Add(+01, new Context(NamespaceCode, NamespaceTest, "decametre", "dam"));
            builder.Add(000, new Context(NamespaceCode, NamespaceTest, "metre", "m"));
            builder.Add(-01, new Context(NamespaceCode, NamespaceTest, "decimetre", "dm"));
            builder.Add(-02, new Context(NamespaceCode, NamespaceTest, "centimetre", "cm"));
            builder.Add(-03, new Context(NamespaceCode, NamespaceTest, "millimetre", "mm"));
            builder.Add(-06, new Context(NamespaceCode, NamespaceTest, "micrometre", "μm"));
            builder.Add(-09, new Context(NamespaceCode, NamespaceTest, "nanometre", "nm"));
            builder.Add(-12, new Context(NamespaceCode, NamespaceTest, "picometre", "pm"));
            builder.Add(-15, new Context(NamespaceCode, NamespaceTest, "femtometre", "fm"));
            builder.Add(-18, new Context(NamespaceCode, NamespaceTest, "attometre", "am"));

            builder.TestCases = new[]
            { 
                //           Em,      Pm,      Tm,     Gm,     Mm,     km,     hm,    dam,      m,      dm,      cm,      mm,      um,      nm,       pm,       fm,       am
                //       10e+18,  10e+15,  10e+12,  10e+9,  10e+6,  10e+3,  10e+2,  10e+1,   10e0,   10e-1,   10e-2,   10e-3,   10e-6,   10e-9,   10e-12,   10e-15,   10e-18
                new[] {      0d,      0d,      0d,     0d,     0d,     0d,     0d,     0d,     0d,      0d,      0d,      0d,      0d,      0d,       0d,       0d,       0d },
                new[] { 13.7e18, 13.7e15, 13.7e12, 13.7e9, 13.7e6, 13.7e3, 13.7e2, 13.7e1, 13.7e0, 13.7e-1, 13.7e-2, 13.7e-3, 13.7e-6, 13.7e-9, 13.7e-12, 13.7e-15, 13.7e-18 },
                new[] {   -5e18,   -5e15,   -5e12,   -5e9,   -5e6,   -5e3,   -5e2,   -5e1,   -5e0,   -5e-1,   -5e-2,   -5e-3,   -5e-6,   -5e-9,   -5e-12,   -5e-15,   -5e-18 },
                new[] {     1e0,    1e-3,    1e-6,   1e-9,  1e-12,  1e-15,  1e-16,  1e-17,  1e-18,   1e-19,   1e-20,   1e-21,   1e-24,   1e-27,    1e-30,    1e-33,    1e-36 },
                new[] {    1e36,    1e33,    1e30,   1e27,   1e24,   1e21,   1e20,   1e19,   1e18,    1e17,    1e16,    1e15,    1e12,     1e9,      1e6,      1e3,      1e0 }
            };

            return builder.Build();
        }
    }
}