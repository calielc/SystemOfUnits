using System.Diagnostics;
using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Engine {
    [DebuggerDisplay("{Name} ({Symbol})")]
    internal readonly struct Context : IContext {
        public Context(NamespaceDefinition namespaceCode, NamespaceDefinition namespaceTest, string name, string symbol) {
            Name = name;
            Symbol = symbol;
            XmlDoc = null;

            CodeClass = namespaceCode + new ClassDefinition(name);
            TestClass = namespaceTest + new ClassDefinition(name + "Test");
        }

        public Context(NamespaceDefinition namespaceCode, NamespaceDefinition namespaceTest, string name, string symbol, XmlDoc xmlDoc) : this(namespaceCode, namespaceTest, name, symbol) {
            XmlDoc = xmlDoc;
        }

        public string Name { get; }
        public string Symbol { get; }

        public XmlDoc XmlDoc { get; }

        public FullQualifiedClass CodeClass { get; }
        public FullQualifiedClass TestClass { get; }
    }
}