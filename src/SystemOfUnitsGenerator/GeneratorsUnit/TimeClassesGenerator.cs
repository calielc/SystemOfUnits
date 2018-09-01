using System.Collections.Generic;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Engine;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsUnit.Builders;

namespace SystemOfUnitsGenerator.GeneratorsUnit {
    internal sealed class TimeClassesGenerator : IGenerator {
        private static readonly NamespaceDefinition NamespaceTime = Resource.NamespaceTime;

        private static readonly NamespaceDefinition NamespaceCode = NamespaceDefinition.SystemOfUnits + NamespaceTime;
        private static readonly NamespaceDefinition NamespaceTest = NamespaceDefinition.SystemOfUnitsTests + NamespaceTime;

        public IContentFileBuilderCollection Generate() {
            var contexts = BuildContexts().ToReadOnlyList();

            return new ClassesWithCastByRatioBuilder(contexts, "Casting");
        }

        private const double MonthsPerYear = 12d;

        private const double WeeksPerYear = DaysPerYear / DaysPerWeek;
        private const double WeeksPerMonth = DaysPerMonth / DaysPerWeek;

        private const double DaysPerYear = 365.2425d;
        private const double DaysPerMonth = DaysPerYear / MonthsPerYear;
        private const double DaysPerWeek = 7d;

        private const double HoursPerYear = DaysPerYear * HoursPerDay;
        private const double HoursPerMonth = DaysPerMonth * HoursPerDay;
        private const double HoursPerWeek = DaysPerWeek * HoursPerDay;
        private const double HoursPerDay = 24d;

        private const double MinutesPerYear = DaysPerYear * MinutesPerDay;
        private const double MinutesPerMonth = DaysPerMonth * MinutesPerDay;
        private const double MinutesPerWeek = DaysPerWeek * MinutesPerDay;
        private const double MinutesPerDay = HoursPerDay * MinutesPerHour;
        private const double MinutesPerHour = 60d;

        private const double SecondsPerYear = DaysPerYear * SecondsPerDay;
        private const double SecondsPerMonth = DaysPerMonth * SecondsPerDay;
        private const double SecondsPerWeek = DaysPerWeek * SecondsPerDay;
        private const double SecondsPerDay = HoursPerDay * SecondsPerHour;
        private const double SecondsPerHour = MinutesPerHour * SecondsPerMinute;
        private const double SecondsPerMinute = 60d;

        private const double MillisecondsPerYear = DaysPerYear * MillisecondsPerDay;
        private const double MillisecondsPerMonth = DaysPerMonth * MillisecondsPerDay;
        private const double MillisecondsPerWeek = DaysPerWeek * MillisecondsPerDay;
        private const double MillisecondsPerDay = HoursPerDay * MillisecondsPerHour;
        private const double MillisecondsPerHour = MinutesPerHour * MillisecondsPerMinute;
        private const double MillisecondsPerMinute = SecondsPerMinute * MillisecondsPerSecond;
        private const double MillisecondsPerSecond = 1_000;

        private static IEnumerable<ContextWithCastByRatio> BuildContexts() {
            var zeroTestCase = new CastRatioTestCase(0, 0, 0, 0, 0, 0, 0, 0);

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "year", "years"),
                ratio: new CastRatio(146_097d / 400d, "/* ~365.2425 */ 146_097d / 400d", "DayPortion"),
                testCases: new[] {
                    zeroTestCase,
                    new CastRatioTestCase(1, MonthsPerYear, WeeksPerYear, DaysPerYear, HoursPerYear, MinutesPerYear, SecondsPerYear, MillisecondsPerYear),
                    new CastRatioTestCase(4, 4 * MonthsPerYear, 4 * WeeksPerYear, 4 * 365.25, 1461 * HoursPerDay, 1461 * MinutesPerDay, 1461 * SecondsPerDay, 1461 * MillisecondsPerDay),
                }
            );

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "month", "months"),
                ratio: new CastRatio(48_699d / 1_600d, "/* ~30.436875 */ 48_699d / 1_600d", "DayPortion"),
                testCases: new[] {
                    zeroTestCase,
                    new CastRatioTestCase(1, 1 / MonthsPerYear, WeeksPerMonth, DaysPerMonth, HoursPerMonth, MinutesPerMonth, SecondsPerMonth, MillisecondsPerMonth),
                    new CastRatioTestCase(MonthsPerYear, 1d, WeeksPerYear, DaysPerYear, HoursPerYear, MinutesPerYear, SecondsPerYear, MillisecondsPerYear),
                }
            );

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "week", "weeks"),
                ratio: new CastRatio(7, "7", "DayPortion"),
                testCases: new[] {
                    zeroTestCase,
                    new CastRatioTestCase(1, DaysPerWeek / DaysPerYear, DaysPerWeek / DaysPerMonth, DaysPerWeek, HoursPerWeek, MinutesPerWeek, SecondsPerWeek, MillisecondsPerWeek),
                    new CastRatioTestCase(WeeksPerYear, 1, MonthsPerYear, DaysPerYear, HoursPerYear, MinutesPerYear, SecondsPerYear, MillisecondsPerYear),
                }
            );

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "day", "days"),
                ratio: new CastRatio(1, "1", "DayPortion"),
                testCases: new[] {
                    zeroTestCase,
                    new CastRatioTestCase(1, 1 / DaysPerYear, 1 / DaysPerMonth, 1 / DaysPerWeek, HoursPerDay, MinutesPerDay, SecondsPerDay, MillisecondsPerDay),
                    new CastRatioTestCase(DaysPerMonth, 1 / MonthsPerYear, 1, WeeksPerMonth, HoursPerMonth, MinutesPerMonth, SecondsPerMonth, MillisecondsPerMonth),
                    new CastRatioTestCase(DaysPerYear, 1, MonthsPerYear, WeeksPerYear, HoursPerYear, MinutesPerYear, SecondsPerYear, MillisecondsPerYear),
                }
            );

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "hour", "hours"),
                ratio: new CastRatio(1d / 24d, "1d / 24d", "DayPortion"),
                testCases: new[] {
                    zeroTestCase,
                    new CastRatioTestCase(1, 1 / HoursPerYear, 1 / HoursPerMonth, 1 / HoursPerWeek, 1 / HoursPerDay, MinutesPerHour, SecondsPerHour, MillisecondsPerHour),
                    new CastRatioTestCase(HoursPerDay, 1 / DaysPerYear, 1 / DaysPerMonth, 1 / DaysPerWeek, 1, MinutesPerDay, SecondsPerDay, MillisecondsPerDay),
                }
            );

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "minute", "minutes"),
                ratio: new CastRatio(1d / (24d * 60d), "1d / (24d * 60d)", "DayPortion"),
                testCases: new[] {
                    zeroTestCase,
                    new CastRatioTestCase(1, 1 / MinutesPerYear, 1 / MinutesPerMonth, 1 / MinutesPerWeek, 1 / MinutesPerDay, 1 / MinutesPerHour, SecondsPerMinute, MillisecondsPerMinute),
                    new CastRatioTestCase(MinutesPerHour, 1 / HoursPerYear, 1 / HoursPerMonth, 1 / HoursPerWeek, 1 / HoursPerDay, 1, SecondsPerHour, MillisecondsPerHour),
                }
            );

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "second", "seconds"),
                ratio: new CastRatio(1d / (24d * 60d * 60d), "1d / (24d * 60d * 60d)", "DayPortion"),
                testCases: new[] {
                    zeroTestCase,
                    new CastRatioTestCase(1, 1 / SecondsPerYear, 1 / SecondsPerMonth, 1 / SecondsPerWeek, 1 / SecondsPerDay, 1 / SecondsPerHour, 1 / SecondsPerMinute, MillisecondsPerSecond),
                    new CastRatioTestCase(SecondsPerDay, 1 / DaysPerYear, 1 / DaysPerMonth, 1 / DaysPerWeek, 1, HoursPerDay, MinutesPerDay, MillisecondsPerDay),
                }
            );

            yield return new ContextWithCastByRatio(
                context: new Context(NamespaceCode, NamespaceTest, "Millisecond", "milliseconds"),
                ratio: new CastRatio(1d / (24d * 60d * 60d * 1_000d), "1d / (24d * 60d * 60d * 1_000d)", "DayPortion"),
                testCases: new[] {
                    zeroTestCase,
                    new CastRatioTestCase(1, 1 / MillisecondsPerYear, 1 / MillisecondsPerMonth, 1 / MillisecondsPerWeek, 1 / MillisecondsPerDay, 1 / MillisecondsPerHour, 1 / MillisecondsPerMinute, 1 / MillisecondsPerSecond),
                    new CastRatioTestCase(MillisecondsPerHour, 1 / HoursPerYear, 1 / HoursPerMonth, 1 / HoursPerWeek, 1 / HoursPerDay, 1, MinutesPerHour, SecondsPerHour),
                }
            );
        }
    }
}