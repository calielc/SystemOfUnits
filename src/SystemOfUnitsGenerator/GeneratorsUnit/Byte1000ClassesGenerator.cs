using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit
{
    internal sealed class Byte1000ClassesGenerator : IGenerator
    {
        public IContentFileBuilderCollection Generate()
        {
            var contexts = BuildContexts();
            return new ClassesWithCastByPowerBuilder(contexts, "Casting1000");
        }

        private static IReadOnlyCollection<ContextWithCastByPower> BuildContexts()
        {
            var builder = new ContextWithCastByPowerBuilder(10);

            var namespaces = new UnitNamespaces(Resource.NamespaceByte1000);
            builder.Add(24, namespaces + new UnitDefinition("yottabyte", "YB", "Represents a Yottabyte (symbol YB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Yottabyte = 1,000 Zettabytes\n- 1 Yottabyte = 10^24 Bytes"));
            builder.Add(21, namespaces + new UnitDefinition("zettabyte", "ZB", "Represents a Zettabyte (symbol ZB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Zettabyte = 1,000 Exabytes\n- 1 Zettabyte = 10^21 Bytes"));
            builder.Add(18, namespaces + new UnitDefinition("exabyte", "EB", "Represents a Exabyte (symbol EB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Exabyte = 1,000 Petabytes\n- 1 Exabyte = 10^18 Bytes"));
            builder.Add(15, namespaces + new UnitDefinition("petabyte", "PB", "Represents a Petabyte (symbol PB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Petabyte = 1,000 Terabytes\n- 1 Petabyte = 10^15 Bytes"));
            builder.Add(12, namespaces + new UnitDefinition("terabyte", "TB", "Represents a Terabyte (symbol TB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Terabyte = 1,000 Gigabytes\n- 1 Terabyte = 10^12 Bytes"));
            builder.Add(09, namespaces + new UnitDefinition("gigabyte", "GB", "Represents a Gigabyte (symbol GB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Gigabyte = 1,000 Megabytes\n- 1 Gigabyte = 10^9 Bytes"));
            builder.Add(06, namespaces + new UnitDefinition("megabyte", "MB", "Represents a Megabyte (symbol MB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Megabyte = 1,000 Kilobytes\n- 1 Megabyte = 10^6 Bytes"));
            builder.Add(03, namespaces + new UnitDefinition("kilobyte", "kB", "Represents a Kilobyte (symbol kB).\n It is a multiple of the unit <c>Byte</c>, where:\n- 1 Kilobyte = 1,000 Bytes\n-  1 Kilobyte = 10^3 Bytes"));
            builder.Add(00, namespaces + new UnitDefinition("byte", "B", "Represents a Byte (symbol B).\nWhere:\n- 1 Byte = 8 Bits"));

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