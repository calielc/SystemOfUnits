using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators.BuildersCollection;
using SystemOfUnitsGenerator.Generators.Engine;

namespace SystemOfUnitsGenerator.Generators.Units {
    internal sealed class Byte1000ClassesGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceUnit = Resource.NamespaceByte1000;

        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + NamespaceUnit;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + NamespaceUnit;

        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();
            return new ContextWithCastByPowerBuilderCollection(contexts, "Casting1000");
        }

        private static IReadOnlyCollection<ContextWithCastByPower> BuildContexts() {
            var builder = new ContextWithCastByPowerBuilder(10);
            builder.Add(24, new Context(NamespaceCode, NamespaceTest, "yottabyte", "YB", new XmlDoc("Represents a Yottabyte (symbol YB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Yottabyte = 1,000 Zettabytes\n- 1 Yottabyte = 10^24 Bytes")));
            builder.Add(21, new Context(NamespaceCode, NamespaceTest, "zettabyte", "ZB", new XmlDoc("Represents a Zettabyte (symbol ZB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Zettabyte = 1,000 Exabytes\n- 1 Zettabyte = 10^21 Bytes")));
            builder.Add(18, new Context(NamespaceCode, NamespaceTest, "exabyte", "EB", new XmlDoc("Represents a Exabyte (symbol EB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Exabyte = 1,000 Petabytes\n- 1 Exabyte = 10^18 Bytes")));
            builder.Add(15, new Context(NamespaceCode, NamespaceTest, "petabyte", "PB", new XmlDoc("Represents a Petabyte (symbol PB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Petabyte = 1,000 Terabytes\n- 1 Petabyte = 10^15 Bytes")));
            builder.Add(12, new Context(NamespaceCode, NamespaceTest, "terabyte", "TB", new XmlDoc("Represents a Terabyte (symbol TB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Terabyte = 1,000 Gigabytes\n- 1 Terabyte = 10^12 Bytes")));
            builder.Add(09, new Context(NamespaceCode, NamespaceTest, "gigabyte", "GB", new XmlDoc("Represents a Gigabyte (symbol GB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Gigabyte = 1,000 Megabytes\n- 1 Gigabyte = 10^9 Bytes")));
            builder.Add(06, new Context(NamespaceCode, NamespaceTest, "megabyte", "MB", new XmlDoc("Represents a Megabyte (symbol MB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Megabyte = 1,000 Kilobytes\n- 1 Megabyte = 10^6 Bytes")));
            builder.Add(03, new Context(NamespaceCode, NamespaceTest, "kilobyte", "kB", new XmlDoc("Represents a Kilobyte (symbol kB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Kilobyte = 1,000 Bytes\n-  1 Kilobyte = 10^3 Bytes")));
            builder.Add(00, new Context(NamespaceCode, NamespaceTest, "byte", "B", new XmlDoc("Represents a Byte (symbol B).\nWhere:\n- 1 Byte = 8 Bits")));

            builder.TestCases = new[]
            { 
                //           Ym,      Zm,      Em,      Pm,      Tm,     Gm,     Mm,     km,      m 
                //       10e+24,  10e+21,  10e+18,  10e+15,  10e+12,  10e+9,  10e+6,  10e+3,   10e0 
                new[] {      0d,      0d,      0d,      0d,      0d,     0d,     0d,     0d,     0d },
                new[] { 13.7e24, 13.7e21, 13.7e18, 13.7e15, 13.7e12, 13.7e9, 13.7e6, 13.7e3, 13.7e0 },
                new[] {   -5e24,   -5e21,   -5e18,   -5e15,   -5e12,   -5e9,   -5e6,   -5e3,   -5e0 },
                new[] {     1e0,    1e-3,    1e-6,    1e-9,   1e-12,  1e-15,  1e-18,  1e-21,  1e-24 },
            };

            return builder.Build();
        }
    }
}