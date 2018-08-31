using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.BuildersCollection;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class CubicMetreClassesGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceUnit = Resource.NamespaceCubicMetre;

        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + NamespaceUnit;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + NamespaceUnit;

        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();

            return new ContextWithCastByPowerBuilderCollection(contexts, "Casting");
        }

        public IReadOnlyCollection<ContextWithCastByPower> BuildContexts() {
            var builder = new ContextWithCastByPowerBuilder(10);

            builder.Add(+9, new Context(NamespaceCode, NamespaceTest, "cubic kilometre", "km³", new XmlDoc("Represents a Cubic Kilometre (symbol km³).\nIt is a multiple of the unit <c>Cubic Metre</c>, where:\n- 1 Cubic Kilometre = 1,000 Cubic Hectometre\n- 1 Cubic Kilometre = 10^9 Cubic Metre")));
            builder.Add(+6, new Context(NamespaceCode, NamespaceTest, "cubic hectometre", "hm³", new XmlDoc("Represents a Cubic Hectometre (symbol hm³).\nIt is a multiple of the unit <c>Cubic Metre</c>, where:\n- 1 Cubic Hectometre = 1,000 Cubic Decametre\n- 1 Cubic Hectometre = 10^6 Cubic Metre")));
            builder.Add(+3, new Context(NamespaceCode, NamespaceTest, "cubic decametre", "dam³", new XmlDoc("Represents a Cubic Decametre (symbol dam³).\nIt is a multiple of the unit <c>Cubic Metre</c>, where:\n- 1 Cubic Decametre = 1,000 Cubic Metre\n- 1 Cubic Decametre = 10^3 Cubic Metre")));
            builder.Add(00, new Context(NamespaceCode, NamespaceTest, "cubic metre", "m³", new XmlDoc("Represents a Cubic Metre (symbol m³).")));
            builder.Add(-3, new Context(NamespaceCode, NamespaceTest, "cubic decimetre", "dm³", new XmlDoc("Represents a Cubic Decimetre (symbol dm³).\nIt is a multiple of the unit <c>Cubic Metre</c>, where:\n- 1,000 Cubic Decimetre = 1 Cubic Metre\n- 1 Cubic Decimetre = 10^-3 Cubic Metre")));
            builder.Add(-6, new Context(NamespaceCode, NamespaceTest, "cubic centimetre", "cm³", new XmlDoc("Represents a Cubic Centimetre (symbol cm³).\nIt is a multiple of the unit <c>Cubic Metre</c>, where:\n- 1,000 Cubic Centimetre = 1 Cubic Decimetre\n- 1 Cubic Centimetre = 10^-6 Cubic Metre")));
            builder.Add(-9, new Context(NamespaceCode, NamespaceTest, "cubic millimetre", "mm³", new XmlDoc("Represents a Cubic Millimetre (symbol mm³).\nIt is a multiple of the unit <c>Cubic Metre</c>, where:\n- 1,000 Cubic Millimetre = 1 Cubic Centimetre\n- 1 Cubic Millimetre = 10^-9 Cubic Metre")));

            builder.TestCases = new[]
            {
                //          km,     hm,    dam,      m,      dm,      cm,      mm
                //       10e+9,  10e+6,  10e+3,   10e0,   10e-3,   10e-6,   10e-9
                new[] {     0d,     0d,     0d,     0d,      0d,      0d,      0d },
                new[] {   -5e9,   -5e6,   -5e3,   -5e0,   -5e-3,   -5e-6,   -5e-9 },
                new[] { 13.7e9, 13.7e6, 13.7e3, 13.7e0, 13.7e-3, 13.7e-6, 13.7e-9 },
                new[] {    1e0,   1e-3,   1e-6,   1e-9,   1e-12,   1e-15,   1e-18 },
                new[] {   1e18,   1e15,   1e12,    1e9,     1e6,     1e3,     1e0 }
            };

            return builder.Build();
        }
    }
}