using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Generators {
    internal interface IGenerator {
        IContentFileBuilderCollection Generate();
    }
}