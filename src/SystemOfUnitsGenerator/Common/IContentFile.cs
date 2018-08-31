namespace SystemOfUnitsGenerator.Common {
    internal interface IContentFile {
        string Folder { get; }
        string Name { get; }
        string Content { get; }
    }
}