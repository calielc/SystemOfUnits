using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator {
    internal interface IGenerator {
        IContentFileBuilderCollection Generate();
    }
}