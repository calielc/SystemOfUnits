using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.BuildersCollection;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class BitClassesGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceUnit = Resource.NamespaceBit;

        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + NamespaceUnit;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + NamespaceUnit;

        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();

            return new ContextWithCastByPowerBuilderCollection(contexts, "Casting");
        }

        private static IReadOnlyCollection<ContextWithCastByPower> BuildContexts() {
            var builder = new ContextWithCastByPowerBuilder(10);

            builder.Add(12, new Context(NamespaceCode, NamespaceTest, "terabit", "Tb", new XmlDoc("Represents a Terabit (symbol Tb).\nIt is a multiple of the unit <c>Bit</c>, where:\n- 1 Terabit = 1,000 Gigabit\n- 1 Terabit = 10^12 Bits")));
            builder.Add(09, new Context(NamespaceCode, NamespaceTest, "gigabit", "Gb", new XmlDoc("Represents a Gigabit (symbol Gb).\nIt is a multiple of the unit <c>Bit</c>, where:\n- 1 Gigabit = 1,000 Megabit\n- 1 Gigabit = 10^9 Bits")));
            builder.Add(06, new Context(NamespaceCode, NamespaceTest, "megabit", "Mb", new XmlDoc("Represents a Megabit (symbol Mb).\nIt is a multiple of the unit <c>Bit</c>, where:\n- 1 Megabit = 1,000 Kilobit\n- 1 Megabit = 10^6 Bits")));
            builder.Add(03, new Context(NamespaceCode, NamespaceTest, "kilobit", "Kb", new XmlDoc("Represents a Kilobit (symbol Kb).\nIt is a multiple of the unit <c>Bit</c>, where:\n- 1 Kilobit = 1,000 Bits\n- 1 Kilobit = 10^3 Bits")));
            builder.Add(00, new Context(NamespaceCode, NamespaceTest, "bit", "b", new XmlDoc("Represents a Bit (symbol b).\nWhere:\n- 8 bits = 1 byte")));

            builder.TestCases = new[]
            {
                //      terabit, gigabit, megabit, kilobit,    bit 
                //       10e+12,   10e+9,   10e+6,   10e+3,   10e0
                new[] {      0d,      0d,      0d,      0d,     0d },
                new[] { 13.7e12,  13.7e9,  13.7e6,  13.7e3, 13.7e0 },
                new[] {    -5e6,    -5e3,    -5e0,   -5e-3,  -5e-6 },
                new[] {     1e0,    1e-3,    1e-6,    1e-9,  1e-12 }
            };

            return builder.Build();
        }
    }
}
