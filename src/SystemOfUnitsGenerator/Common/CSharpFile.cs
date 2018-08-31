using System.Diagnostics;

namespace SystemOfUnitsGenerator.Common {
    [DebuggerDisplay("{FullQualifiedClass.Class}")]
    internal struct CSharpFile : IContentFile {
        public CSharpFile(FullQualifiedClass fullQualifiedClass, string content) {
            FullQualifiedClass = fullQualifiedClass;
            Content = content;
        }

        public FullQualifiedClass FullQualifiedClass { get; }

        string IContentFile.Folder => FullQualifiedClass.Namespace.Path;

        string IContentFile.Name => FullQualifiedClass.Class + ".cs";

        public string Content { get; }
    }
}