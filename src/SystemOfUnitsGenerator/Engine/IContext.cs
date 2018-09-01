using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Engine {
    internal interface IContext {
        string Name { get; }
        string Symbol { get; }

        XmlDoc XmlDoc { get; }

        FullQualifiedClass CodeClass { get; }
        FullQualifiedClass TestClass { get; }
    }
}