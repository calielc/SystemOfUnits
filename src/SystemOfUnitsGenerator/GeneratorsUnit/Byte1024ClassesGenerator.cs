﻿using System;
using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class Byte1024ClassesGenerator : IGenerator {
        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts();

            return new ClassesWithCastByPowerBuilder(contexts, "Casting1024");
        }

        private static IReadOnlyCollection<ContextWithCastByPower> BuildContexts() {
            var builder = new ContextWithCastByPowerBuilder(2);

            var namespaces = new UnitNamespaces(Resource.NamespaceByte1024);
            builder.Add(80, namespaces + new UnitDefinition("yobibyte", "YiB", "Represents a Yobibyte (symbol YiB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Yobibyte = 1,024 Zebibytes\n- 1 Yobibyte = 1024^8 or 2^80 Bytes"));
            builder.Add(70, namespaces + new UnitDefinition("zebibyte", "ZiB", "Represents a Zebibyte (symbol ZiB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Zebibyte = 1,024 Exbibytes\n- 1 Zebibyte = 1024^7 or 2^70 Bytes"));
            builder.Add(60, namespaces + new UnitDefinition("exbibyte", "EiB", "Represents a Exbibyte (symbol EiB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Exbibyte = 1,024 Pebibytes\n- 1 Exbibyte = 1024^6 or 2^60 Bytes"));
            builder.Add(50, namespaces + new UnitDefinition("pebibyte", "PiB", "Represents a Pebibyte (symbol PiB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Pebibyte = 1,024 Tebibytes\n- 1 Pebibyte = 1024^5 or 2^50 Bytes"));
            builder.Add(40, namespaces + new UnitDefinition("tebibyte", "TiB", "Represents a Tebibyte (symbol TiB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Tebibyte = 1,024 Gibibytes\n- 1 Tebibyte = 1024^4 or 2^40 Bytes"));
            builder.Add(30, namespaces + new UnitDefinition("gibibyte", "GiB", "Represents a Gibibyte (symbol GiB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Gibibyte = 1,024 Mebibytes\n- 1 Gibibyte = 1024^3 or 2^30 Bytes"));
            builder.Add(20, namespaces + new UnitDefinition("mebibyte", "MiB", "Represents a Mebibyte (symbol MiB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Mebibyte = 1,024 Kibibytes\n- 1 Mebibyte = 1024^2 or 2^20 Bytes"));
            builder.Add(10, namespaces + new UnitDefinition("kibibyte", "KiB", "Represents a Kibibyte (symbol KiB).\nIt is a multiple of the unit <c>Byte</c>, where:\n- 1 Kibibyte = 1,024 bytes    \n- 1 Kibibyte = 1024^1 or 2^10 Bytes"));
            builder.Add(00, namespaces + new UnitDefinition("byte", "B", "Represents a Byte (symbol B).\nWhere:\n- 1 Byte = 8 Bits"));

            builder.TestCases = new[] {
                //                   yottabyte,              zettabyte,                exabyte,               petabyte,               terabyte,               gigabyte,               megabyte,               kilobyte,                  byte
                //                       2e+80,                  2e+70,                  2e+60,                  2e+50,                  2e+40,                  2e+30,                  2e+20,                  2e+10,                  2e+0
                new[] {                     0d,                     0d,                     0d,                     0d,                     0d,                     0d,                     0d,                     0d,                    0d },
                new[] {        Math.Pow(2, 80),        Math.Pow(2, 70),        Math.Pow(2, 60),        Math.Pow(2, 50),        Math.Pow(2, 40),        Math.Pow(2, 30),        Math.Pow(2, 20),        Math.Pow(2, 10),        Math.Pow(2, 00) },
                new[] {   -5 * Math.Pow(2, 80),   -5 * Math.Pow(2, 70),   -5 * Math.Pow(2, 60),   -5 * Math.Pow(2, 50),   -5 * Math.Pow(2, 40),   -5 * Math.Pow(2, 30),   -5 * Math.Pow(2, 20),   -5 * Math.Pow(2, 10),   -5 * Math.Pow(2, 00) },
                new[] {    3 * Math.Pow(2, 00),   3 * Math.Pow(2, -10),   3 * Math.Pow(2, -20),   3 * Math.Pow(2, -30),   3 * Math.Pow(2, -40),   3 * Math.Pow(2, -50),   3 * Math.Pow(2, -60),   3 * Math.Pow(2, -70),   3 * Math.Pow(2, -80) },
                new[] { 13.7 * Math.Pow(2, 80), 13.7 * Math.Pow(2, 70), 13.7 * Math.Pow(2, 60), 13.7 * Math.Pow(2, 50), 13.7 * Math.Pow(2, 40), 13.7 * Math.Pow(2, 30), 13.7 * Math.Pow(2, 20), 13.7 * Math.Pow(2, 10), 13.7 * Math.Pow(2, 00) },
            };

            return builder.Build();
        }
    }
}