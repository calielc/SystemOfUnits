using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.GeneratorsCurrency.Templates {
    public partial class TestClassTemplate {
        internal FullQualifiedClass CodeClass { get; set; }

        internal FullQualifiedClass TestClass { get; set; }

        internal string Symbol { get; set; }

        internal NamespaceCollection UsingNamespaces { get; } = new NamespaceCollection()
            .Add(NamespaceDefinition.GlogalSystem)
            .Add("NUnit.Framework");
    }
}
