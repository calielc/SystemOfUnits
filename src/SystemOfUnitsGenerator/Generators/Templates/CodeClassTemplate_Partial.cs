using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Generators.Templates {
    public partial class CodeClassTemplate {
        internal string Namespace { get; set; }

        internal string ClassName { get; set; }

        internal string Symbol { get; set; }

        internal XmlDoc XmlDoc { get; set; }

        internal NamespaceCollection UsingNamespaces { get; } = new NamespaceCollection()
            .Add(NamespaceDefinition.GlogalSystem)
            .Add("System.Diagnostics")
            .Add("Newtonsoft.Json");
    }
}
