using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemOfUnitsGenerator.Generators;

namespace SystemOfUnitsGenerator.Common {
    internal sealed class FilesGenerator {
        private readonly IEnumerable<IContentFileBuilder> _builders;

        public FilesGenerator(IEnumerable<IGenerator> generators) {
            _builders = generators.SelectMany(genetor => genetor.Generate());
        }

        public event EventHandler<IContentFile> Generating;

        public async Task Generate(FileSystem fileSystem) {
            foreach (var builder in _builders) {
                var file = builder.BuildFile();
                await fileSystem.SaveAsync(file);

                Generating?.Invoke(this, file);
            }
        }
    }
}