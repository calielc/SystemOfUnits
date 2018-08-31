using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace SystemOfUnitsGenerator.Common {
    [DebuggerDisplay("{BasePath}")]
    internal sealed class FileSystem {
        public FileSystem(string basePath) {
            BasePath = basePath;
        }

        public string BasePath { get; }

        public async Task SaveAsync(IContentFile contentFile) {
            await Task.Run(() => Save(contentFile));
        }

        public void Save(IContentFile contentFile) {
            var folder = Path.Combine(BasePath, contentFile.Folder);
            if (Directory.Exists(folder) == false) {
                Directory.CreateDirectory(folder);
            }

            var filename = Path.Combine(folder, contentFile.Name);
            File.WriteAllText(filename, contentFile.Content);
        }
    }
}
