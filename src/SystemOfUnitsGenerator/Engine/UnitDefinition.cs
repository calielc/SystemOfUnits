using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Engine {
    internal struct UnitDefinition {
        public UnitDefinition(string name, string symbol, string summary) {
            Name = name;
            Symbol = symbol;
            Summary = summary;
        }

        public UnitDefinition(string name, string symbol) {
            Name = name;
            Symbol = symbol;
            Summary = null;
        }

        public string Name { get; }
        public string Symbol { get; }
        public string Summary { get; }

        public static Context operator +(UnitNamespaces namespaces, UnitDefinition info) {
            var summary = info.Summary ?? string.Format(Resource.SummaryUnit, info.Name.ToCamelCase(), info.Symbol);
            var xmlDoc = new XmlDoc(summary);

            var codeClass = namespaces.Code + new ClassDefinition(info.Name);
            var testClass = namespaces.Test + new ClassDefinition(info.Name + "Test");

            return new Context(info.Name, info.Symbol, xmlDoc, codeClass, testClass);
        }
    }
}