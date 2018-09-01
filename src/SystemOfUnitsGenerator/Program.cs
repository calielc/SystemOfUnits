using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SystemOfUnitsGenerator.Common;
using SystemOfUnitsGenerator.Generators;
using SystemOfUnitsGenerator.GeneratorsCurrency;
using SystemOfUnitsGenerator.GeneratorsUnit;

namespace SystemOfUnitsGenerator {
    internal class Program {
        private static async Task Main(string[] args) {
            var fileSystem = new FileSystem(args[0]);

            var generators = new FilesGenerator(IdentifyGenerators());
            generators.Generating += (sender, file) => Console.WriteLine(file.Name);
            await generators.Generate(fileSystem);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        private static IEnumerable<IGenerator> IdentifyGenerators() {
            yield return new MetreClassesGenerator();
            yield return new SquareMetreClassesGenerator();
            yield return new CubicMetreClassesGenerator();

            yield return new HertzClassesGenerator();
            yield return new JouleClassesGenerator();
            yield return new GramClassesGenerator();
            yield return new WattClassesGenerator();
            yield return new LitreClassesGenerator();

            yield return new ImperialLengthClassesGenerator();

            yield return new AngleClassesGenerator();

            yield return new TemperatureClassesGenerator();

            yield return new TimeClassesGenerator();

            yield return new BitClassesGenerator();
            yield return new Byte1000ClassesGenerator();
            yield return new Byte1024ClassesGenerator();

            yield return new PercentageGenerator();

            yield return new CurrencyGenerator();
        }
    }
}
