using System;
using System.Globalization;

namespace SystemOfUnitsTests {
    internal static class Consts {
        public const double DeltaAssert = 1e-3;

        public static IFormatProvider CultureEnUS = new CultureInfo("en-US");
    }
}