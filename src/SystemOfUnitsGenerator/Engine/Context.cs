using System.Diagnostics;
using SystemOfUnitsGenerator.Common;

namespace SystemOfUnitsGenerator.Engine {
    [DebuggerDisplay("{Name} ({Symbol})")]
    internal class Context : IContext {
        public Context(string name, string symbol, XmlDoc xmlDoc, FullQualifiedClass codeClass, FullQualifiedClass testClass) {
            Name = name;
            Symbol = symbol;
            XmlDoc = xmlDoc;
            CodeClass = codeClass;
            TestClass = testClass;
        }

        protected Context(IContext context) {
            Name = context.Name;
            Symbol = context.Symbol;
            XmlDoc = context.XmlDoc;
            CodeClass = context.CodeClass;
            TestClass = context.TestClass;
        }

        public string Name { get; }
        public string Symbol { get; }

        public XmlDoc XmlDoc { get; }

        public FullQualifiedClass CodeClass { get; }
        public FullQualifiedClass TestClass { get; }
    }
}