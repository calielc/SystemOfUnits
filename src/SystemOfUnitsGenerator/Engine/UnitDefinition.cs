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
            var xmlDoc = info.Summary == null
                ? new XmlDoc($"Represents a {info.Name.ToCamelCase()} (symbol {info.Symbol}).")
                : new XmlDoc(info.Summary);

            var codeClass = namespaces.Code + new ClassDefinition(info.Name);
            var testClass = namespaces.Test + new ClassDefinition(info.Name + "Test");

            return new Context(info.Name, info.Symbol, xmlDoc, codeClass, testClass);
        }
    }
}