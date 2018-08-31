using System.Diagnostics;

namespace SystemOfUnitsGenerator.Common {
    [DebuggerDisplay("{FullQualifiedClass.Class}_{PartialName}")]
    internal struct CSharpPartialFile : IContentFile {
        public CSharpPartialFile(FullQualifiedClass fullQualifiedClass, string partialName, string content) {
            FullQualifiedClass = fullQualifiedClass;
            PartialName = partialName;
            Content = content;
        }

        public FullQualifiedClass FullQualifiedClass { get; }
        public string PartialName { get; }

        string IContentFile.Folder => FullQualifiedClass.Namespace.Path;

        string IContentFile.Name => FullQualifiedClass.Class + "_" + PartialName + ".cs";

        public string Content { get; }
    }
}